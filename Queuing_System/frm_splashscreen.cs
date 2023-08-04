using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queuing_System
{
    public partial class frm_splashscreen : Form
    {
        BackgroundWorker _bgWorker;
        bool _iNeedToCloseAfterBgWorker;

        public frm_splashscreen()
        {
            InitializeComponent();
        }


        private void _bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update the progress bar value
            progressBar1.Value = e.ProgressPercentage;
        }

        private void frm_splashscreen_Load(object sender, EventArgs e)
        {
            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += _bgWorker_DoWork;
            _bgWorker.RunWorkerCompleted += _bgWorker_RunWorkerCompleted;
            _bgWorker.WorkerReportsProgress = true;
            _bgWorker.ProgressChanged += _bgWorker_ProgressChanged;




            _bgWorker.RunWorkerAsync();
        }

        void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ////completed here
            this.Hide();
            frmSelectSection fs = new frmSelectSection();
            fs.Show();


            if (_iNeedToCloseAfterBgWorker)
                Close();

        }

        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {

      

    
            // Do long lasting work above is the before process before final
            //Thread.Sleep(1000);


            // Simulate a time-consuming task
            for (int i = 0; i <= 100; i++)
            {
                // Perform your task here

                lbl_internet.Invoke((MethodInvoker)delegate
                {
                    // Access lbl_internet here
                    lbl_internet.Text = "Loading Please wait...";
                });

                Thread.Sleep(140);


                // Report progress to the UI thread
                _bgWorker.ReportProgress(i);


            }

            try
            {
                using (var client1 = new WebClient())
                using (var stream = client1.OpenRead("http://www.google.com"))
                {

                    ////////////CHECK UPDATES
                    lbl_internet.Invoke((MethodInvoker)delegate
                    {
                        // Access lbl_internet here
                        lbl_internet.Text = "Checking for updates...";
                    });

                    WebClient webClient = new WebClient();
                    var client = new WebClient();

                    if (!webClient.DownloadString("https://www.dropbox.com/s/62hfq7ylzn480sv/Update.txt?dl=1").Contains("3.6.5"))
                    {
                        lbl_internet.Invoke((MethodInvoker)delegate
                        {
                            // Access lbl_internet here
                            lbl_internet.Text = "Update available!";
                        });

                        if (MessageBox.Show("New update available! Do you want to install it?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                lbl_internet.Invoke((MethodInvoker)delegate
                                {
                                    // Access lbl_internet here
                                    lbl_internet.Text = "Installing update, please wait....";
                                });


                                if (File.Exists(@".\QueueInstaller.msi")) { File.Delete(@".\QueueInstaller.msi"); }
                                client.DownloadFile("https://www.dropbox.com/s/pa8ydxmxgud2926/QueueInstaller.zip?dl=1", @"QueueInstaller.zip");
                                string zipPath = @".\QueueInstaller.zip";
                                string extractPath = @".\";
                                ZipFile.ExtractToDirectory(zipPath, extractPath);


                          



                                Process process = new Process();
                                process.StartInfo.FileName = "msiexec";
                                process.StartInfo.Arguments = String.Format("/i QueueInstaller.msi");



                                process.Start();

                                Application.Exit();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        //else
                        //{
                        //    this.Hide();
                        //    frmSelectSection fs = new frmSelectSection();
                        //    fs.Show();
                        //}

                    }





                    //lbl_internet.Invoke((MethodInvoker)delegate
                    //{
                    //    // Access lbl_internet here
                    //    lbl_internet.Text = "Online";
                    //});


                }

            }
            catch
            {


                lbl_internet.Invoke((MethodInvoker)delegate
                {
                    // Access lbl_internet here
                    lbl_internet.Text = "Local Network";
                });





            }





        }

    }
}
