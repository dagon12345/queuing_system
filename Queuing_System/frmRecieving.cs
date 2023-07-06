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
            timer_confirmed.Start();
            //display();
        }

        private void datetimer_Tick(object sender, EventArgs e)
        {
            datetodaylbl.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            dataGridView1.ClearSelection();
            post();
            onhold();
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
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There is nothing here.");
            }
            else if (txtnumber.Text == "")
            {
                MessageBox.Show("Please select data you want to Confirm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Are you sure you want to move this data to confirmed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into db_confirmed (Date,Number,Lane,Category,TableNo,Status) values ('" + txtdate.Text + "','" + txtnumber.Text + "','" + txtlane.Text + "','" + txtcategory.Text + "','" + txttable.Text + "','" + "Complied" + "')";
                cmd1.ExecuteNonQuery();

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "delete from number_db WHERE Date = '"+ txtdate.Text +"' and  Number='" + txtnumber.Text + "' and Lane = '" + txtlane.Text + "' ";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data moved to confirmed ready to Queue", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // txt_number.Text = "0";



                clear();
                onhold();
                post();
                datetimer.Start();


                // if (!backgroundWorker1.IsBusy)
                //   backgroundWorker1.CancelAsync();
            }




            /*
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





    
                _bgWorker.RunWorkerAsync();

              

            }
                else
                {
                    MessageBox.Show("This Number already existed for today.");
                }
            */

        }
   
        public void onhold()
        {
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from db_onhold WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ORDER BY id ASC";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            this.dataGridView2.Columns["id"].Visible = false;
            // this.dataGridView1.Columns["TableNo"].Visible = false;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


        }
        public void post()
        {

        


            if (dataGridView1.Rows.Count == 0)
            {

                MySqlCommand cmd0 = con.CreateCommand();
                cmd0.CommandType = CommandType.Text;
                cmd0.CommandText = "select * from done_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Number ORDER BY id ASC";
                cmd0.ExecuteNonQuery();
                DataTable dt0 = new DataTable();
                MySqlDataAdapter da0 = new MySqlDataAdapter(cmd0);
                da0.Fill(dt0);
             
            }
            
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from number_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ORDER BY id ASC";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Columns["id"].Visible = false;
                this.dataGridView1.Columns["TableNo"].Visible = false;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

         




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
                onhold();


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

            btn_add.Enabled = true;
            if (_iNeedToCloseAfterBgWorker)
            Close();
        }

        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do long lasting work

            btn_add.Invoke((MethodInvoker)delegate {
                // Access button_add here
                btn_add.Enabled = false;
            });

          


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
      
                   
                
                
            }
          
        }

        private void btn_onhold_Click(object sender, EventArgs e)
        {
            
            
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There is nothing here.");
            }
            else if(txtnumber.Text == "")
            {
                MessageBox.Show("Please select data you want to put in OnHold.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Are you sure you want to put this data on hold?", "Onhold", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into db_onhold (Date,Number,Lane,Category,TableNo,Status) values ('" + txtdate.Text + "','" + txtnumber.Text + "','" + txtlane.Text + "','" + txtcategory.Text + "','" + txttable.Text + "','" + "Lacking of requirments" + "')";
                cmd1.ExecuteNonQuery();

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "delete from number_db WHERE Date = '" + txtdate.Text + "' and  Number='" + txtnumber.Text + "' and Lane = '" + txtlane.Text + "' ";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data put on hold","Onhold",MessageBoxButtons.OK,MessageBoxIcon.Information);
                // txt_number.Text = "0";

             

                clear();
                onhold();
                post();
                datetimer.Start();


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

        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            datetimer.Stop();
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from number_db where id=" + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtdate.Text = dr["Date"].ToString();
                    txtnumber.Text = dr["Number"].ToString();
                    txtlane.Text = dr["Lane"].ToString();
                    txtcategory.Text = dr["Category"].ToString();
                    txttable.Text = dr["TableNo"].ToString();
                    //txtstatcomplete.Text = dr["Status"].ToString();

                }


         
        }
        public void clear()
        {
            txtnumber.Clear();
            txtdate.Clear();
            txtlane.Clear();
            txtcategory.Clear();
            txttable.Clear();
           
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            datetimer.Start();
            post();
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datetimer.Start();
            clear();
        }

        private void dataGridView2_MouseHover(object sender, EventArgs e)
        {
            datetimer.Stop();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("There is nothing here.");
            }
            else if (txtholdnumber.Text == "")
            {
                MessageBox.Show("Please select data you want to move in Confirmed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Are you sure you want to move this data to confirmed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into db_confirmed (Date,Number,Lane,Category,TableNo,Status) values ('" + txtholddate.Text + "','" + txtholdnumber.Text + "','" + txtholdlane.Text + "','" + txtholdcategory.Text + "','" + txtholdtableno.Text + "','" + "Complied" + "')";
                cmd1.ExecuteNonQuery();

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "delete from db_onhold WHERE Date = '" + txtholddate.Text + "' and  Number='" + txtholdnumber.Text + "' and Lane = '" + txtholdlane.Text + "' ";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data moved to confirmed ready to Queue", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // txt_number.Text = "0";



                clear();
                onhold();
                post();
                datetimer.Start();


                // if (!backgroundWorker1.IsBusy)
                //   backgroundWorker1.CancelAsync();
            }



            datetimer.Start();
            onhold();
            clear();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int i = Convert.ToInt32(dataGridView2.SelectedCells[0].Value.ToString());
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from db_onhold where id=" + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtholddate.Text = dr["Date"].ToString();
                    txtholdnumber.Text = dr["Number"].ToString();
                    txtholdlane.Text = dr["Lane"].ToString();
                    txtholdcategory.Text = dr["Category"].ToString();
                    txtholdtableno.Text = dr["TableNo"].ToString();
                    txtstaon.Text = dr["Status"].ToString();
                    

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Empty Column!");
            }
        }
        public void regularandexpressconfirmed()
        {
            ///// REGULAR LANE TABLE
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '"+ "REGULAR LANE" +"' ORDER BY id ASC";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            da1.Fill(dt1);
            dataGridView3.DataSource = dt1;
            this.dataGridView3.Columns["id"].Visible = false;
            // this.dataGridView1.Columns["TableNo"].Visible = false;
            dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView3.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView3.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView3.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;



            ///// REGULAR LANE TABLE
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "EXPRESS LANE" + "' ORDER BY id ASC";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            dataGridView4.DataSource = dt2;
            this.dataGridView4.Columns["id"].Visible = false;
            // this.dataGridView1.Columns["TableNo"].Visible = false;
            dataGridView4.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView4.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView4.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView4.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView4.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView4.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


        }
        private void timer_confirmed_Tick(object sender, EventArgs e)
        {
            regularandexpressconfirmed();  
        }

        private void dataGridView3_MouseHover(object sender, EventArgs e)
        {
            timer_confirmed.Stop();
        }

        private void dataGridView4_MouseHover(object sender, EventArgs e)
        {
            timer_confirmed.Stop();
        }

        private void dataGridView3_MouseLeave(object sender, EventArgs e)
        {
            timer_confirmed.Start();
        }

        private void dataGridView4_MouseLeave(object sender, EventArgs e)
        {
            timer_confirmed.Start();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == this.dataGridView1.Columns["Lane"].Index)
                {

                    string Status = e.Value.ToString();

                    if (Status != null)
                    {

                        if (Status == "REGULAR LANE")
                        {

                            this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SeaGreen;

                        }

                        else if (Status == "EXPRESS LANE")
                        {

                            this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkCyan;

                        }
                      

                    }

                }

            }
            catch (Exception)
            {
            }
        }
    }
}
