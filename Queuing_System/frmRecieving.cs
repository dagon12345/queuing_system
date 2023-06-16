using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Queuing_System
{
    public partial class Main_menu : Form
    {
        ConnectionString cs = new ConnectionString();
        MySqlConnection con = null;

        int j;

        public void get_value(int i)
        {

            j = i;
        }

        BackgroundWorker _bgWorker;
        bool _iNeedToCloseAfterBgWorker;


        public Main_menu()
        {
            InitializeComponent();
            datetimer.Start();
            //display();
        }

        private void datetimer_Tick(object sender, EventArgs e)
        {
            datetodaylbl.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            display();

            post();
        }

        
        /// <summary>
        /// //PRINTING FUNCTION
        /// </summary>
        public void print()
        {
            get_value(Convert.ToInt32(number.ToString()));
            RecieptDS ds = new RecieptDS();

 
            MySqlCommand cmd6 = con.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            cmd6.CommandText = "select * from number_db where id=" + j+ "";
            cmd6.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd6);
            da3.Fill(ds.DataTable1);
            da3.Fill(dt3);

            NumberCrystal myreport = new NumberCrystal();
            myreport.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = myreport;
            myreport.PrintToPrinter(1, false, 0, 0);


        }

        string number = "";
        private void btn_add_Click(object sender, EventArgs e)
        {
            
                int i = 0;
                txt_number.Text = Convert.ToString(Convert.ToInt32(txt_number.Text) + 1);


                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * FROM number_db where Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Number ='" + txt_number.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {


                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into number_db (Date,Number)values ('" + DateTime.Now.ToString("MMMM dd, yyyy") + "','" + txt_number.Text + "')";
                    cmd1.ExecuteNonQuery();



               /////////FOR PRINTING
                           MySqlCommand cmd3 = con.CreateCommand();
                           cmd3.CommandType = CommandType.Text;
                           cmd3.CommandText = "select * FROM number_db ORDER BY id ASC";
                           cmd3.ExecuteNonQuery();
                           DataTable dt2 = new DataTable();
                           MySqlDataAdapter da2 = new MySqlDataAdapter(cmd3);
                           da2.Fill(dt2);
                           foreach (DataRow dr2 in dt2.Rows)
                           {
                               number = dr2["id"].ToString();

                           }





                display();

                _bgWorker.RunWorkerAsync();

                btn_add.Enabled = false;
                lblstatus.Text = "Printing.....";

            }
                else
                {
                    MessageBox.Show("This Number already existed for today.");
                }
            
        }
        public void display()
        {

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from number_db WHERE Date = '"+ DateTime.Now.ToString("MMMM dd, yyyy") + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            dataGridView1.DataSource = dt;
            da.Fill(dt);
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["TableNo"].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



          
        }


        public void post()
        {

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from number_db";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_number.Text = dr["Number"].ToString();

            }
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(cs.DBcon);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();


                }
                con.Open();


                post();


                if (dataGridView1.Rows.Count == 0)
                {
                    txt_number.Text = "0";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();   
            }

            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += _bgWorker_DoWork;
            _bgWorker.RunWorkerCompleted += _bgWorker_RunWorkerCompleted;
        }

        void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblstatus.Text = "Ready to release";
            btn_add.Enabled = true;
            if (_iNeedToCloseAfterBgWorker)
            Close();
        }

        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do long lasting work
            Thread.Sleep(1000);
            //print();
        }

        /*
        void btnWorkIt_Click(object sender, EventArgs e)
        {
            // Note how the Form remains accessible
            _bgWorker.RunWorkerAsync();
        }


        */


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There is nothing to delete here.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            //DELETE USERS FROM DATABASE.
            else if (MessageBox.Show("Are you sure you want to delete this data?...", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


             
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete from number_db WHERE Date='" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Table resetted");
                    txt_number.Text = "0";
                    display();
                
                
            }
          
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There is nothing to delete here.");
            }
            else if (MessageBox.Show("Are you sure you want to rollback data?...", "Rollback", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


               
             
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete from number_db WHERE Number='" + txt_number.Text + "' ";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data rollback by 1");
                // txt_number.Text = "0";

                if (dataGridView1.Rows.Count == 0)
                {
                    txt_number.Text = "0";
                }


                display();

               // if (!backgroundWorker1.IsBusy)
                 //   backgroundWorker1.CancelAsync();
            }
        }

        private void checkmanual_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private int BackgroundProcessLogicMethod(BackgroundWorker bw, int a)
        {
            int result = 0;
            Thread.Sleep(20000);
            MessageBox.Show("I was doing some work in the background.");
            return result;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker helperBW = sender as BackgroundWorker;
            int arg = (int)e.Argument;
            e.Result = BackgroundProcessLogicMethod(helperBW, arg);
            if (helperBW.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) MessageBox.Show("Operation was canceled");
            else if (e.Error != null) MessageBox.Show(e.Error.Message);
            else MessageBox.Show(e.Result.ToString());
        }
    }
}
