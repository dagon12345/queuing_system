using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;

namespace Queuing_System
{
    public partial class frmOption : Form
    {



        public frmOption()
        {
            InitializeComponent();



        }


        void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ////completed here
            //btn_qt.Enabled = true;
            //btn_rc.Enabled = true;
            //btn_generate.Enabled = true;
            //if (_iNeedToCloseAfterBgWorker)
            //    Close();
        }

        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            /*

            lbl_internet.Invoke((MethodInvoker)delegate
            {
                // Access lbl_internet here
                lbl_internet.Text = "Detecting";
            });

            btn_generate.Invoke((MethodInvoker)delegate
            {
                // Access lbl_internet here
                btn_generate.Enabled = false;
            });

            btn_rc.Invoke((MethodInvoker)delegate
            {
                // Access lbl_internet here
                btn_rc.Enabled = false;
            });

            btn_qt.Invoke((MethodInvoker)delegate
            {
                // Access lbl_internet here
                btn_qt.Enabled = false;
            });

            // Do long lasting work above is the before process before final
            Thread.Sleep(1000);



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

                    if (!webClient.DownloadString("https://www.dropbox.com/s/62hfq7ylzn480sv/Update.txt?dl=1").Contains("3.5.4"))
                    {
                        lbl_internet.Invoke((MethodInvoker)delegate
                        {
                            // Access lbl_internet here
                            lbl_internet.Text = "Update available!...";
                        });

                        if (MessageBox.Show("New update available! Do you want to install it?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
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

                    }





                    lbl_internet.Invoke((MethodInvoker)delegate
                    {
                        // Access lbl_internet here
                        lbl_internet.Text = "Online";
                    });


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
            */



        }


        private void btn_rc_Click(object sender, EventArgs e)
        {

            frmLogin fl = new frmLogin();
            fl.txt_status.Text = "Verifier login.";
            fl.Show();


            //Main_menu mm = new Main_menu();
            //mm.Show();

        }

        private void btn_qt_Click(object sender, EventArgs e)
        {
            frm_Queuing fq = new frm_Queuing();
            fq.Show();
        }

        private void Option_Load(object sender, EventArgs e)
        {

            //_bgWorker = new BackgroundWorker();
            //_bgWorker.DoWork += _bgWorker_DoWork;
            //_bgWorker.RunWorkerCompleted += _bgWorker_RunWorkerCompleted;

            //_bgWorker.RunWorkerAsync();



        }
     

        private void btn_update_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amen");
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.txt_status.Text = "Generating login.";
            fl.Show();
         
            //frm_GenerateNumbers fg = new frm_GenerateNumbers();
            //fg.Show();
        }

        private void frmOption_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Hide();
           // frmSelectSection fs = new frmSelectSection();
           // fs.Show();
        }
    }
}

