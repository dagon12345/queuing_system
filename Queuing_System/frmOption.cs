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

namespace Queuing_System
{
    public partial class frmOption : Form
    {
        public frmOption()
        {
            InitializeComponent();


            WebClient webClient = new WebClient();
            var client = new WebClient();

            if (!webClient.DownloadString("https://www.dropbox.com/s/zxhd0d4gvs5ps10/Update.txt?dl=1").Contains("1.1.0"))
            {
                if (MessageBox.Show("New update available! Do you want to install it?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (File.Exists(@".\QueueInstaller.msi")) { File.Delete(@".\QueueInstaller.msi"); }
                        client.DownloadFile("https://www.dropbox.com/s/2dttg40fssf6iqo/QueueInstaller.zip?dl=1", @"QueueInstaller.zip");
                        string zipPath = @".\QueueInstaller.zip";
                        string extractPath = @".\";
                        ZipFile.ExtractToDirectory(zipPath, extractPath);

                        Process process = new Process();
                        process.StartInfo.FileName = "msiexec";
                        process.StartInfo.Arguments = String.Format("/i QueueInstaller.msi");

                        this.Close();
                        process.Start();
                    }
                    catch
                    {

                    }
                }
            }







            try
            {
                using (var client1 = new WebClient())
                using (var stream = client1.OpenRead("http://www.google.com"))
                {

                    lbl_internet.Text = "Online";

                }

            }
            catch
            {
                lbl_internet.Text = "Local Network";
            }
            



        }

        private void btn_rc_Click(object sender, EventArgs e)
        {
            Main_menu mm = new Main_menu();
            mm.Show();

        }

        private void btn_qt_Click(object sender, EventArgs e)
        {
            frm_Queuing fq = new frm_Queuing();
            fq.Show();
        }

        private void Option_Load(object sender, EventArgs e)
        {

            

        }
    }
}
