namespace ytDLPsosing
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbOUTPUT = new System.Windows.Forms.RichTextBox();
            this.txbURL = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnKillProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnStartDownload = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.checkMusicOrVideo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rtbOUTPUT
            // 
            this.rtbOUTPUT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbOUTPUT.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbOUTPUT.Location = new System.Drawing.Point(4, 191);
            this.rtbOUTPUT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbOUTPUT.Name = "rtbOUTPUT";
            this.rtbOUTPUT.ReadOnly = true;
            this.rtbOUTPUT.Size = new System.Drawing.Size(882, 436);
            this.rtbOUTPUT.TabIndex = 0;
            this.rtbOUTPUT.Text = "";
            // 
            // txbURL
            // 
            this.txbURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbURL.Location = new System.Drawing.Point(18, 23);
            this.txbURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(686, 33);
            this.txbURL.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(481, 86);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(222, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "clear outputs";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(478, 57);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(205, 29);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "download Playlist";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // btnKillProcess
            // 
            this.btnKillProcess.Location = new System.Drawing.Point(18, 134);
            this.btnKillProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKillProcess.Name = "btnKillProcess";
            this.btnKillProcess.Size = new System.Drawing.Size(129, 35);
            this.btnKillProcess.TabIndex = 5;
            this.btnKillProcess.Text = "Kill download !";
            this.btnKillProcess.UseVisualStyleBackColor = true;
            this.btnKillProcess.Visible = false;
            this.btnKillProcess.Click += new System.EventHandler(this.btnKillProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 634);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "D. Horsky - 2025 v0.6";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(214, 85);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(256, 85);
            this.btnOpenFolder.TabIndex = 8;
            this.btnOpenFolder.Text = "Open download folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnStartDownload
            // 
            this.btnStartDownload.BackgroundImage = global::ytDLPsosing.Properties.Resources.youtube_256x256;
            this.btnStartDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartDownload.Location = new System.Drawing.Point(714, 18);
            this.btnStartDownload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartDownload.Name = "btnStartDownload";
            this.btnStartDownload.Size = new System.Drawing.Size(164, 151);
            this.btnStartDownload.TabIndex = 1;
            this.btnStartDownload.Text = "Download";
            this.btnStartDownload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStartDownload.UseVisualStyleBackColor = true;
            this.btnStartDownload.Click += new System.EventHandler(this.btnStartDownload_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(481, 134);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(222, 35);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "update kernel";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // checkMusicOrVideo
            // 
            this.checkMusicOrVideo.AutoSize = true;
            this.checkMusicOrVideo.Checked = true;
            this.checkMusicOrVideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMusicOrVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkMusicOrVideo.Location = new System.Drawing.Point(18, 105);
            this.checkMusicOrVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkMusicOrVideo.Name = "checkMusicOrVideo";
            this.checkMusicOrVideo.Size = new System.Drawing.Size(170, 29);
            this.checkMusicOrVideo.TabIndex = 10;
            this.checkMusicOrVideo.Text = "Video / Music";
            this.checkMusicOrVideo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 660);
            this.Controls.Add(this.checkMusicOrVideo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKillProcess);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txbURL);
            this.Controls.Add(this.btnStartDownload);
            this.Controls.Add(this.rtbOUTPUT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ytDLP sosing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOUTPUT;
        private System.Windows.Forms.Button btnStartDownload;
        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnKillProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox checkMusicOrVideo;
    }
}

