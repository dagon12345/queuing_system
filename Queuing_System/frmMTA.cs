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
    public partial class frmMTA : Form
    {
        public frmMTA()
        {
            InitializeComponent();
        }

        private void frmMTA_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Hide();
            //frmSelectSection fs = new frmSelectSection();
            //fs.Show();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            frmGeneratingMTA fgm = new frmGeneratingMTA();
            fgm.Show();
        }

        private void btn_qt_Click(object sender, EventArgs e)
        {
            frmMTAqueuing fm = new frmMTAqueuing();
            fm.Show();
        }
    }
}
