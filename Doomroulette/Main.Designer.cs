namespace Doomroulette
{

    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.radio_sk_baby = new System.Windows.Forms.RadioButton();
            this.radio_sk_hard = new System.Windows.Forms.RadioButton();
            this.radio_sk_nightmare = new System.Windows.Forms.RadioButton();
            this.radio_sk_medium = new System.Windows.Forms.RadioButton();
            this.radio_sk_easy = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRunPrevious = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkEnableDate = new System.Windows.Forms.CheckBox();
            this.createdDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdvancedSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numMinrating = new System.Windows.Forms.NumericUpDown();
            this.chkIncludeVanilla = new System.Windows.Forms.CheckBox();
            this.chkIncludePorts = new System.Windows.Forms.CheckBox();
            this.chkIncludeMegawads = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstAdditionalWads = new System.Windows.Forms.ListBox();
            this.btnRemoveWad = new System.Windows.Forms.Button();
            this.btnAddWad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpGames = new System.Windows.Forms.GroupBox();
            this.radioDoom2 = new System.Windows.Forms.RadioButton();
            this.radioFreedoom2 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnPlayselected = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listDislikedWads = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listLikedWads = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinrating)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpGames.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(266, 189);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(191, 78);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(263, 335);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(257, 92);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Ready";
            // 
            // radio_sk_baby
            // 
            this.radio_sk_baby.AutoSize = true;
            this.radio_sk_baby.Location = new System.Drawing.Point(19, 21);
            this.radio_sk_baby.Name = "radio_sk_baby";
            this.radio_sk_baby.Size = new System.Drawing.Size(152, 21);
            this.radio_sk_baby.TabIndex = 3;
            this.radio_sk_baby.Tag = "sk_baby";
            this.radio_sk_baby.Text = "I\'m too young to die";
            this.radio_sk_baby.UseVisualStyleBackColor = true;
            this.radio_sk_baby.CheckedChanged += new System.EventHandler(this.skillChanged);
            // 
            // radio_sk_hard
            // 
            this.radio_sk_hard.AutoSize = true;
            this.radio_sk_hard.Location = new System.Drawing.Point(19, 102);
            this.radio_sk_hard.Name = "radio_sk_hard";
            this.radio_sk_hard.Size = new System.Drawing.Size(118, 21);
            this.radio_sk_hard.TabIndex = 4;
            this.radio_sk_hard.Tag = "sk_hard";
            this.radio_sk_hard.Text = "Ultra-Violence";
            this.radio_sk_hard.UseVisualStyleBackColor = true;
            this.radio_sk_hard.CheckedChanged += new System.EventHandler(this.skillChanged);
            // 
            // radio_sk_nightmare
            // 
            this.radio_sk_nightmare.AutoSize = true;
            this.radio_sk_nightmare.Location = new System.Drawing.Point(19, 129);
            this.radio_sk_nightmare.Name = "radio_sk_nightmare";
            this.radio_sk_nightmare.Size = new System.Drawing.Size(97, 21);
            this.radio_sk_nightmare.TabIndex = 5;
            this.radio_sk_nightmare.Tag = "sk_nightmare";
            this.radio_sk_nightmare.Text = "Nightmare!";
            this.radio_sk_nightmare.UseVisualStyleBackColor = true;
            this.radio_sk_nightmare.CheckedChanged += new System.EventHandler(this.skillChanged);
            // 
            // radio_sk_medium
            // 
            this.radio_sk_medium.AutoSize = true;
            this.radio_sk_medium.Checked = true;
            this.radio_sk_medium.Location = new System.Drawing.Point(19, 75);
            this.radio_sk_medium.Name = "radio_sk_medium";
            this.radio_sk_medium.Size = new System.Drawing.Size(121, 21);
            this.radio_sk_medium.TabIndex = 6;
            this.radio_sk_medium.TabStop = true;
            this.radio_sk_medium.Tag = "sk_medium";
            this.radio_sk_medium.Text = "Hurt me plenty";
            this.radio_sk_medium.UseVisualStyleBackColor = true;
            this.radio_sk_medium.CheckedChanged += new System.EventHandler(this.skillChanged);
            // 
            // radio_sk_easy
            // 
            this.radio_sk_easy.AutoSize = true;
            this.radio_sk_easy.Location = new System.Drawing.Point(19, 48);
            this.radio_sk_easy.Name = "radio_sk_easy";
            this.radio_sk_easy.Size = new System.Drawing.Size(147, 21);
            this.radio_sk_easy.TabIndex = 7;
            this.radio_sk_easy.Tag = "sk_easy";
            this.radio_sk_easy.Text = "Hey, not too rough";
            this.radio_sk_easy.UseVisualStyleBackColor = true;
            this.radio_sk_easy.CheckedChanged += new System.EventHandler(this.skillChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_sk_baby);
            this.groupBox1.Controls.Add(this.radio_sk_nightmare);
            this.groupBox1.Controls.Add(this.radio_sk_medium);
            this.groupBox1.Controls.Add(this.radio_sk_hard);
            this.groupBox1.Controls.Add(this.radio_sk_easy);
            this.groupBox1.Location = new System.Drawing.Point(541, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 167);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skill";
            // 
            // btnRunPrevious
            // 
            this.btnRunPrevious.Location = new System.Drawing.Point(289, 273);
            this.btnRunPrevious.Name = "btnRunPrevious";
            this.btnRunPrevious.Size = new System.Drawing.Size(141, 49);
            this.btnRunPrevious.TabIndex = 9;
            this.btnRunPrevious.Text = "Run last played";
            this.btnRunPrevious.UseVisualStyleBackColor = true;
            this.btnRunPrevious.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkEnableDate);
            this.groupBox2.Controls.Add(this.createdDate);
            this.groupBox2.Controls.Add(this.btnAdvancedSettings);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numMinrating);
            this.groupBox2.Controls.Add(this.chkIncludeVanilla);
            this.groupBox2.Controls.Add(this.chkIncludePorts);
            this.groupBox2.Controls.Add(this.chkIncludeMegawads);
            this.groupBox2.Location = new System.Drawing.Point(541, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 278);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkEnableDate
            // 
            this.chkEnableDate.AutoSize = true;
            this.chkEnableDate.Location = new System.Drawing.Point(18, 167);
            this.chkEnableDate.Name = "chkEnableDate";
            this.chkEnableDate.Size = new System.Drawing.Size(112, 21);
            this.chkEnableDate.TabIndex = 14;
            this.chkEnableDate.Text = "Created date";
            this.chkEnableDate.UseVisualStyleBackColor = true;
            this.chkEnableDate.CheckedChanged += new System.EventHandler(this.chkDisableDate_CheckedChanged);
            // 
            // createdDate
            // 
            this.createdDate.Enabled = false;
            this.createdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.createdDate.Location = new System.Drawing.Point(19, 191);
            this.createdDate.Name = "createdDate";
            this.createdDate.Size = new System.Drawing.Size(121, 22);
            this.createdDate.TabIndex = 12;
            // 
            // btnAdvancedSettings
            // 
            this.btnAdvancedSettings.Location = new System.Drawing.Point(20, 234);
            this.btnAdvancedSettings.Name = "btnAdvancedSettings";
            this.btnAdvancedSettings.Size = new System.Drawing.Size(89, 28);
            this.btnAdvancedSettings.TabIndex = 11;
            this.btnAdvancedSettings.Text = "Advanced";
            this.btnAdvancedSettings.UseVisualStyleBackColor = true;
            this.btnAdvancedSettings.Click += new System.EventHandler(this.btnAdvancedSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minimum rating";
            // 
            // numMinrating
            // 
            this.numMinrating.Location = new System.Drawing.Point(20, 133);
            this.numMinrating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMinrating.Name = "numMinrating";
            this.numMinrating.Size = new System.Drawing.Size(85, 22);
            this.numMinrating.TabIndex = 3;
            this.numMinrating.ValueChanged += new System.EventHandler(this.numMinrating_ValueChanged);
            // 
            // chkIncludeVanilla
            // 
            this.chkIncludeVanilla.AutoSize = true;
            this.chkIncludeVanilla.Location = new System.Drawing.Point(19, 76);
            this.chkIncludeVanilla.Name = "chkIncludeVanilla";
            this.chkIncludeVanilla.Size = new System.Drawing.Size(155, 21);
            this.chkIncludeVanilla.TabIndex = 2;
            this.chkIncludeVanilla.Text = "Include vanilla wads";
            this.chkIncludeVanilla.UseVisualStyleBackColor = true;
            this.chkIncludeVanilla.CheckedChanged += new System.EventHandler(this.settingsChanged);
            // 
            // chkIncludePorts
            // 
            this.chkIncludePorts.AutoSize = true;
            this.chkIncludePorts.Location = new System.Drawing.Point(19, 49);
            this.chkIncludePorts.Name = "chkIncludePorts";
            this.chkIncludePorts.Size = new System.Drawing.Size(140, 21);
            this.chkIncludePorts.TabIndex = 1;
            this.chkIncludePorts.Text = "Include port wads";
            this.chkIncludePorts.UseVisualStyleBackColor = true;
            this.chkIncludePorts.CheckedChanged += new System.EventHandler(this.settingsChanged);
            // 
            // chkIncludeMegawads
            // 
            this.chkIncludeMegawads.AutoSize = true;
            this.chkIncludeMegawads.Location = new System.Drawing.Point(20, 22);
            this.chkIncludeMegawads.Name = "chkIncludeMegawads";
            this.chkIncludeMegawads.Size = new System.Drawing.Size(146, 21);
            this.chkIncludeMegawads.TabIndex = 0;
            this.chkIncludeMegawads.Text = "Include Megawads";
            this.chkIncludeMegawads.UseVisualStyleBackColor = true;
            this.chkIncludeMegawads.CheckedChanged += new System.EventHandler(this.settingsChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 566);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstAdditionalWads);
            this.tabPage1.Controls.Add(this.btnRemoveWad);
            this.tabPage1.Controls.Add(this.btnAddWad);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.grpGames);
            this.tabPage1.Controls.Add(this.btnPlay);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.btnRunPrevious);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstAdditionalWads
            // 
            this.lstAdditionalWads.FormattingEnabled = true;
            this.lstAdditionalWads.ItemHeight = 16;
            this.lstAdditionalWads.Location = new System.Drawing.Point(11, 332);
            this.lstAdditionalWads.Name = "lstAdditionalWads";
            this.lstAdditionalWads.Size = new System.Drawing.Size(223, 148);
            this.lstAdditionalWads.TabIndex = 16;
            // 
            // btnRemoveWad
            // 
            this.btnRemoveWad.Location = new System.Drawing.Point(81, 486);
            this.btnRemoveWad.Name = "btnRemoveWad";
            this.btnRemoveWad.Size = new System.Drawing.Size(81, 31);
            this.btnRemoveWad.TabIndex = 15;
            this.btnRemoveWad.Text = "Remove";
            this.btnRemoveWad.UseVisualStyleBackColor = true;
            this.btnRemoveWad.Click += new System.EventHandler(this.btnRemoveWad_Click);
            // 
            // btnAddWad
            // 
            this.btnAddWad.Location = new System.Drawing.Point(13, 486);
            this.btnAddWad.Name = "btnAddWad";
            this.btnAddWad.Size = new System.Drawing.Size(62, 31);
            this.btnAddWad.TabIndex = 14;
            this.btnAddWad.Text = "Add";
            this.btnAddWad.UseVisualStyleBackColor = true;
            this.btnAddWad.Click += new System.EventHandler(this.btnAddWad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Additional files";
            // 
            // grpGames
            // 
            this.grpGames.Controls.Add(this.radioDoom2);
            this.grpGames.Controls.Add(this.radioFreedoom2);
            this.grpGames.Location = new System.Drawing.Point(266, 37);
            this.grpGames.Name = "grpGames";
            this.grpGames.Size = new System.Drawing.Size(200, 98);
            this.grpGames.TabIndex = 11;
            this.grpGames.TabStop = false;
            this.grpGames.Text = "Select Game";
            // 
            // radioDoom2
            // 
            this.radioDoom2.AutoSize = true;
            this.radioDoom2.Checked = true;
            this.radioDoom2.Location = new System.Drawing.Point(15, 63);
            this.radioDoom2.Name = "radioDoom2";
            this.radioDoom2.Size = new System.Drawing.Size(78, 21);
            this.radioDoom2.TabIndex = 3;
            this.radioDoom2.TabStop = true;
            this.radioDoom2.Text = "Doom 2";
            this.radioDoom2.UseVisualStyleBackColor = true;
            this.radioDoom2.CheckedChanged += new System.EventHandler(this.gameChanged);
            // 
            // radioFreedoom2
            // 
            this.radioFreedoom2.AutoSize = true;
            this.radioFreedoom2.Location = new System.Drawing.Point(15, 33);
            this.radioFreedoom2.Name = "radioFreedoom2";
            this.radioFreedoom2.Size = new System.Drawing.Size(149, 21);
            this.radioFreedoom2.TabIndex = 1;
            this.radioFreedoom2.Text = "Freedoom Phase 2";
            this.radioFreedoom2.UseVisualStyleBackColor = true;
            this.radioFreedoom2.CheckedChanged += new System.EventHandler(this.gameChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnShowInfo);
            this.tabPage2.Controls.Add(this.btnPlayselected);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(272, 421);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(158, 29);
            this.btnShowInfo.TabIndex = 3;
            this.btnShowInfo.Text = "Show info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnPlayselected
            // 
            this.btnPlayselected.Location = new System.Drawing.Point(272, 368);
            this.btnPlayselected.Name = "btnPlayselected";
            this.btnPlayselected.Size = new System.Drawing.Size(158, 47);
            this.btnPlayselected.TabIndex = 2;
            this.btnPlayselected.Text = "Play selected Wad";
            this.btnPlayselected.UseVisualStyleBackColor = true;
            this.btnPlayselected.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listDislikedWads);
            this.groupBox4.Location = new System.Drawing.Point(374, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 287);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Disliked Wads";
            // 
            // listDislikedWads
            // 
            this.listDislikedWads.FormattingEnabled = true;
            this.listDislikedWads.ItemHeight = 16;
            this.listDislikedWads.Location = new System.Drawing.Point(7, 22);
            this.listDislikedWads.Name = "listDislikedWads";
            this.listDislikedWads.Size = new System.Drawing.Size(279, 260);
            this.listDislikedWads.TabIndex = 0;
            this.listDislikedWads.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listDislikedWads_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listLikedWads);
            this.groupBox3.Location = new System.Drawing.Point(19, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 287);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liked wads";
            // 
            // listLikedWads
            // 
            this.listLikedWads.FormattingEnabled = true;
            this.listLikedWads.ItemHeight = 16;
            this.listLikedWads.Location = new System.Drawing.Point(7, 22);
            this.listLikedWads.Name = "listLikedWads";
            this.listLikedWads.Size = new System.Drawing.Size(280, 260);
            this.listLikedWads.TabIndex = 0;
            this.listLikedWads.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listLikedWads_MouseClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 581);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "DoomRoulette";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinrating)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpGames.ResumeLayout(false);
            this.grpGames.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton radio_sk_baby;
        private System.Windows.Forms.RadioButton radio_sk_hard;
        private System.Windows.Forms.RadioButton radio_sk_nightmare;
        private System.Windows.Forms.RadioButton radio_sk_medium;
        private System.Windows.Forms.RadioButton radio_sk_easy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRunPrevious;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkIncludeVanilla;
        private System.Windows.Forms.CheckBox chkIncludePorts;
        private System.Windows.Forms.CheckBox chkIncludeMegawads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMinrating;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPlayselected;
        private System.Windows.Forms.ListBox listDislikedWads;
        private System.Windows.Forms.ListBox listLikedWads;
        private System.Windows.Forms.Button btnAdvancedSettings;
        private System.Windows.Forms.GroupBox grpGames;
        private System.Windows.Forms.RadioButton radioDoom2;
        private System.Windows.Forms.RadioButton radioFreedoom2;
        private System.Windows.Forms.DateTimePicker createdDate;
        private System.Windows.Forms.CheckBox chkEnableDate;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveWad;
        private System.Windows.Forms.Button btnAddWad;
        private System.Windows.Forms.ListBox lstAdditionalWads;
    }
}

