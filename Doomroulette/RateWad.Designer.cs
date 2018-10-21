namespace Doomroulette
{
    partial class RateWad
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
            this.btnLike = new System.Windows.Forms.Button();
            this.btnDislike = new System.Windows.Forms.Button();
            this.lblWadInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLike
            // 
            this.btnLike.BackColor = System.Drawing.Color.Lime;
            this.btnLike.BackgroundImage = global::Doomroulette.Properties.Resources.ic_thumb_up_3x;
            this.btnLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLike.Location = new System.Drawing.Point(75, 115);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(130, 130);
            this.btnLike.TabIndex = 2;
            this.btnLike.UseVisualStyleBackColor = false;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnDislike
            // 
            this.btnDislike.BackColor = System.Drawing.Color.Red;
            this.btnDislike.BackgroundImage = global::Doomroulette.Properties.Resources.ic_thumb_down_3x;
            this.btnDislike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDislike.Location = new System.Drawing.Point(277, 115);
            this.btnDislike.Name = "btnDislike";
            this.btnDislike.Size = new System.Drawing.Size(130, 130);
            this.btnDislike.TabIndex = 1;
            this.btnDislike.UseVisualStyleBackColor = false;
            this.btnDislike.Click += new System.EventHandler(this.btnDislike_Click);
            // 
            // lblWadInfo
            // 
            this.lblWadInfo.Location = new System.Drawing.Point(73, 9);
            this.lblWadInfo.Name = "lblWadInfo";
            this.lblWadInfo.Size = new System.Drawing.Size(334, 103);
            this.lblWadInfo.TabIndex = 3;
            this.lblWadInfo.Text = "Do you like the Wad?";
            // 
            // RateWad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 306);
            this.Controls.Add(this.lblWadInfo);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.btnDislike);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RateWad";
            this.Text = "RateWad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDislike;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Label lblWadInfo;
    }
}