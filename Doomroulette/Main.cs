using Doomroulette.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static Doomroulette.RateWad;
using System.Diagnostics;

namespace Doomroulette
{
    public partial class frmMain : Form
    {
        private bool willDownloadNewWad = true;
        private Thread randomWadThread = null;
        delegate void StringArgReturningVoidDelegate(string text);
        private WadInfo[] likedWads;
        private WadInfo[] dislikedWads;
        private WadManager wadManager;
        private List<AdditionalWad> additionalWads;

        public frmMain()
        {
            InitializeComponent();

            wadManager = new WadManager();

            if (wadManager.missingExecutablePath())
            {
                openSettingsDialog(willShowcontrolbox: false);
                setDefaultSettings();
            }
            populateSettings();
            populateHistoryList();
            populateAdditionalWadList();
        }

        private void openSettingsDialog(bool willShowcontrolbox = true)
        {
            Settings settings = new Settings(willShowcontrolbox);
            settings.ShowDialog();
        }
        
        private void populateAdditionalWadList()
        {
            lstAdditionalWads.Items.Clear();
            additionalWads = new List<AdditionalWad>();
            if (!wadManager.emptyDb())
            {
                additionalWads = wadManager.getAdditionalWads().ToList();
                lstAdditionalWads.Items.AddRange(additionalWads.Select(a => a.name).ToArray());
            }
        }

        private void populateHistoryList()
        {
            listLikedWads.Items.Clear();
            listDislikedWads.Items.Clear();
            if (!wadManager.emptyDb())
            {
                likedWads = wadManager.getLikedWads();
                dislikedWads = wadManager.getDislikedWads();

                listLikedWads.Items.AddRange(likedWads.Select(a => a.content.title).ToArray());
                listDislikedWads.Items.AddRange(dislikedWads.Select(a => a.content.title).ToArray());
            }
        }

        private void populateSettings()
        {
            wadManager.settings.includeMegawads = Settings.configValues["chkIncludeMegawads"] == "True";
            chkIncludeMegawads.Checked = wadManager.settings.includeMegawads;

            wadManager.settings.includePorts = Settings.configValues["chkIncludePorts"] == "True";
            chkIncludePorts.Checked = wadManager.settings.includePorts;
            
            wadManager.settings.includeVanilla = Settings.configValues["chkIncludeVanilla"] == "True";
            chkIncludeVanilla.Checked = wadManager.settings.includeVanilla;

            wadManager.settings.minimumRating = double.Parse(Settings.configValues["numMinrating"]);

            wadManager.downloadedWadsFolder = Settings.configValues["folder"];

            wadManager.doompath = Settings.configValues["doompath"];

            numMinrating.Value = (decimal) wadManager.settings.minimumRating;
            setSkill(Settings.configValues["skill"]);
            setGame(Settings.configValues["game"]);
        }

        private void setDefaultSettings()
        {
            if (wadManager.settings.includeMegawads)
            {
                chkIncludeMegawads.Checked = true;
            }

            if (wadManager.settings.includePorts)
            {
                chkIncludePorts.Checked = true;
            }

            if (wadManager.settings.includeVanilla)
            {
                chkIncludeVanilla.Checked = true;
            }

            numMinrating.Value = (decimal)wadManager.settings.minimumRating;
            setSkill(WadManager.Skill.sk_medium.ToString());
            setGame(WadManager.SelectedGame.Doom2.ToString());
        }

        private void refreshWadInfoList()
        {
            SetText("Downloading cache from Doomworld /idgames database. \nPlease wait... ");
            this.Invoke((MethodInvoker)delegate {
                btnPlay.Enabled = false;
                btnRunPrevious.Enabled = false;
            });
           
            wadManager.updateWadInfoList();

            this.Invoke((MethodInvoker)delegate {
                btnPlay.Enabled = true;
                btnRunPrevious.Enabled = true;
            });
            SetText("Ready...");

        }

