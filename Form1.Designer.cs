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
            this.chckBox1Playlist = new System.Windows.Forms.CheckBox();
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
            this.txbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbURL.Location = new System.Drawing.Point(18, 14);
            this.txbURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(860, 30);
            this.txbURL.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(510, 75);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(222, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "clear outputs";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chckBox1Playlist
            // 
            this.chckBox1Playlist.AutoSize = true;
            this.chckBox1Playlist.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chckBox1Playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chckBox1Playlist.Location = new System.Drawing.Point(18, 71);
            this.chckBox1Playlist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chckBox1Playlist.Name = "chckBox1Playlist";
            this.chckBox1Playlist.Size = new System.Drawing.Size(148, 29);
            this.chckBox1Playlist.TabIndex = 4;
            this.chckBox1Playlist.Text = "Full Playlist";
            this.chckBox1Playlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckBox1Playlist.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chckBox1Playlist.UseVisualStyleBackColor = true;
            // 
            // btnKillProcess
            // 
            this.btnKillProcess.Location = new System.Drawing.Point(66, 109);
            this.btnKillProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKillProcess.Name = "btnKillProcess";
            this.btnKillProcess.Size = new System.Drawing.Size(182, 35);
            this.btnKillProcess.TabIndex = 5;
            this.btnKillProcess.Text = "Kill Process download !";
            this.btnKillProcess.UseVisualStyleBackColor = true;
            this.btnKillProcess.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 634);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Davhoos - 2025 v0.8";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(275, 75);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(219, 91);
            this.btnOpenFolder.TabIndex = 8;
            this.btnOpenFolder.Text = "Open download folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnStartDownload
            // 
            this.btnStartDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnStartDownload.Image")));
            this.btnStartDownload.Location = new System.Drawing.Point(745, 54);
            this.btnStartDownload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartDownload.Name = "btnStartDownload";
            this.btnStartDownload.Size = new System.Drawing.Size(133, 127);
            this.btnStartDownload.TabIndex = 1;
            this.btnStartDownload.Text = "Download";
            this.btnStartDownload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStartDownload.UseVisualStyleBackColor = true;
            this.btnStartDownload.Click += new System.EventHandler(this.btnStartDownload_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(510, 131);
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
            this.checkMusicOrVideo.Location = new System.Drawing.Point(18, 148);
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
            this.Controls.Add(this.chckBox1Playlist);
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
        private System.Windows.Forms.CheckBox chckBox1Playlist;
        private System.Windows.Forms.Button btnKillProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox checkMusicOrVideo;
    }
}

