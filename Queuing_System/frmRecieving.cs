using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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

        string j;
        string i;
        public void get_value(string i)
        {

            j = i;
        }

        BackgroundWorker _bgWorker;
        bool _iNeedToCloseAfterBgWorker;


        public Main_menu()
        {
            InitializeComponent();

            //display();
        }

        private void datetimer_Tick(object sender, EventArgs e)
        {
            datetodaylbl.Text = DateTime.Now.ToShortDateString();



        }


        /// <summary>
        /// //PRINTING FUNCTION
        /// </summary>


        string number = "";
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_add.Text == "Confirm")
                {
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("There is nothing here.");
                    }
                    else if (txtnumber.Text == "")
                    {
                        MessageBox.Show("Please select data you want to Confirm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txttable.Text == "None" || txttable.Text == "")
                    {
                        MessageBox.Show("Please select table number you want to assign to proceed.", "Select Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (MessageBox.Show("Are you sure you want to move this data to confirmed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        MySqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "insert into db_confirmed (Date,Number,Lane,Category,TableNo,Status) values ('" + txtdate.Text + "','" + txtnumber.Text + "','" + txtlane.Text + "','" + txtcategory.Text + "','" + txttable.Text + "','" + "Complied" + "')";
                        cmd1.ExecuteNonQuery();

                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "delete from number_db WHERE Date = '" + txtdate.Text + "' and  Number='" + txtnumber.Text + "' and Lane = '" + txtlane.Text + "' ";
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data moved to confirmed ready to Queue", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        clear();
                        onhold();
                        post();
                        datetimer.Start();




                    }
                }
                else if(btn_add.Text == "Update")
                {
                    MySqlCommand cmd = con.CreateCommand(); 
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update db_confirmed SET TableNo = '" + txttable.Text + "' where Lane='" + txtlane.Text + "' AND Number='"+ txtnumber.Text +"'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Table number updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occured: " + ex.Message);


            }
            finally
            {

            }



        }

        public void onhold()
        {
            try
            {

                // Access button_add here
                // con.Close();
                // con.Open();

                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from db_onhold WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY id ASC";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                da1.Fill(dt1);
                dataGridView2.Invoke((MethodInvoker)delegate
                {
                    dataGridView2.DataSource = dt1;
                    this.dataGridView2.Columns["id"].Visible = false;
                    this.dataGridView2.Columns["TableNo"].Visible = false;
                    dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView2.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                });


            }
            catch (Exception ex)
            {
                disable();
                /*
                lblconstatus.Invoke((MethodInvoker)delegate {
                    // Access button_add here
                    lblconstatus.Text = "An error occured: " + ex.Message;
                });*/
            }
            finally
            {

            }

        }
        public void post()
        {
            try
            {

                con.Close();
                con.Open();
                enable();
                // Access button_add here


                // Access button_add here



                if (dataGridView1.Rows.Count == 0)
                {

                    MySqlCommand cmd0 = con.CreateCommand();
                    cmd0.CommandType = CommandType.Text;
                    cmd0.CommandText = "select * from done_db WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND Number ORDER BY id ASC";
                    cmd0.ExecuteNonQuery();
                    DataTable dt0 = new DataTable();
                    MySqlDataAdapter da0 = new MySqlDataAdapter(cmd0);
                    da0.Fill(dt0);

                }

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from number_db WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY id ASC";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.Invoke((MethodInvoker)delegate
                {
                    dataGridView1.DataSource = dt;
                    this.dataGridView1.Columns["id"].Visible = false;
                    this.dataGridView1.Columns["TableNo"].Visible = false;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                });



            }
            catch (Exception ex)
            {

                disable();

                lblconstatus.Invoke((MethodInvoker)delegate
                {
                    // Access button_add here
                    // lblconstatus.Text = "An error occured: " + ex.Message;
                    lblconstatus.Text = "Connection lost, Reconnecting.......... ";
                });



            }
            finally
            {

            }


        }

        private void Main_menu_Load(object sender, EventArgs e)
        {



            try
            {


                // _bgWorker.RunWorkerAsync();
                con = new MySqlConnection(cs.DBcon);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();


                }
                con.Open();


                datetodaylbl.Invoke((MethodInvoker)delegate
                {
                    // Access button_add here
                    datetodaylbl.Text = DateTime.Now.ToShortDateString();
                });





                post();
                onhold();
                regularandexpressconfirmed();

                datetimer.Start();
                timer_confirmed.Start();


            }
            catch (Exception ex)
            {
                // Handle other exceptions that might occur
                datetimer.Stop();
                timer_confirmed.Stop();
                MessageBox.Show("An error occurred: " + ex.Message);

                this.Close();

                // Optionally, you can log the exception details for further analysis
                // LogException(ex);
            }
            finally
            {

                //this.Dispose();
                // Any cleanup or closing operations can be performed here
                // This code block will be executed regardless of whether an exception occurred or not
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



        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("There is nothing to delete here.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //DELETE USERS FROM DATABASE.
                else if (MessageBox.Show("Are you sure you want to delete this data?...", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {



                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete from number_db WHERE Date='" + DateTime.Now.ToString("yyyy-MM-dd") + "' ";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Table resetted");


                    post();
                    onhold();
                    datetimer.Start();
                    timer_confirmed.Start();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occured: " + ex.Message);


            }
            finally
            {

            }

        }

        private void btn_onhold_Click(object sender, EventArgs e)
        {


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
            //datetimer.Stop();
            timer_confirmed.Stop();
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            //datetimer.Start();

            timer_confirmed.Start();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                con.Close();
                con.Open();
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
                query = "select * from number_db where id=" + i + "";


            }
            catch (Exception ex)
            {
                lblconstatus.Text = " An Error Occured please check your connection. " + ex.Message;
            }

        }
        public void clear()
        {
            txtnumber.Clear();
            txtdate.Clear();
            txtlane.Clear();
            txtcategory.Clear();
           // txttable.Clear();

            btn_add.Text = "Confirm";
            btn_add.BackColor = Color.SeaGreen;




        }

        public void clearonhold()
        {
            txtholdnumber.Clear();
            txtholddate.Clear();
            txtholdlane.Clear();
            txtholdcategory.Clear();
            txtholdtableno.Clear();
            txtstaon.Clear();

            btn_add.Text = "Confirm";
            btn_add.BackColor = Color.SeaGreen;


        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {

            // datetimer.Start();
            //  timer_confirmed.Start();
            // post();
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // datetimer.Start();
            // timer_confirmed.Start();
            clearonhold();
        }

        private void dataGridView2_MouseHover(object sender, EventArgs e)
        {
            datetimer.Stop();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
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



                    clearonhold();
                    onhold();
                    post();
                    datetimer.Start();


                    // if (!backgroundWorker1.IsBusy)
                    //   backgroundWorker1.CancelAsync();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occured: " + ex.Message);


            }
            finally
            {

            }





        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
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
            catch (Exception ex)
            {
                lblconstatus.Text = " An Error Occured please check your connection. " + ex.Message;
            }
        }

        public void regularandexpressconfirmed()
        {
            try
            {
                con.Close();
                con.Open();
                ///// REGULAR LANE TABLE
                ///c
                ///




                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "' ORDER BY id ASC";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                da1.Fill(dt1);
                dataGridView3.Invoke((MethodInvoker)delegate
                {
                    dataGridView3.DataSource = dt1;
                    this.dataGridView3.Columns["id"].Visible = false;
                    this.dataGridView3.Columns["Date"].Visible = false;
                    this.dataGridView3.Columns["Lane"].Visible = false;
                    this.dataGridView3.Columns["Category"].Visible = false;
                    dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                   // dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                   // dataGridView3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                   // dataGridView3.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView3.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView3.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                });



                ///// priority LANE TABLE
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "PRIORITY LANE" + "' ORDER BY id ASC";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                da2.Fill(dt2);
                dataGridView4.Invoke((MethodInvoker)delegate
                {
                    dataGridView4.DataSource = dt2;
                    this.dataGridView4.Columns["id"].Visible = false;
                    this.dataGridView4.Columns["Date"].Visible = false;
                    this.dataGridView4.Columns["Lane"].Visible = false;
                    this.dataGridView4.Columns["Category"].Visible = false;
                    dataGridView4.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                   // dataGridView4.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                   // dataGridView4.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                  //  dataGridView4.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView4.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView4.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                });

            }
            catch (Exception ex)
            {
                disable();
                /*
                lblconstatus.Invoke((MethodInvoker)delegate {
                    // Access button_add here
                    lblconstatus.Text = "An error occured: " + ex.Message;
                });
                */
            }
            finally
            {

            }


        }
        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do long lasting work









            post(); /////// CONNECTIONS HERE
            onhold();
            regularandexpressconfirmed();


            Thread.Sleep(1);





            //print();
        }
        public void disable()
        {
            // Example code running on a non-UI thread

            if (dataGridView1.IsHandleCreated)
            {
                dataGridView1.Invoke((MethodInvoker)delegate
                {

                    dataGridView1.Enabled = false;
                });
            }
            else
            {
                // Handle the scenario where the control's handle is not yet created
                // You can choose to delay the operation or perform alternative actions
            }

            // Update the label text on the UI thread

            if (dataGridView2.IsHandleCreated)
            {
                dataGridView2.Invoke((MethodInvoker)delegate
                {

                    dataGridView2.Enabled = false;
                });
            }
            else
            {
                // Handle the scenario where the control's handle is not yet created
                // You can choose to delay the operation or perform alternative actions
            }








            if (btn_delete.IsHandleCreated)
            {
                btn_delete.Invoke((MethodInvoker)delegate
                {

                    btn_delete.Enabled = false;
                });
            }
            else
            {
                // Handle the scenario where the control's handle is not yet created
                // You can choose to delay the operation or perform alternative actions
            }




            if (gb_verfication.IsHandleCreated)
            {
                gb_verfication.Invoke((MethodInvoker)delegate
                {

                    gb_verfication.Enabled = false;
                });
            }
            else
            {
                // Handle the scenario where the control's handle is not yet created
                // You can choose to delay the operation or perform alternative actions
            }









            if (gb_onhold.IsHandleCreated)
            {
                gb_onhold.Invoke((MethodInvoker)delegate
                {

                    gb_onhold.Enabled = false;
                });
            }
            else
            {
                // Handle the scenario where the control's handle is not yet created
                // You can choose to delay the operation or perform alternative actions
            }








            if (lblconstatus.IsHandleCreated)
            {
                lblconstatus.Invoke((MethodInvoker)delegate
                {


                    lblconstatus.ForeColor = Color.Crimson;
                });



            }
            else
            {
                // Handle the scenario where the control's handle is not yet created
                // You can choose to delay the operation or perform alternative actions
            }






            if (pic_check.IsHandleCreated)
            {
                pic_check.Invoke((MethodInvoker)delegate
                {

                    pic_check.Visible = false;
                });



            }
            else
            {
                // Handle the scenario where the control's handle is not yet created
                // You can choose to delay the operation or perform alternative actions
            }




            if (pic_loading.IsHandleCreated)
            {
                pic_loading.Invoke((MethodInvoker)delegate
                {

                    pic_loading.Visible = true;
                });



            }
            else
            {
                // Handle the scenario where the control's handle is not yet created
                // You can choose to delay the operation or perform alternative actions
            }





        }
        public void enable()
        {
            dataGridView1.Invoke((MethodInvoker)delegate
            {

                dataGridView1.Enabled = true;
            });

            dataGridView2.Invoke((MethodInvoker)delegate
            {

                dataGridView2.Enabled = true;
            });



            btn_delete.Invoke((MethodInvoker)delegate
            {

                btn_delete.Enabled = true;
            });


            gb_verfication.Invoke((MethodInvoker)delegate
            {

                gb_verfication.Enabled = true;
            });


            gb_onhold.Invoke((MethodInvoker)delegate
            {

                gb_onhold.Enabled = true;
            });

            lblconstatus.Invoke((MethodInvoker)delegate
            {

                lblconstatus.Text = "Connection Secured.";
                lblconstatus.ForeColor = Color.SeaGreen;
            });


            pic_check.Invoke((MethodInvoker)delegate
            {

                pic_check.Visible = true;
            });


            pic_loading.Invoke((MethodInvoker)delegate
            {

                pic_loading.Visible = false;
            });
        }




        private void timer_confirmed_Tick(object sender, EventArgs e)
        {
            try
            {

                _bgWorker.RunWorkerAsync();




            }
            catch (Exception ex)
            {

                // timer_confirmed.Stop();      // Access button_add here
                //  lblconstatus.Text = "An error occurred: " + ex.Message;



            }
            finally
            {

            }





            // regularandexpressconfirmed();

            /*

            post();
            onhold();
            regularandexpressconfirmed();
            /* dataGridView1.ClearSelection();
            */


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

                            this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Black;
                            this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;

                        }

                        else if (Status == "PRIORITY LANE")
                        {

                            this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                            this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

                        }


                    }

                }

            }
            catch (Exception)
            {
            }
        }

        private void check_onhold_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if(check_onhold.Checked == true)
            {
                lblreason.Visible = true;
                txt_reason.Visible = true;

                btn_add.Text = "Hold";
                btn_add.BackColor = Color.DarkCyan;
                txt_reason.Focus();
            }
            else
            {
                lblreason.Visible = false;
                txt_reason.Visible = false;

                btn_add.Text = "Confirm";
                btn_add.BackColor = Color.SeaGreen;
            }
            */
        }

        private void dataGridView2_MouseLeave(object sender, EventArgs e)
        {
            datetimer.Start();
        }
        string query;
        public void print()
        {





            get_value(query.ToString());
            RecieptDS ds = new RecieptDS();

            //int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            MySqlCommand cmd6 = con.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            cmd6.CommandText = "select * from number_db where Number =" + txtnumber.Text + "";
            cmd6.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd6);
            da3.Fill(ds.DataTable1);
            NumberCrystal myreport = new NumberCrystal();
            myreport.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = myreport;
            myreport.PrintToPrinter(1, false, 0, 0);



        }

        private void printnew()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            printDocument.Print();  // trigger printing

            /*
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;



            
                        if (printDialog.ShowDialog() == DialogResult.OK)
                        {
                            
                        }
            */
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (txtdate.Text == "" || txtnumber.Text == "")
            {
                MessageBox.Show("Please select data you want to print", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to print number: " + txtnumber.Text + " Category: " + txtcategory.Text, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {


                        printnew();
                        clear();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("an error occured: " + ex.Message);
                    }
                    finally
                    {

                    }
                }

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPos = 0; // Y-coordinate for positioning the content
            using (MySqlConnection connection = new MySqlConnection(cs.DBcon))
            {
                connection.Open();

                string query = "SELECT * FROM number_db WHERE Number='" + txtnumber.Text + "' AND Lane = '" + txtlane.Text + "' AND Date = '" + txtdate.Text + "'";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string date = reader.GetString("Date");
                            int number = reader.GetInt32("Number");
                            string lane = reader.GetString("Lane");
                            string category = reader.GetString("Category");
                            string tableno = reader.GetString("TableNo");



                            /////// TICKET PRINTING HARD CODING
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(20, 10, 260, 250));  ///        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(LEFT, UP, WIDTH, HEIGHT));

                            string imagePath = Path.Combine(Application.StartupPath, "branding.jpg");
                            Image image = Image.FromFile(imagePath);
                            e.Graphics.DrawImage(image, new Rectangle(20, 10, 150, 40));



                            e.Graphics.DrawString($"{date}", new Font("Century Gothic", 9, FontStyle.Italic), Brushes.Black, new PointF(190, 10));
                            e.Graphics.DrawLine(Pens.Black, new Point(280, 95), new Point(20, 95)); ///e.Graphics.DrawLine(Pens.Black, new Point(LINE WIDTH, TOP LOCATION), new Point(LEFT , RIGHT));
                            e.Graphics.DrawString("CIS", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new PointF(110, 50));
                            e.Graphics.DrawString("Lane:", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(60, 100));
                            e.Graphics.DrawString($"{lane}", new Font("Arial black", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 100));/// e.Graphics.DrawString($"{date}", new Font("Century Gothic", 12), Brushes.Black, new PointF(LEFT POSITION, TOP));
                            e.Graphics.DrawString("Category:", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(30, 130));
                            e.Graphics.DrawString($"{category}", new Font("Century Gothic", 10, FontStyle.Italic), Brushes.Black, new PointF(100, 130));
                            e.Graphics.DrawString("Please wait until your NUMBER was Called", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new PointF(35, 160));
                            e.Graphics.DrawString("YOUR NUMBER IS:", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new PointF(100, 173));
                            e.Graphics.DrawLine(Pens.Black, new Point(280, 150), new Point(20, 150)); ///e.Graphics.DrawLine(Pens.Black, new Point(LINE WIDTH, TOP LOCATION), new Point(LEFT , RIGHT));

                            //e.Graphics.DrawString($"{number}", new Font("Arial black", 50), Brushes.Black, new PointF(90, 175));





                            float textHeight = e.Graphics.MeasureString($"{number}", new Font("Arial black", 50)).Height;
                            float yPosBottom = yPos + 280 - textHeight;
                            e.Graphics.DrawString($"{number}", new Font("Arial black", 50), Brushes.Black, new PointF(100, yPosBottom));





                            e.Graphics.DrawString("-END OF THE LINE-", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(95, 270));


                        }
                    }
                }
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                con.Close();
                con.Open();
                int i = Convert.ToInt32(dataGridView3.SelectedCells[0].Value.ToString());
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from db_confirmed where id=" + i + "";
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

                    btn_add.Text = "Update";
                    btn_add.BackColor = Color.DarkGoldenrod;
                    //txtstatcomplete.Text = dr["Status"].ToString();

                }
             


            }
            catch (Exception ex)
            {
                lblconstatus.Text = " An Error Occured please check your connection. " + ex.Message;
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                int i = Convert.ToInt32(dataGridView4.SelectedCells[0].Value.ToString());
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from db_confirmed where id=" + i + "";
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

                    btn_add.Text = "Update";
                    btn_add.BackColor = Color.DarkGoldenrod;
                    //txtstatcomplete.Text = dr["Status"].ToString();

                }



            }
            catch (Exception ex)
            {
                lblconstatus.Text = " An Error Occured please check your connection. " + ex.Message;
            }
        }
    }
}
