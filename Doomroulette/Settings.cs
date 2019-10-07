using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doomroulette
{
    public partial class Settings : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public Settings(bool willShowcontrolbox)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            InitializeComponent();
            this.ControlBox = willShowcontrolbox;
        }

        private static Dictionary<string, string> configField;
        
        public static Dictionary<string, string> configValues
        {
            get
            {
                return configField != null ? configField : readConfigFile();
            }
            set
            {
                configField = value;
            }
        }
        private static string cwd = System.IO.Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

        private static Dictionary<string, string> readConfigFile()
        {
            if (!File.Exists(@cwd + "/config.ini"))
            {
                configValues = new Dictionary<string, string>();
                configValues["chkIncludeMegawads"] = "True";
                configValues["chkIncludePorts"] = "True";
                configValues["chkIncludeVanilla"] = "True";
                saveConfigFile();
            }

            string[] lines = System.IO.File.ReadAllLines(@cwd + "/config.ini");
            configValues = new Dictionary<string, string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != "")
                {
                    string[] line = lines[i].Split(new string[] { "=", " = " }, StringSplitOptions.RemoveEmptyEntries);
                    if (line.Length == 2)
                        configValues.Add(line[0], line[1]);
                }

            }
            return configValues;
        }

        public static void saveConfigFile()
        {
            var lines = Settings.configValues.Select(a => a.Key + "=" + a.Value).ToArray();
            File.WriteAllLines(@cwd + "/config.ini", lines);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files|*.exe";
            openFileDialog.Title = "Select a Executable File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.configValues["doompath"] = openFileDialog.FileName;
                updateTextField("txtDoompath", openFileDialog.FileName);
            }
        }

        private void btnBrowsedownloaded_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
            if (openFolderDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.configValues["downloadedWadsFolder"] = openFolderDialog.SelectedPath;
                updateTextField("txtdownloadedWadsFolder", openFolderDialog.SelectedPath);
            }
        }

        private void btnBrowseIwad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Iwad Files|*.wad";
            openFileDialog.Title = "Select a wad File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string buttonName = ((Button)sender).Name;
                string name = string.Empty;
                switch (buttonName)
                {

                    case "btnFreedoom2":
                        name = "txtFreedoom2";
                        Settings.configValues["freeDoom2Iwad"] = openFileDialog.FileName;
                        break;

                    case "btnDoom2":
                        name = "txtDoom2";
                        Settings.configValues["doom2Iwad"] = openFileDialog.FileName;
                        break;
                }
                updateTextField(name, openFileDialog.FileName);
            }
        }

        private void updateTextField(string name, string value)
        {
            MaterialSingleLineTextField text = (MaterialSingleLineTextField)this.Controls.Find(name, true)[0];
            text.Text = value;
            text.SelectionStart = text.Text.Length;
            text.Refresh();
        }

        private bool validate()
        {

            return false;
        }

        private bool validateInput()
        {
            bool doomPathValid = Path.GetExtension(txtDoompath.Text) != "" ? true : false;
            return doomPathValid;
        }

        private void btnSave(object sender, EventArgs e)
        {

            if (!validateInput())
            {
                MessageBox.Show("One or more of the inputfields are not valid!");
                return;
            }

            Settings.configValues["freeDoom2Iwad"] = txtFreedoom2.Text;
            Settings.configValues["doom2Iwad"] = txtDoom2.Text;
            Settings.configValues["doompath"] = txtDoompath.Text;
            Settings.configValues["folder"] = txtdownloadedWadsFolder.Text;
            saveConfigFile();
            Close();
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            if (configValues.ContainsKey("doompath"))
            {
                updateTextField("txtDoompath", configValues["doompath"]);
            }

            if (configValues.ContainsKey("folder"))
            {
                updateTextField("txtdownloadedWadsFolder", configValues["folder"]);
            }

            if (configValues.ContainsKey("freeDoom2Iwad"))
            {
                updateTextField("txtFreedoom2", configValues["freeDoom2Iwad"]);
            }

            if (configValues.ContainsKey("doom2Iwad"))
            {
                updateTextField("txtDoom2", configValues["doom2Iwad"]);
            }

        }
    }
}
