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
            this.lblWadInfo = new MaterialSkin.Controls.MaterialLabel();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnDislike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWadInfo
            // 
            this.lblWadInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblWadInfo.Depth = 0;
            this.lblWadInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblWadInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWadInfo.Location = new System.Drawing.Point(15, 86);
            this.lblWadInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWadInfo.Name = "lblWadInfo";
            this.lblWadInfo.Size = new System.Drawing.Size(467, 89);
            this.lblWadInfo.TabIndex = 3;
            this.lblWadInfo.Text = "You have played: Placeholder.wad\nMade by Placeholder.\nCreated yyyy-mm-dd";
            // 
            // btnLike
            // 
            this.btnLike.BackColor = System.Drawing.Color.Lime;
            this.btnLike.BackgroundImage = global::Doomroulette.Properties.Resources.ic_thumb_up_3x;
            this.btnLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLike.Location = new System.Drawing.Point(20, 188);
            this.btnLike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(131, 130);
            this.btnLike.TabIndex = 2;
            this.btnLike.UseVisualStyleBackColor = false;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnDislike
            // 
            this.btnDislike.BackColor = System.Drawing.Color.Red;
            this.btnDislike.BackgroundImage = global::Doomroulette.Properties.Resources.ic_thumb_down_3x;
            this.btnDislike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDislike.Location = new System.Drawing.Point(351, 188);
            this.btnDislike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDislike.Name = "btnDislike";
            this.btnDislike.Size = new System.Drawing.Size(131, 130);
            this.btnDislike.TabIndex = 1;
            this.btnDislike.UseVisualStyleBackColor = false;
            this.btnDislike.Click += new System.EventHandler(this.btnDislike_Click);
            // 
            // RateWad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(511, 354);
            this.Controls.Add(this.lblWadInfo);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.btnDislike);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RateWad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Do you like this Wad?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDislike;
        private System.Windows.Forms.Button btnLike;
        private MaterialSkin.Controls.MaterialLabel lblWadInfo;
    }
}