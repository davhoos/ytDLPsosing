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


            // Optional: Set label if not already set in the designer
            checkMusicOrVideo.Text = "Video or Music";

        }
        #endregion


        // Create a new folder for downloads
        string myVideosPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "ytdlp_videos") + Path.DirectorySeparatorChar;



        // Check if Music or Video should be downloaded
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

                // Build correct format options
                formatOption = "-f \"bestvideo[ext=mp4][height<=1440]+bestaudio[ext=m4a]/best[ext=mp4]\"";
                string outputTemplate = Path.Combine(myVideosPath, "%(title)s.%(ext)s");

                // Full yt-dlp arguments
                string arguments = $"{formatOption} --merge-output-format mp4 --remux-video mp4 --no-keep-video -o \"{outputTemplate}\" \"{txbURL.Text}\"";

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

                AppendOutput($" Video Download started... Files saved in folder: {myVideosPath}\n");
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

                cmd = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "yt-dlp.exe",
                        Arguments = $"{txbURL.Text} {formatOption} -o \"{outputTemplate}\"",                                                                                                                       //Arguments = $"{txbURL.Text} {playlistOption} {formatOption} -o \"{outputPath}\"", //for mp3 
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
                cmd.Exited += Cmd_ProcessExited; // Handle process completion

                cmd.Start();
                cmd.BeginOutputReadLine();
                cmd.BeginErrorReadLine();

                AppendOutput($"Music Download started... Files saved in folder: {myVideosPath}\n");

            }

            catch (Exception ex) 
            {
                MessageBox.Show($"error during process...: {ex.Message}");        
            }

        }

#endregion


        #region Output and Completion Handling
        private void Cmd_OutputDataReceiver(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                this.Invoke((MethodInvoker)delegate
                {
                    AppendOutput(e.Data + Environment.NewLine);
                });
            }
        }

        private void Cmd_ProcessExited(object sender, EventArgs e)
        {
           
            {
                AppendOutput("=====> Download Complete <=====\n");


            };
        }

        private void AppendOutput(string text)
        {
            rtbOUTPUT.AppendText(text);
            rtbOUTPUT.SelectionStart = rtbOUTPUT.Text.Length;
            rtbOUTPUT.ScrollToCaret();
        }
        #endregion

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


        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbOUTPUT.Clear();
            txbURL.Clear();
        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmd != null && !cmd.HasExited)
                {
                    cmd.Kill();
                    cmd.Dispose();
                    MessageBox.Show("Download process terminated.");
                }
                else
                {
                    MessageBox.Show("No active process to terminate...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while terminating the process: {ex.Message}");
            }
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

            try {
            //string commandosUpdatos = "yt-dlp --update-to master";
            string commandosUpdatos = " --update-to master";

            cmd = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "yt-dlp.exe",
                    Arguments = commandosUpdatos,
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
            cmd.Exited += Cmd_ProcessExited; // Handle process completion

            cmd.Start();
            cmd.BeginOutputReadLine();
            cmd.BeginErrorReadLine();

                //

                AppendOutput($"... UPDATE KERNEL IN PROGRESS ...\n");



            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        //

}



        #endregion

   
    }
}
