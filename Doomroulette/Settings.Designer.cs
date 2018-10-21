namespace Doomroulette
{
    partial class Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseDoom = new System.Windows.Forms.Button();
            this.txtDoompath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowsedownloaded = new System.Windows.Forms.Button();
            this.txtdownloadedWadsFolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnDoom2 = new System.Windows.Forms.Button();
            this.txtDoom2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFreedoom2 = new System.Windows.Forms.Button();
            this.txtFreedoom2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseDoom);
            this.groupBox1.Controls.Add(this.txtDoompath);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Executable path";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBrowseDoom
            // 
            this.btnBrowseDoom.Location = new System.Drawing.Point(245, 21);
            this.btnBrowseDoom.Name = "btnBrowseDoom";
            this.btnBrowseDoom.Size = new System.Drawing.Size(85, 30);
            this.btnBrowseDoom.TabIndex = 1;
            this.btnBrowseDoom.Text = "Browse";
            this.btnBrowseDoom.UseVisualStyleBackColor = true;
            this.btnBrowseDoom.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDoompath
            // 
            this.txtDoompath.Location = new System.Drawing.Point(6, 28);
            this.txtDoompath.Name = "txtDoompath";
            this.txtDoompath.Size = new System.Drawing.Size(233, 22);
            this.txtDoompath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowsedownloaded);
            this.groupBox2.Controls.Add(this.txtdownloadedWadsFolder);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Downloaded files location";
            // 
            // btnBrowsedownloaded
            // 
            this.btnBrowsedownloaded.Location = new System.Drawing.Point(245, 26);
            this.btnBrowsedownloaded.Name = "btnBrowsedownloaded";
            this.btnBrowsedownloaded.Size = new System.Drawing.Size(85, 30);
            this.btnBrowsedownloaded.TabIndex = 1;
            this.btnBrowsedownloaded.Text = "Browse";
            this.btnBrowsedownloaded.UseVisualStyleBackColor = true;
            this.btnBrowsedownloaded.Click += new System.EventHandler(this.btnBrowsedownloaded_Click);
            // 
            // txtdownloadedWadsFolder
            // 
            this.txtdownloadedWadsFolder.Location = new System.Drawing.Point(6, 30);
            this.txtdownloadedWadsFolder.Name = "txtdownloadedWadsFolder";
            this.txtdownloadedWadsFolder.Size = new System.Drawing.Size(233, 22);
            this.txtdownloadedWadsFolder.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(14, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 176);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Iwad files";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnDoom2);
            this.groupBox7.Controls.Add(this.txtDoom2);
            this.groupBox7.Location = new System.Drawing.Point(7, 98);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(328, 59);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Doom2";
            // 
            // btnDoom2
            // 
            this.btnDoom2.Location = new System.Drawing.Point(237, 16);
            this.btnDoom2.Name = "btnDoom2";
            this.btnDoom2.Size = new System.Drawing.Size(85, 30);
            this.btnDoom2.TabIndex = 1;
            this.btnDoom2.Text = "Browse";
            this.btnDoom2.UseVisualStyleBackColor = true;
            this.btnDoom2.Click += new System.EventHandler(this.btnBrowseIwad_Click);
            // 
            // txtDoom2
            // 
            this.txtDoom2.Location = new System.Drawing.Point(7, 22);
            this.txtDoom2.Name = "txtDoom2";
            this.txtDoom2.Size = new System.Drawing.Size(223, 22);
            this.txtDoom2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFreedoom2);
            this.groupBox5.Controls.Add(this.txtFreedoom2);
            this.groupBox5.Location = new System.Drawing.Point(7, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(328, 59);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "FreeDoom Phase2";
            // 
            // btnFreedoom2
            // 
            this.btnFreedoom2.Location = new System.Drawing.Point(237, 18);
            this.btnFreedoom2.Name = "btnFreedoom2";
            this.btnFreedoom2.Size = new System.Drawing.Size(85, 30);
            this.btnFreedoom2.TabIndex = 1;
            this.btnFreedoom2.Text = "Browse";
            this.btnFreedoom2.UseVisualStyleBackColor = true;
            this.btnFreedoom2.Click += new System.EventHandler(this.btnBrowseIwad_Click);
            // 
            // txtFreedoom2
            // 
            this.txtFreedoom2.Location = new System.Drawing.Point(7, 22);
            this.txtFreedoom2.Name = "txtFreedoom2";
            this.txtFreedoom2.Size = new System.Drawing.Size(223, 22);
            this.txtFreedoom2.TabIndex = 0;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 432);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowseDoom;
        private System.Windows.Forms.TextBox txtDoompath;
        private System.Windows.Forms.Button btnBrowsedownloaded;
        private System.Windows.Forms.TextBox txtdownloadedWadsFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnDoom2;
        private System.Windows.Forms.TextBox txtDoom2;
        private System.Windows.Forms.Button btnFreedoom2;
        private System.Windows.Forms.TextBox txtFreedoom2;
    }
}