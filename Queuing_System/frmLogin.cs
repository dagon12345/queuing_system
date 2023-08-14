using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queuing_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_status.Text == "Verifier login.")
            {
                if (txt_username.Text == "verifier" && txt_password.Text == "dswd123$")
                {
                    this.Hide();
                    frmRecieving fr = new frmRecieving();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login details.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(txt_status.Text == "Generating login.")
            {
                if (txt_username.Text == "generator" && txt_password.Text == "dswd123$")
                {
                    this.Hide();
                    frm_GenerateNumbers fg = new frm_GenerateNumbers();
                    fg.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login details.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
