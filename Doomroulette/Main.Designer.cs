﻿using MaterialSkin.Controls;
using System.Drawing.Text;
using Doomroulette.Properties;
using System.Drawing;
using System.Runtime.InteropServices;
using System;
using System.Linq;

namespace Doomroulette
{

    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private PrivateFontCollection privateFontCollection = new PrivateFontCollection();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.radio_sk_baby = new MaterialSkin.Controls.MaterialRadioButton();
            this.radio_sk_hard = new MaterialSkin.Controls.MaterialRadioButton();
            this.radio_sk_nightmare = new MaterialSkin.Controls.MaterialRadioButton();
            this.radio_sk_medium = new MaterialSkin.Controls.MaterialRadioButton();
            this.radio_sk_easy = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRunPrevious = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkEnableDate = new MaterialSkin.Controls.MaterialCheckBox();
            this.createdDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdvancedSettings = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.numMinrating = new System.Windows.Forms.NumericUpDown();
            this.chkIncludeVanilla = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkIncludePorts = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkIncludeMegawads = new MaterialSkin.Controls.MaterialCheckBox();
            this.tabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstAdditionalWads = new System.Windows.Forms.ListBox();
            this.btnRemoveWad = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAddWad = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.grpGames = new System.Windows.Forms.GroupBox();
            this.radioDoom2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioFreedoom2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRateWad = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkFilterUnrated = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkFilterDisliked = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkFilterLiked = new MaterialSkin.Controls.MaterialCheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.listPlayedWads = new System.Windows.Forms.ListBox();
            this.btnPlayrandomLiked = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNextWads = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPreviousWads = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnShowInfo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPlayselected = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinrating)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpGames.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPlay.Location = new System.Drawing.Point(327, 177);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(185, 80);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(300, 332);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(257, 92);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Ready";
            // 
            // radio_sk_baby
            // 
            this.radio_sk_baby.AutoSize = true;
            this.radio_sk_baby.Depth = 0;
            this.radio_sk_baby.Font = new System.Drawing.Font("Roboto", 10F);
            this.radio_sk_baby.Location = new System.Drawing.Point(19, 26);
            this.radio_sk_baby.Margin = new System.Windows.Forms.Padding(0);
            this.radio_sk_baby.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio_sk_baby.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio_sk_baby.Name = "radio_sk_baby";
            this.radio_sk_baby.Ripple = true;
            this.radio_sk_baby.Size = new System.Drawing.Size(181, 30);
            this.radio_sk_baby.TabIndex = 3;
            this.radio_sk_baby.Tag = "sk_baby";
            this.radio_sk_baby.Text = "I\'m too young to die";
            this.radio_sk_baby.UseVisualStyleBackColor = true;
            this.radio_sk_baby.CheckedChanged += new System.EventHandler(this.skillChanged);
            // 
            // radio_sk_hard
            // 
            this.radio_sk_hard.AutoSize = true;
            this.radio_sk_hard.Depth = 0;
            this.radio_sk_hard.Font = new System.Drawing.Font("Roboto", 10F);
            this.radio_sk_hard.Location = new System.Drawing.Point(19, 137);
            this.radio_sk_hard.Margin = new System.Windows.Forms.Padding(0);
            this.radio_sk_hard.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio_sk_hard.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio_sk_hard.Name = "radio_sk_hard";
            this.radio_sk_hard.Ripple = true;
            this.radio_sk_hard.Size = new System.Drawing.Size(139, 30);
            this.radio_sk_hard.TabIndex = 4;
            this.radio_sk_hard.Tag = "sk_hard";
            this.radio_sk_hard.Text = "Ultra-Violence";
            this.radio_sk_hard.UseVisualStyleBackColor = true;
            this.radio_sk_hard.CheckedChanged += new System.EventHandler(this.skillChanged);
            // 
            // radio_sk_nightmare
            // 
            this.radio_sk_nightmare.AutoSize = true;
            this.radio_sk_nightmare.Depth = 0;
            this.radio_sk_nightmare.Font = new System.Drawing.Font("Roboto", 10F);
            this.radio_sk_nightmare.Location = new System.Drawing.Point(19, 174);
            this.radio_sk_nightmare.Margin = new System.Windows.Forms.Padding(0);
            this.radio_sk_nightmare.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio_sk_nightmare.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio_sk_nightmare.Name = "radio_sk_nightmare";
            this.radio_sk_nightmare.Ripple = true;
            this.radio_sk_nightmare.Size = new System.Drawing.Size(116, 30);
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
            this.radio_sk_medium.Depth = 0;
            this.radio_sk_medium.Font = new System.Drawing.Font("Roboto", 10F);
            this.radio_sk_medium.Location = new System.Drawing.Point(19, 100);
            this.radio_sk_medium.Margin = new System.Windows.Forms.Padding(0);
            this.radio_sk_medium.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio_sk_medium.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio_sk_medium.Name = "radio_sk_medium";
            this.radio_sk_medium.Ripple = true;
            this.radio_sk_medium.Size = new System.Drawing.Size(143, 30);
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
            this.radio_sk_easy.Depth = 0;
            this.radio_sk_easy.Font = new System.Drawing.Font("Roboto", 10F);
            this.radio_sk_easy.Location = new System.Drawing.Point(19, 63);
            this.radio_sk_easy.Margin = new System.Windows.Forms.Padding(0);
            this.radio_sk_easy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio_sk_easy.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio_sk_easy.Name = "radio_sk_easy";
            this.radio_sk_easy.Ripple = true;
            this.radio_sk_easy.Size = new System.Drawing.Size(171, 30);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(608, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(275, 229);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skill";
            // 
            // btnRunPrevious
            // 
            this.btnRunPrevious.AutoSize = true;
            this.btnRunPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRunPrevious.Depth = 0;
            this.btnRunPrevious.Icon = null;
            this.btnRunPrevious.Location = new System.Drawing.Point(327, 261);
            this.btnRunPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRunPrevious.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRunPrevious.Name = "btnRunPrevious";
            this.btnRunPrevious.Primary = true;
            this.btnRunPrevious.Size = new System.Drawing.Size(169, 36);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(608, 283);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(275, 363);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // chkEnableDate
            // 
            this.chkEnableDate.AutoSize = true;
            this.chkEnableDate.Depth = 0;
            this.chkEnableDate.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkEnableDate.Location = new System.Drawing.Point(19, 222);
            this.chkEnableDate.Margin = new System.Windows.Forms.Padding(0);
            this.chkEnableDate.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkEnableDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkEnableDate.Name = "chkEnableDate";
            this.chkEnableDate.Ripple = true;
            this.chkEnableDate.Size = new System.Drawing.Size(130, 30);
            this.chkEnableDate.TabIndex = 14;
            this.chkEnableDate.Text = "Created date";
            this.chkEnableDate.UseVisualStyleBackColor = true;
            this.chkEnableDate.CheckedChanged += new System.EventHandler(this.chkDisableDate_CheckedChanged);
            // 
            // createdDate
            // 
            this.createdDate.CustomFormat = "yyyy-MM-dd";
            this.createdDate.Enabled = false;
            this.createdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.createdDate.Location = new System.Drawing.Point(19, 263);
            this.createdDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createdDate.Name = "createdDate";
            this.createdDate.Size = new System.Drawing.Size(184, 30);
            this.createdDate.TabIndex = 12;
            // 
            // btnAdvancedSettings
            // 
            this.btnAdvancedSettings.AutoSize = true;
            this.btnAdvancedSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvancedSettings.Depth = 0;
            this.btnAdvancedSettings.Icon = null;
            this.btnAdvancedSettings.Location = new System.Drawing.Point(20, 306);
            this.btnAdvancedSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdvancedSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdvancedSettings.Name = "btnAdvancedSettings";
            this.btnAdvancedSettings.Primary = true;
            this.btnAdvancedSettings.Size = new System.Drawing.Size(112, 36);
            this.btnAdvancedSettings.TabIndex = 11;
            this.btnAdvancedSettings.Text = "Advanced";
            this.btnAdvancedSettings.UseVisualStyleBackColor = true;
            this.btnAdvancedSettings.Click += new System.EventHandler(this.btnAdvancedSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(23, 146);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minimum rating";
            // 
            // numMinrating
            // 
            this.numMinrating.Location = new System.Drawing.Point(27, 180);
            this.numMinrating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numMinrating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMinrating.Name = "numMinrating";
            this.numMinrating.Size = new System.Drawing.Size(85, 30);
            this.numMinrating.TabIndex = 3;
            this.numMinrating.ValueChanged += new System.EventHandler(this.numMinrating_ValueChanged);
            // 
            // chkIncludeVanilla
            // 
            this.chkIncludeVanilla.AutoSize = true;
            this.chkIncludeVanilla.Depth = 0;
            this.chkIncludeVanilla.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkIncludeVanilla.Location = new System.Drawing.Point(19, 96);
            this.chkIncludeVanilla.Margin = new System.Windows.Forms.Padding(0);
            this.chkIncludeVanilla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkIncludeVanilla.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkIncludeVanilla.Name = "chkIncludeVanilla";
            this.chkIncludeVanilla.Ripple = true;
            this.chkIncludeVanilla.Size = new System.Drawing.Size(186, 30);
            this.chkIncludeVanilla.TabIndex = 2;
            this.chkIncludeVanilla.Text = "Include vanilla wads";
            this.chkIncludeVanilla.UseVisualStyleBackColor = true;
            this.chkIncludeVanilla.CheckedChanged += new System.EventHandler(this.settingsChanged);
            // 
            // chkIncludePorts
            // 
            this.chkIncludePorts.AutoSize = true;
            this.chkIncludePorts.Depth = 0;
            this.chkIncludePorts.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkIncludePorts.Location = new System.Drawing.Point(19, 59);
            this.chkIncludePorts.Margin = new System.Windows.Forms.Padding(0);
            this.chkIncludePorts.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkIncludePorts.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkIncludePorts.Name = "chkIncludePorts";
            this.chkIncludePorts.Ripple = true;
            this.chkIncludePorts.Size = new System.Drawing.Size(168, 30);
            this.chkIncludePorts.TabIndex = 1;
            this.chkIncludePorts.Text = "Include port wads";
            this.chkIncludePorts.UseVisualStyleBackColor = true;
            this.chkIncludePorts.CheckedChanged += new System.EventHandler(this.settingsChanged);
            // 
            // chkIncludeMegawads
            // 
            this.chkIncludeMegawads.AutoSize = true;
            this.chkIncludeMegawads.Depth = 0;
            this.chkIncludeMegawads.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkIncludeMegawads.Location = new System.Drawing.Point(19, 25);
            this.chkIncludeMegawads.Margin = new System.Windows.Forms.Padding(0);
            this.chkIncludeMegawads.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkIncludeMegawads.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkIncludeMegawads.Name = "chkIncludeMegawads";
            this.chkIncludeMegawads.Ripple = true;
            this.chkIncludeMegawads.Size = new System.Drawing.Size(175, 30);
            this.chkIncludeMegawads.TabIndex = 0;
            this.chkIncludeMegawads.Text = "Include Megawads";
            this.chkIncludeMegawads.UseVisualStyleBackColor = true;
            this.chkIncludeMegawads.CheckedChanged += new System.EventHandler(this.settingsChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Depth = 0;
            this.tabControl1.Location = new System.Drawing.Point(7, 70);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 788);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
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
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(916, 759);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // lstAdditionalWads
            // 
            this.lstAdditionalWads.FormattingEnabled = true;
            this.lstAdditionalWads.ItemHeight = 16;
            this.lstAdditionalWads.Location = new System.Drawing.Point(21, 458);
            this.lstAdditionalWads.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstAdditionalWads.Name = "lstAdditionalWads";
            this.lstAdditionalWads.Size = new System.Drawing.Size(223, 148);
            this.lstAdditionalWads.TabIndex = 16;
            // 
            // btnRemoveWad
            // 
            this.btnRemoveWad.AutoSize = true;
            this.btnRemoveWad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveWad.Depth = 0;
            this.btnRemoveWad.Icon = null;
            this.btnRemoveWad.Location = new System.Drawing.Point(85, 610);
            this.btnRemoveWad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveWad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveWad.Name = "btnRemoveWad";
            this.btnRemoveWad.Primary = true;
            this.btnRemoveWad.Size = new System.Drawing.Size(90, 36);
            this.btnRemoveWad.TabIndex = 15;
            this.btnRemoveWad.Text = "Remove";
            this.btnRemoveWad.UseVisualStyleBackColor = true;
            this.btnRemoveWad.Click += new System.EventHandler(this.btnRemoveWad_Click);
            // 
            // btnAddWad
            // 
            this.btnAddWad.AutoSize = true;
            this.btnAddWad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddWad.Depth = 0;
            this.btnAddWad.Icon = null;
            this.btnAddWad.Location = new System.Drawing.Point(23, 610);
            this.btnAddWad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddWad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddWad.Name = "btnAddWad";
            this.btnAddWad.Primary = true;
            this.btnAddWad.Size = new System.Drawing.Size(56, 36);
            this.btnAddWad.TabIndex = 14;
            this.btnAddWad.Text = "Add";
            this.btnAddWad.UseVisualStyleBackColor = true;
            this.btnAddWad.Click += new System.EventHandler(this.btnAddWad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(19, 430);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Additional files";
            // 
            // grpGames
            // 
            this.grpGames.Controls.Add(this.radioDoom2);
            this.grpGames.Controls.Add(this.radioFreedoom2);
            this.grpGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGames.Location = new System.Drawing.Point(305, 37);
            this.grpGames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpGames.Name = "grpGames";
            this.grpGames.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpGames.Size = new System.Drawing.Size(232, 111);
            this.grpGames.TabIndex = 11;
            this.grpGames.TabStop = false;
            this.grpGames.Text = "Select Game";
            // 
            // radioDoom2
            // 
            this.radioDoom2.AutoSize = true;
            this.radioDoom2.Checked = true;
            this.radioDoom2.Depth = 0;
            this.radioDoom2.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioDoom2.Location = new System.Drawing.Point(15, 63);
            this.radioDoom2.Margin = new System.Windows.Forms.Padding(0);
            this.radioDoom2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioDoom2.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioDoom2.Name = "radioDoom2";
            this.radioDoom2.Ripple = true;
            this.radioDoom2.Size = new System.Drawing.Size(90, 30);
            this.radioDoom2.TabIndex = 3;
            this.radioDoom2.TabStop = true;
            this.radioDoom2.Text = "Doom 2";
            this.radioDoom2.UseVisualStyleBackColor = true;
            this.radioDoom2.CheckedChanged += new System.EventHandler(this.gameChanged);
            // 
            // radioFreedoom2
            // 
            this.radioFreedoom2.AutoSize = true;
            this.radioFreedoom2.Depth = 0;
            this.radioFreedoom2.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioFreedoom2.Location = new System.Drawing.Point(15, 26);
            this.radioFreedoom2.Margin = new System.Windows.Forms.Padding(0);
            this.radioFreedoom2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioFreedoom2.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioFreedoom2.Name = "radioFreedoom2";
            this.radioFreedoom2.Ripple = true;
            this.radioFreedoom2.Size = new System.Drawing.Size(174, 30);
            this.radioFreedoom2.TabIndex = 1;
            this.radioFreedoom2.Text = "Freedoom Phase 2";
            this.radioFreedoom2.UseVisualStyleBackColor = true;
            this.radioFreedoom2.CheckedChanged += new System.EventHandler(this.gameChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(916, 759);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRateWad);
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(711, 52);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(175, 489);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Misc";
            // 
            // btnRateWad
            // 
            this.btnRateWad.AutoSize = true;
            this.btnRateWad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRateWad.Depth = 0;
            this.btnRateWad.Icon = null;
            this.btnRateWad.Location = new System.Drawing.Point(18, 43);
            this.btnRateWad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRateWad.Name = "btnRateWad";
            this.btnRateWad.Primary = true;
            this.btnRateWad.Size = new System.Drawing.Size(106, 36);
            this.btnRateWad.TabIndex = 1;
            this.btnRateWad.Text = "Rate WAd";
            this.btnRateWad.UseVisualStyleBackColor = true;
            this.btnRateWad.Click += new System.EventHandler(this.BtnRateWad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(18, 87);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(124, 36);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete wad";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkFilterUnrated);
            this.groupBox4.Controls.Add(this.chkFilterDisliked);
            this.groupBox4.Controls.Add(this.chkFilterLiked);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(22, 52);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(177, 489);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // chkFilterUnrated
            // 
            this.chkFilterUnrated.AutoSize = true;
            this.chkFilterUnrated.Depth = 0;
            this.chkFilterUnrated.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkFilterUnrated.Location = new System.Drawing.Point(13, 87);
            this.chkFilterUnrated.Margin = new System.Windows.Forms.Padding(0);
            this.chkFilterUnrated.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFilterUnrated.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFilterUnrated.Name = "chkFilterUnrated";
            this.chkFilterUnrated.Ripple = true;
            this.chkFilterUnrated.Size = new System.Drawing.Size(92, 30);
            this.chkFilterUnrated.TabIndex = 9;
            this.chkFilterUnrated.Text = "Unrated";
            this.chkFilterUnrated.UseVisualStyleBackColor = true;
            this.chkFilterUnrated.CheckedChanged += new System.EventHandler(this.filterChanged);
            // 
            // chkFilterDisliked
            // 
            this.chkFilterDisliked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkFilterDisliked.AutoSize = true;
            this.chkFilterDisliked.Depth = 0;
            this.chkFilterDisliked.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkFilterDisliked.Location = new System.Drawing.Point(13, 56);
            this.chkFilterDisliked.Margin = new System.Windows.Forms.Padding(0);
            this.chkFilterDisliked.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFilterDisliked.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFilterDisliked.Name = "chkFilterDisliked";
            this.chkFilterDisliked.Ripple = true;
            this.chkFilterDisliked.Size = new System.Drawing.Size(92, 30);
            this.chkFilterDisliked.TabIndex = 8;
            this.chkFilterDisliked.Text = "Disliked";
            this.chkFilterDisliked.UseVisualStyleBackColor = true;
            this.chkFilterDisliked.CheckedChanged += new System.EventHandler(this.filterChanged);
            // 
            // chkFilterLiked
            // 
            this.chkFilterLiked.AutoSize = true;
            this.chkFilterLiked.Checked = true;
            this.chkFilterLiked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFilterLiked.Depth = 0;
            this.chkFilterLiked.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkFilterLiked.Location = new System.Drawing.Point(13, 25);
            this.chkFilterLiked.Margin = new System.Windows.Forms.Padding(0);
            this.chkFilterLiked.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFilterLiked.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFilterLiked.Name = "chkFilterLiked";
            this.chkFilterLiked.Ripple = true;
            this.chkFilterLiked.Size = new System.Drawing.Size(73, 30);
            this.chkFilterLiked.TabIndex = 7;
            this.chkFilterLiked.Text = "Liked";
            this.chkFilterLiked.UseVisualStyleBackColor = true;
            this.chkFilterLiked.CheckedChanged += new System.EventHandler(this.filterChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPages);
            this.groupBox3.Controls.Add(this.listPlayedWads);
            this.groupBox3.Controls.Add(this.btnPlayrandomLiked);
            this.groupBox3.Controls.Add(this.btnNextWads);
            this.groupBox3.Controls.Add(this.btnPreviousWads);
            this.groupBox3.Controls.Add(this.btnShowInfo);
            this.groupBox3.Controls.Add(this.btnPlayselected);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(205, 52);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(500, 489);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Played wads";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(205, 272);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(51, 25);
            this.lblPages.TabIndex = 7;
            this.lblPages.Text = "0/10";
            // 
            // listPlayedWads
            // 
            this.listPlayedWads.FormattingEnabled = true;
            this.listPlayedWads.ItemHeight = 25;
            this.listPlayedWads.Location = new System.Drawing.Point(7, 33);
            this.listPlayedWads.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPlayedWads.Name = "listPlayedWads";
            this.listPlayedWads.Size = new System.Drawing.Size(487, 229);
            this.listPlayedWads.TabIndex = 0;
            // 
            // btnPlayrandomLiked
            // 
            this.btnPlayrandomLiked.AutoSize = true;
            this.btnPlayrandomLiked.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlayrandomLiked.Depth = 0;
            this.btnPlayrandomLiked.Icon = null;
            this.btnPlayrandomLiked.Location = new System.Drawing.Point(175, 332);
            this.btnPlayrandomLiked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayrandomLiked.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlayrandomLiked.Name = "btnPlayrandomLiked";
            this.btnPlayrandomLiked.Primary = true;
            this.btnPlayrandomLiked.Size = new System.Drawing.Size(141, 36);
            this.btnPlayrandomLiked.TabIndex = 6;
            this.btnPlayrandomLiked.Text = "Play random";
            this.btnPlayrandomLiked.UseVisualStyleBackColor = true;
            this.btnPlayrandomLiked.Click += new System.EventHandler(this.btnPlayrandomLiked_Click);
            // 
            // btnNextWads
            // 
            this.btnNextWads.AutoSize = true;
            this.btnNextWads.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextWads.Depth = 0;
            this.btnNextWads.Icon = null;
            this.btnNextWads.Location = new System.Drawing.Point(463, 266);
            this.btnNextWads.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextWads.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextWads.Name = "btnNextWads";
            this.btnNextWads.Primary = true;
            this.btnNextWads.Size = new System.Drawing.Size(31, 36);
            this.btnNextWads.TabIndex = 5;
            this.btnNextWads.Text = ">";
            this.btnNextWads.UseVisualStyleBackColor = true;
            this.btnNextWads.Click += new System.EventHandler(this.btnNextLikedwads_Click);
            // 
            // btnPreviousWads
            // 
            this.btnPreviousWads.AutoSize = true;
            this.btnPreviousWads.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPreviousWads.Depth = 0;
            this.btnPreviousWads.Icon = null;
            this.btnPreviousWads.Location = new System.Drawing.Point(7, 266);
            this.btnPreviousWads.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreviousWads.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPreviousWads.Name = "btnPreviousWads";
            this.btnPreviousWads.Primary = true;
            this.btnPreviousWads.Size = new System.Drawing.Size(31, 36);
            this.btnPreviousWads.TabIndex = 4;
            this.btnPreviousWads.Text = "<";
            this.btnPreviousWads.UseVisualStyleBackColor = true;
            this.btnPreviousWads.Click += new System.EventHandler(this.btnPrevLikedwads_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.AutoSize = true;
            this.btnShowInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowInfo.Depth = 0;
            this.btnShowInfo.Icon = null;
            this.btnShowInfo.Location = new System.Drawing.Point(189, 423);
            this.btnShowInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Primary = true;
            this.btnShowInfo.Size = new System.Drawing.Size(114, 36);
            this.btnShowInfo.TabIndex = 3;
            this.btnShowInfo.Text = "Show info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnPlayselected
            // 
            this.btnPlayselected.AutoSize = true;
            this.btnPlayselected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlayselected.Depth = 0;
            this.btnPlayselected.Icon = null;
            this.btnPlayselected.Location = new System.Drawing.Point(147, 378);
            this.btnPlayselected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayselected.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlayselected.Name = "btnPlayselected";
            this.btnPlayselected.Primary = true;
            this.btnPlayselected.Size = new System.Drawing.Size(192, 36);
            this.btnPlayselected.TabIndex = 2;
            this.btnPlayselected.Text = "Play selected Wad";
            this.btnPlayselected.UseVisualStyleBackColor = true;
            this.btnPlayselected.Click += new System.EventHandler(this.btnPlayselected_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-3, 25);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(933, 54);
            this.materialTabSelector1.TabIndex = 12;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 766);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numMinrating;
        //private System.Windows.Forms.TabControl tabControl1;
        private MaterialTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listPlayedWads;
        private System.Windows.Forms.GroupBox grpGames;
        private System.Windows.Forms.DateTimePicker createdDate;
        private System.Windows.Forms.ListBox lstAdditionalWads;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialRaisedButton btnRunPrevious;
        private MaterialRadioButton radio_sk_baby;
        private MaterialRadioButton radio_sk_hard;
        private MaterialRadioButton radio_sk_nightmare;
        private MaterialRadioButton radio_sk_medium;
        private MaterialRadioButton radio_sk_easy;
        private MaterialRadioButton radioDoom2;
        private MaterialRadioButton radioFreedoom2;
        private MaterialCheckBox chkIncludeVanilla;
        private MaterialCheckBox chkIncludePorts;
        private MaterialCheckBox chkIncludeMegawads;
        private MaterialLabel lblStatus;
        private MaterialLabel label1;
        private MaterialLabel label2;
        private MaterialCheckBox chkEnableDate;
        private MaterialRaisedButton btnAdvancedSettings;
        private MaterialRaisedButton btnRemoveWad;
        private MaterialRaisedButton btnAddWad;
        private MaterialRaisedButton btnPlayselected;
        private MaterialRaisedButton btnShowInfo;
        private MaterialRaisedButton btnPlayrandomLiked;
        private MaterialRaisedButton btnNextWads;
        private MaterialRaisedButton btnPreviousWads;
        private MaterialCheckBox chkFilterLiked;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialRaisedButton btnDelete;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialCheckBox chkFilterUnrated;
        private MaterialCheckBox chkFilterDisliked;
        private MaterialRaisedButton btnRateWad;
        private System.Windows.Forms.Label lblPages;
    }
}

