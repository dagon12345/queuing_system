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
    public partial class frmSelectSection : Form
    {

        BackgroundWorker _bgWorker;
        bool _iNeedToCloseAfterBgWorker;

        public frmSelectSection()
        {
            InitializeComponent();
        }

        private void frmSelectSection_Load(object sender, EventArgs e)
        {
            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += _bgWorker_DoWork;
            _bgWorker.RunWorkerCompleted += _bgWorker_RunWorkerCompleted;

            _bgWorker.RunWorkerAsync();

        }


        void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ////completed here
            btn_proceed.Enabled = true;
            if (_iNeedToCloseAfterBgWorker)
                Close();
        }

        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            lbl_internet.Invoke((MethodInvoker)delegate
            {
                // Access lbl_internet here
                lbl_internet.Text = "Detecting internet...";
            });

            btn_proceed.Invoke((MethodInvoker)delegate
            {
                // Access lbl_internet here
                btn_proceed.Enabled = false;
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

                    if (!webClient.DownloadString("https://www.dropbox.com/s/62hfq7ylzn480sv/Update.txt?dl=1").Contains("3.5.8"))
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



                                if (File.Exists(@".\QueueInstaller.msi")) { File.Delete(@".\QueueInstaller.msi"); }
                                client.DownloadFile("https://www.dropbox.com/s/pa8ydxmxgud2926/QueueInstaller.zip?dl=1", @"QueueInstaller.zip");
                                string zipPath = @".\QueueInstaller.zip";
                                string extractPath = @".\";
                                ZipFile.ExtractToDirectory(zipPath, extractPath);


                                lbl_internet.Invoke((MethodInvoker)delegate
                                {
                                    // Access lbl_internet here
                                    lbl_internet.Text = "Installing update, please wait....";
                                });



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

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            if(cmb_section.Text == "")
            {
                MessageBox.Show("Please select section before proceeding","Select",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(cmb_section.Text == "CIS")
                {
                    this.Hide();
                    frmOption fo = new frmOption();
                    fo.Show();
                }
                else if(cmb_section.Text == "MTA")
                {
                    this.Hide();
                    frmMTA fm = new frmMTA();
                    fm.Show();
                }
            }

        }

        private void frmSelectSection_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
