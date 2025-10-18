using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ytDLPsosing
{
    public partial class Form1 : Form
    {
        private Process cmd;

        public Form1()
        {
            InitializeComponent();
        }

        #region FORM LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("yt-dlp.exe"))
            {
                MessageBox.Show("Integrity check failed - missing yt-dlp.exe!");
            }


            
            checkMusicOrVideo.Text = "Video or Music";

        }
        #endregion


        
        string myVideosPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "ytdlp_videos") + Path.DirectorySeparatorChar;



      
        string formatOption;




        #region StartDownloadVideo
        private void StartDownloadVideo()
        {
            try
            {
                if (!Directory.Exists(myVideosPath))
                {
                    Directory.CreateDirectory(myVideosPath);
                }

                formatOption = "-f \"bestvideo[ext=mp4][height<=1440]+bestaudio[ext=m4a]/best[ext=mp4]\"";
                string outputTemplate = Path.Combine(myVideosPath, "%(title)s.%(ext)s");

         
                string playlistOption = chckBox1Playlist.Checked ? "" : "--no-playlist";

                string arguments = $"{playlistOption} {formatOption} --merge-output-format mp4 --remux-video mp4 --no-keep-video -o \"{outputTemplate}\" \"{txbURL.Text}\"";

                cmd = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "yt-dlp.exe",
                        Arguments = arguments,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        UseShellExecute = false
                    },
                    EnableRaisingEvents = true
                };

                cmd.OutputDataReceived += Cmd_OutputDataReceiver;
                cmd.ErrorDataReceived += Cmd_OutputDataReceiver;
                cmd.Exited += Cmd_ProcessExited;

                cmd.Start();
                cmd.BeginOutputReadLine();
                cmd.BeginErrorReadLine();

                AppendOutput($"Video Download started... (Playlist: {(chckBox1Playlist.Checked ? "Enabled" : "Disabled")}) Files saved in: {myVideosPath}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        //

        private void StartDownloadMusic()
        {
            try
            {
                formatOption = "-f bestaudio --extract-audio --audio-format mp3";
                string outputTemplate = Path.Combine(myVideosPath, "%(title)s.%(ext)s");

      
                string playlistOption = chckBox1Playlist.Checked ? "" : "--no-playlist";

                string arguments = $"{playlistOption} {formatOption} -o \"{outputTemplate}\" \"{txbURL.Text}\"";

                cmd = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "yt-dlp.exe",
                        Arguments = arguments,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        UseShellExecute = false
                    }
                };

                cmd.OutputDataReceived += Cmd_OutputDataReceiver;
                cmd.ErrorDataReceived += Cmd_OutputDataReceiver;

                cmd.EnableRaisingEvents = true;
                cmd.Exited += Cmd_ProcessExited;

                cmd.Start();
                cmd.BeginOutputReadLine();
                cmd.BeginErrorReadLine();

                AppendOutput($"Music Download started... (Playlist: {(chckBox1Playlist.Checked ? "Enabled" : "Disabled")}) Files saved in: {myVideosPath}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during process: {ex.Message}");
            }
        }


        #endregion


        #region Output and Data Receiver Download
        private void Cmd_OutputDataReceiver(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
                AppendOutput(e.Data + Environment.NewLine);
        }

        #endregion



        private void Cmd_ProcessExited(object sender, EventArgs e)
        {
           
            {
                AppendOutput("=====> Download Complete <=====\n");


            };
        }

        // correction for outputing

        private void AppendOutput(string text)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(AppendOutput), text);
                return;
            }

            rtbOUTPUT.AppendText(text);
            rtbOUTPUT.SelectionStart = rtbOUTPUT.Text.Length;
            rtbOUTPUT.ScrollToCaret();
        }


        #region Button Events Terminating
        private void btnStartDownload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbURL.Text))
            {
                MessageBox.Show("Please insert a valid YouTube URL...");
                return;
            }

            else if (checkMusicOrVideo.Checked == true)
            {
                // Video mode
                StartDownloadVideo();
            }
            else if (checkMusicOrVideo.Checked == false) 
            {
                // Music mode
                StartDownloadMusic();
            }
        }
        #endregion


        #region "Clearing field click"

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbOUTPUT.Clear();
            txbURL.Clear();
        }

        #endregion



        #region OpenDownloadFolder
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            string myVideosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            string outputFolder = Path.Combine(myVideosPath, "ytdlp_videos");

            if (!Directory.Exists(outputFolder))
            {
                MessageBox.Show("Download folder doesn't exist!");
            }
            else
            {
                Process.Start("explorer.exe", outputFolder);
            }
        }
        #endregion
        #region UpdateKernel
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (!File.Exists("yt-dlp.exe"))
                {
                    MessageBox.Show("yt-dlp.exe not found in the application directory.");
                    return;
                }

                // Correct yt-dlp update command
                string arguments = "-U";

                cmd = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "yt-dlp.exe",
                        Arguments = arguments,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        UseShellExecute = false
                    },
                    EnableRaisingEvents = true
                };

                cmd.OutputDataReceived += Cmd_OutputDataReceiver;
                cmd.ErrorDataReceived += Cmd_OutputDataReceiver;
                cmd.Exited += Cmd_ProcessExited;

                cmd.Start();
                cmd.BeginOutputReadLine();
                cmd.BeginErrorReadLine();

                AppendOutput("--> UPDATE PROCESS STARTED...\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update failed: {ex.Message}");
            }

           

        }



        #endregion

   
    }
}