        private void settingsChanged(object sender, EventArgs e)
        {
            string chbxName = ((CheckBox)sender).Name;
            CheckBox checkbox = (CheckBox)this.Controls.Find(chbxName, true)[0];
            Settings.configValues[chbxName] = checkbox.Checked.ToString();
            Settings.saveConfigFile();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            willDownloadNewWad = true;
            this.randomWadThread =
                new Thread(new ThreadStart(this.play));

            this.randomWadThread.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            willDownloadNewWad = false;
            this.randomWadThread =
               new Thread(new ThreadStart(this.play));

            this.randomWadThread.Start();

        }

        private void updateDownloadProgress(string progress)
        {
            SetText(progress);
        }

        private async void play()
        {
            try
            {
                WadInfo chosenWad;
                wadManager.settings.minimumRating = (double)numMinrating.Value;
                wadManager.settings.includeMegawads = chkIncludeMegawads.Checked;
                wadManager.settings.includePorts = chkIncludePorts.Checked;
                wadManager.settings.includeVanilla = chkIncludeVanilla.Checked;
                wadManager.settings.createdDate = chkEnableDate.Checked ? createdDate.Value.ToString() : null;
    
                disableButtons();
                if (willDownloadNewWad)
                {

                    if (!chkIncludeMegawads.Checked && !chkIncludePorts.Checked && !chkIncludeVanilla.Checked)
                    {
                        MessageBox.Show("Please select one of the settings");
                        enableButtons();
                        return;
                    }


                    SetText("Finding Wad for you...");
                    chosenWad = wadManager.getRandomWad();

                    SetText("Downloading Wad...");
                    wadManager.currentFile = chosenWad.content.filename;
                    var filepath = await wadManager.downloadWad(chosenWad, updateDownloadProgress);

                    SetText("Unzipping files...");
                    string[] files = wadManager.unzipFile(filepath);
                    SetText("Starting up Doom");

                    Process process = wadManager.startDoom(Path.GetFileNameWithoutExtension(wadManager.currentFile), files, additionalWads.ToArray());
                    
                    process.WaitForExit();

                    this.Invoke((MethodInvoker)delegate {
                        RateWad wadrating = new RateWad(chosenWad);
                        DialogResult dr = wadrating.ShowDialog(this);
                        enableButtons();
                        if (wadrating.rating == RatingTypes.Unrated)
                            return;

                        wadManager.setWadRating(chosenWad.content.id, wadrating.rating == RatingTypes.Liked);
                        populateHistoryList();

                    });
                }
                else
                {
                    chosenWad = wadManager.getLastPlayedWad();
                    wadManager.currentFile = Path.GetFileNameWithoutExtension(chosenWad.content.filename);

                    string[] files = wadManager.getFiles(wadManager.downloadedWadsFolder + "/" + wadManager.currentFile);
                    wadManager.startDoom(wadManager.currentFile, files, additionalWads.ToArray());
                    enableButtons();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                enableButtons();
            }
            finally
            {
                SetText("Ready...");

            }

        }

        private void enableButtons()
        {
            if (this.btnRunPrevious.InvokeRequired)
            {
                BeginInvoke((Action)delegate () { this.btnRunPrevious.Enabled = true; });
            }
            else
            {
                this.btnRunPrevious.Enabled = true;
            }

            if (this.btnPlay.InvokeRequired)
            {
                BeginInvoke((Action)delegate () { this.btnPlay.Enabled = true; });
            }
            else
            {
                this.btnPlay.Enabled = true;
            }
        }

        private void disableButtons()
        {
            if (this.btnRunPrevious.InvokeRequired)
            {
                BeginInvoke((Action)delegate () { this.btnRunPrevious.Enabled = false; });
            }
            else
            {
                this.btnRunPrevious.Enabled = false;
            }

            if (this.btnPlay.InvokeRequired)
            {
                BeginInvoke((Action)delegate () { this.btnPlay.Enabled = false; });
            }
            else
            {
                this.btnPlay.Enabled = false;
            }
        }

        private void SetText(string text)
        {
            if (this.lblStatus.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lblStatus.Text = text;
            }
        }

        private void setSkill(string skill)
        {
            RadioButton radioBtn = new RadioButton();
            switch (skill)
            {
                case "sk_baby":
                        radioBtn = (RadioButton)this.Controls.Find("radio_sk_baby", true)[0];
                    break;
                case "sk_easy":
                        radioBtn = (RadioButton)this.Controls.Find("radio_sk_easy", true)[0];
                    break;
                case "sk_medium":
                        radioBtn = (RadioButton)this.Controls.Find("radio_sk_medium", true)[0];
                    break;
                case "sk_hard":
                        radioBtn = (RadioButton)this.Controls.Find("radio_sk_hard", true)[0];
                    break;
                case "sk_nightmare":
                        radioBtn = (RadioButton)this.Controls.Find("radio_sk_nightmare", true)[0];
                    break;
            }
            radioBtn.Checked = true;
            Settings.configValues["skill"] = wadManager.skill.ToString();
            Settings.saveConfigFile();
        }
        private void setGame(string game)
        {
            RadioButton radioBtn = new RadioButton();
            switch (game)
            {
                case "FreeDoom1":
                    radioBtn = (RadioButton)this.Controls.Find("radioFreedoom1", true)[0];
                    break;
                case "FreeDoom2":
                    radioBtn = (RadioButton)this.Controls.Find("radioFreedoom2", true)[0];
                    break;
                case "Doom":
                    radioBtn = (RadioButton)this.Controls.Find("radioDoom", true)[0];
                    break;
                case "Doom2":
                    radioBtn = (RadioButton)this.Controls.Find("radioDoom2", true)[0];
                    break;
            }
            radioBtn.Checked = true;
            Settings.configValues["game"] = wadManager.selectedGame.ToString();
            Settings.saveConfigFile();
        }

        private void skillChanged(object sender, EventArgs e)
        {

            RadioButton radioBtn = (RadioButton)sender;
            switch (radioBtn.Tag)
            {
                case "sk_baby":
                    if(radioBtn.Checked)
                        wadManager.skill = WadManager.Skill.sk_baby;
                    break;
                case "sk_easy":
                    if (radioBtn.Checked)
                        wadManager.skill = WadManager.Skill.sk_easy;
                    break;
                case "sk_medium":
                    if (radioBtn.Checked)
                        wadManager.skill = WadManager.Skill.sk_medium;
                    break;
                case "sk_hard":
                    if (radioBtn.Checked)
                        wadManager.skill = WadManager.Skill.sk_hard;
                    break;
                case "sk_nightmare":
                    if (radioBtn.Checked)
                        wadManager.skill = WadManager.Skill.sk_nightmare;
                    break;
            }
            Settings.configValues["skill"] = wadManager.skill.ToString();
            Settings.saveConfigFile();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createdDate.ValueChanged += new System.EventHandler(createdDate_ValueChanged); 
            createdDate.Value = Settings.configValues.ContainsKey("createdDate") ? DateTime.Parse(Settings.configValues["createdDate"]) : DateTime.Parse("1994-09-30");
            createdDate.MinDate = DateTime.Parse("1994-09-30");
            createdDate.MaxDate = DateTime.Today;

            bool enableCreatedDate = Settings.configValues.ContainsKey("enableCreatedDate") ? Settings.configValues["enableCreatedDate"] == "True" : false;
            createdDate.Enabled = enableCreatedDate;
            chkEnableDate.Checked = enableCreatedDate;


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = -1;
            WadInfo chosenWad;
            string currentFile = "";
            if(listLikedWads.SelectedIndex != -1)
            {
                selectedIndex = listLikedWads.SelectedIndex;
                chosenWad = likedWads[selectedIndex];
                currentFile = Path.GetFileNameWithoutExtension(chosenWad.content.filename);
                wadManager.currentFile = currentFile;

            } else if(listDislikedWads.SelectedIndex != -1){

                selectedIndex = listDislikedWads.SelectedIndex;
                chosenWad = dislikedWads[selectedIndex];
                currentFile = Path.GetFileNameWithoutExtension(chosenWad.content.filename);
                wadManager.currentFile = currentFile;
                
            }
            
            if(selectedIndex != -1)
            {
                string[] files = wadManager.getFiles(wadManager.downloadedWadsFolder + "/" + currentFile);
                wadManager.startDoom(Path.GetFileNameWithoutExtension(wadManager.currentFile), files, additionalWads.ToArray());
            }
            
        }

        private void btnAdvancedSettings_Click(object sender, EventArgs e)
        {
            openSettingsDialog();
        }

        private void numMinrating_ValueChanged(object sender, EventArgs e)
        {
            string name = ((NumericUpDown)sender).Name;
            NumericUpDown numericUpDown = (NumericUpDown)this.Controls.Find(name, true)[0];
            Settings.configValues[name] = numericUpDown.Value.ToString();
            Settings.saveConfigFile();

        }

        private void gameChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;
            switch (radioBtn.Name)
            {
                case "radioFreedoom2":
                    if (radioBtn.Checked)
                        wadManager.selectedGame = WadManager.SelectedGame.FreeDoom2;
                    break;
                case "radioDoom2":
                    if (radioBtn.Checked)
                        wadManager.selectedGame = WadManager.SelectedGame.Doom2;
                    break;
            }
            Settings.configValues["game"] = wadManager.selectedGame.ToString();
            Settings.saveConfigFile();

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (wadManager.emptyDb())
            {
                willDownloadNewWad = false;
                this.randomWadThread =
                   new Thread(new ThreadStart(refreshWadInfoList));

                this.randomWadThread.Start();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void createdDate_ValueChanged(object sender, EventArgs e)
        {
            string selectedDate = ((DateTimePicker)sender).Value.ToString();
            Settings.configValues["createdDate"] = selectedDate;
            Settings.saveConfigFile();
        }

        private void chkDisableDate_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = ((CheckBox)sender).Checked;
            createdDate.Enabled = isChecked;
            Settings.configValues["enableCreatedDate"] = isChecked.ToString();
            Settings.saveConfigFile();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            bool isLikedWad = listLikedWads.SelectedIndex != -1 ? true : false;
            int selectedIndex = isLikedWad ? listLikedWads.SelectedIndex : listDislikedWads.SelectedIndex;
            if(selectedIndex != -1)
            {
                WadInfo selectedWad = isLikedWad ? likedWads[selectedIndex] : dislikedWads[selectedIndex];
                try
                {
                    wadManager.openTextFile(selectedWad);
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listDislikedWads_MouseClick(object sender, MouseEventArgs e)
        {
            listLikedWads.SelectedIndex = -1;
        }

        private void listLikedWads_MouseClick(object sender, MouseEventArgs e)
        {
            listDislikedWads.SelectedIndex = -1;
        }

        private void btnAddWad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "mod Files|*.wad; *.pk3;";
            openFileDialog.Title = "Select a wad File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string result = openFileDialog.FileName;
                AdditionalWad newWad = new AdditionalWad()
                {
                    ID = additionalWads.Count > 0 ? additionalWads[additionalWads.Count - 1].ID + 1 : 0,
                    filename = result,
                    name = Path.GetFileNameWithoutExtension(result)
                };

                additionalWads.Add(newWad);
                wadManager.addAdditionalWad(newWad);
                lstAdditionalWads.Items.Add(newWad.name);
                
            }
        }

        private void btnRemoveWad_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstAdditionalWads.SelectedIndex;
            if(selectedIndex != -1)
            {
                AdditionalWad toRemove = additionalWads[selectedIndex];
                wadManager.deleteAdditionalWad(toRemove.ID);
                lstAdditionalWads.Items.RemoveAt(selectedIndex);
            }
        }
    }
}
