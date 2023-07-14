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
using Microsoft.Win32;
using System.Drawing.Printing;
using System.IO;

namespace Queuing_System
{
    public partial class frm_GenerateNumbers : Form
    {
        ConnectionString cs = new ConnectionString();
        MySqlConnection con = null;

        int j;

        public void get_value(int i)
        {

            j = i;
        }

        BackgroundWorker _bgWorker;
        BackgroundWorker _bgWorker1;


        bool _iNeedToCloseAfterBgWorker;

        public frm_GenerateNumbers()
        {
            InitializeComponent();

          


        }

        /// <summary>
        /// /FOR PRINTING
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _bgWorker1_RunWorkerCompleted1(object sender, RunWorkerCompletedEventArgs e)
        {
            date_timer.Start();
            lblstatus.Text = "Ready to release";
            btn_generate.Enabled = true;
            if (_iNeedToCloseAfterBgWorker)
                Close();
        }

        void _bgWorker1_DoWork1(object sender, DoWorkEventArgs e)
        {
            // Do long lasting work


           


            btn_generate.Invoke((MethodInvoker)delegate {
                // Access button_add here
                btn_generate.Enabled = false;
            });

            date_timer.Stop();


            lblstatus.Invoke((MethodInvoker)delegate {
                // Access lblstatus here
                lblstatus.Text = "Printing.....";
            });






        
            post();
            printnew();
            Thread.Sleep(2000);


            clear();


        }




        void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
     
           
            if (_iNeedToCloseAfterBgWorker)
                Close();
        }

        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {


            post();





            Thread.Sleep(1000);
   



         
        }

        private void cmb_lane_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        public void post()
        {

            try
            {
                con.Close();
                con.Open();
                enable();

                if (datagridregularlane.Rows.Count == 0)
                {
                    txt_regularlane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_regularlane.Text = "0";
                    });

                }
                if (datagridexpress.Rows.Count == 0)
                {

                    txt_expresslane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_expresslane.Text = "0";
                    });


                }



                if (datagridonholdregular.Rows.Count == 0)
                {
                    txtonholdregular.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txtonholdregular.Text = "0";
                    });


                }
                if (datagridonholdexpress.Rows.Count == 0)
                {

                    txtonholdexpress.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txtonholdexpress.Text = "0";
                    });


                }


                if (datagridregularlane.Rows.Count == 0)
                {
                    //// REGULAR LANE
                    MySqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Lane = '" + "REGULAR LANE" + "'  ORDER BY Number ASC";
                    cmd2.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                    da2.Fill(dt2);
                    foreach (DataRow dr in dt2.Rows)
                    {
                        txt_regularlane.Invoke((MethodInvoker)delegate
                        {
                        // Access button_add here
                        txt_regularlane.Text = dr["Number"].ToString();

                        });

                    }

                }

                if (datagridexpress.Rows.Count == 0)
                {
                    //// EXPRESS LANE
                    MySqlCommand cmd3 = con.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Lane = '" + "EXPRESS LANE" + "'  ORDER BY Number ASC";
                    cmd3.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
                    da3.Fill(dt3);
                    foreach (DataRow dr in dt3.Rows)
                    {
                        txt_expresslane.Invoke((MethodInvoker)delegate
                        {
                        // Access button_add here
                        txt_expresslane.Text = dr["Number"].ToString();

                        });

                    }


                }



                if (datagridonholdregular != null)
                {

                    MySqlCommand cmd4 = con.CreateCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "select * from db_onhold WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Lane = '" + "REGULAR LANE" + "' ORDER BY id ASC";
                    cmd4.ExecuteNonQuery();
                    DataTable dt4 = new DataTable();
                    MySqlDataAdapter da4 = new MySqlDataAdapter(cmd4);
                    da4.Fill(dt4);
                    datagridonholdexpress.DataSource = dt4;
                    foreach (DataRow dr in dt4.Rows)
                    {


                        txtonholdregular.Invoke((MethodInvoker)delegate
                        {
                        // Access button_add here
                        txtonholdregular.Text = dr["Number"].ToString();
                        });


                    }
                }

                if (datagridonholdexpress.DataSource != null)
                {
                    MySqlCommand cmd5 = con.CreateCommand();
                    cmd5.CommandType = CommandType.Text;
                    cmd5.CommandText = "select * from db_onhold WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Lane = '" + "EXPRESS LANE" + "' ORDER BY id ASC";
                    cmd5.ExecuteNonQuery();
                    DataTable dt5 = new DataTable();
                    MySqlDataAdapter da5 = new MySqlDataAdapter(cmd5);
                    da5.Fill(dt5);
                    datagridonholdexpress.DataSource = dt5;
                    foreach (DataRow dr in dt5.Rows)
                    {


                        txtonholdexpress.Invoke((MethodInvoker)delegate
                        {
                        // Access button_add here
                        txtonholdexpress.Text = dr["Number"].ToString();
                        });


                    }
                }


                //// REGULAR LANE
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from number_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Lane = '" + "REGULAR LANE" + "'  ORDER BY id ASC";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                datagridregularlane.DataSource = dt;
                foreach (DataRow dr in dt.Rows)
                {
                    txt_regularlane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_regularlane.Text = dr["Number"].ToString();

                    });

                }


                //// Express LANE
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from number_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Lane = '" + "EXPRESS LANE" + "' ORDER BY id ASC";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                da1.Fill(dt1);
                datagridexpress.DataSource = dt;
                foreach (DataRow dr in dt1.Rows)
                {


                    txt_expresslane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_expresslane.Text = dr["Number"].ToString();
                    });


                }









            }


            catch (Exception ex)
            {
                // disable();


                if (lbl_connection.IsHandleCreated)
                {

                   // disable();
                    lbl_connection.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        // lblconstatus.Text = "An error occured: " + ex.Message;
                        lbl_connection.Text = "Connection lost, Reconnecting.......... ";
                        lbl_connection.ForeColor = Color.Crimson;
                    });
                }

                else
                {
                    // Handle the scenario where the control's handle is not yet created
                    // You can choose to delay the operation or perform alternative actions
                }






            }
            finally
            {

            }



        }

      
        private void frm_GenerateNumbers_Load(object sender, EventArgs e)
        {
            //clear();


           


            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += _bgWorker_DoWork;
            _bgWorker.RunWorkerCompleted += _bgWorker_RunWorkerCompleted;



            _bgWorker1 = new BackgroundWorker();
            _bgWorker1.DoWork += _bgWorker1_DoWork1;
            _bgWorker1.RunWorkerCompleted += _bgWorker1_RunWorkerCompleted1;


          


            try
            {
                // Create and open a SQL connection
            
                    con = new MySqlConnection(cs.DBcon);
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();


                    }
                    con.Open();

                date_timer.Start();
                clear();


                post();

               

            }
          
            catch (Exception ex)
            {
                // Handle other exceptions that might occur
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



        }

        public void disable()
        {
            if (btn_generate.IsHandleCreated)
            {
                btn_generate.Invoke((MethodInvoker)delegate {

                    btn_generate.Enabled = false;
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
            btn_generate.Invoke((MethodInvoker)delegate {

                btn_generate.Enabled = true;
            });

            /*

            lblstatus.Invoke((MethodInvoker)delegate {

                lblstatus.Text = "Ready to release";
            });
            */



            lbl_connection.Invoke((MethodInvoker)delegate {

                lbl_connection.Text = "Successfully connected to SQL Server";
                lbl_connection.ForeColor = Color.SeaGreen;

            });







         



        }




        private void date_timer_Tick(object sender, EventArgs e)
        {

            try
            {
                _bgWorker.RunWorkerAsync();
            }
            catch(Exception ex)
            {
              

            }
            finally
            {

            }
           txt_date.Text = DateTime.Now.ToString("MMMM dd, yyyy");

       
            if (lbl_connection.Text == "Successfully connected to SQL Server")
            {
               


              

                    if (cmb_lane.Text == "EXPRESS LANE")
                    {
                     
                             if(txt_expresslane.Text == "0")
                             {
                                 txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);
                             }


                             if (Convert.ToInt32(txt_expresslane.Text) > Convert.ToInt32(txtonholdexpress.Text))
                             {
                                 txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);
                             }
                             else if(Convert.ToInt32(txt_expresslane.Text) < Convert.ToInt32(txtonholdexpress.Text))
                             {
                                 txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txtonholdexpress.Text) + 1);
                             }

                            
                    

                    }
                    else if (cmb_lane.Text == "REGULAR LANE")
                    {

                            if (txt_regularlane.Text == "0")
                            {
                                txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_regularlane.Text) + 1);
                            }



                            if (Convert.ToInt32(txt_regularlane.Text) > Convert.ToInt32(txtonholdregular.Text))
                            {
                                  txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_regularlane.Text) + 1);
                            }
                            else if(Convert.ToInt32(txt_regularlane.Text) < Convert.ToInt32(txtonholdregular.Text))
                            {
                                  txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txtonholdregular.Text) + 1);
                            }


                    }

               
             


               







                  
                


            
            }

           
        }
     
        public void print()
        {
       
            get_value(Convert.ToInt32(number.ToString()));
            RecieptDS ds = new RecieptDS();


            MySqlCommand cmd6 = con.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            cmd6.CommandText = "select * from number_db where id=" + j + "";
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
        private void btn_generate_Click(object sender, EventArgs e)
        {

           

            try
            {
                con.Close();
                con.Open();

                if (cmb_lane.Text == "")
                {
                    MessageBox.Show("Please select LANE first to proceed", "Select Lane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmb_lane.Text == "EXPRESS LANE")
                {


                    int i = 0;
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * FROM number_db where Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Number ='" + txt_mynumber.Text + "'AND Lane ='" + cmb_lane.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());
                    if (i == 0)
                    {



                        if (rb_pwd.Checked)/////// EXPRESS LANE
                        {
                            if (MessageBox.Show("Are you sure you want to generate Number?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);


                                if (cmb_lane.Text == "EXPRESS LANE")
                                {

                                    if (txt_expresslane.Text == "0")
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);
                                    }


                                    if (Convert.ToInt32(txt_expresslane.Text) > Convert.ToInt32(txtonholdexpress.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);
                                    }
                                    else if (Convert.ToInt32(txt_expresslane.Text) < Convert.ToInt32(txtonholdexpress.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txtonholdexpress.Text) + 1);
                                    }




                                }
                                else if (cmb_lane.Text == "REGULAR LANE")
                                {

                                    if (txt_regularlane.Text == "0")
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_regularlane.Text) + 1);
                                    }



                                    if (Convert.ToInt32(txt_regularlane.Text) > Convert.ToInt32(txtonholdregular.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_regularlane.Text) + 1);
                                    }
                                    else if (Convert.ToInt32(txt_regularlane.Text) < Convert.ToInt32(txtonholdregular.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txtonholdregular.Text) + 1);
                                    }


                                }


                                MySqlCommand cmd1 = con.CreateCommand();
                                cmd1.CommandType = CommandType.Text;
                                cmd1.CommandText = "insert into number_db (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("MMMM dd, yyyy") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "Person with disability(PWD)" + "','" + "None" + "')";
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

                                _bgWorker1.RunWorkerAsync();
                            }

                        }
                        else if (rb_pregnant.Checked)/////// EXPRESS LANE
                        {
                            if (MessageBox.Show("Are you sure you want to generate Number?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);


                                if (cmb_lane.Text == "EXPRESS LANE")
                                {

                                    if (txt_expresslane.Text == "0")
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);
                                    }


                                    if (Convert.ToInt32(txt_expresslane.Text) > Convert.ToInt32(txtonholdexpress.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);
                                    }
                                    else if (Convert.ToInt32(txt_expresslane.Text) < Convert.ToInt32(txtonholdexpress.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txtonholdexpress.Text) + 1);
                                    }




                                }
                                else if (cmb_lane.Text == "REGULAR LANE")
                                {

                                    if (txt_regularlane.Text == "0")
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_regularlane.Text) + 1);
                                    }



                                    if (Convert.ToInt32(txt_regularlane.Text) > Convert.ToInt32(txtonholdregular.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_regularlane.Text) + 1);
                                    }
                                    else if (Convert.ToInt32(txt_regularlane.Text) < Convert.ToInt32(txtonholdregular.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txtonholdregular.Text) + 1);
                                    }


                                }

                                MySqlCommand cmd1 = con.CreateCommand();
                                cmd1.CommandType = CommandType.Text;
                                cmd1.CommandText = "insert into number_db (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("MMMM dd, yyyy") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "Pregnant" + "','" + "None" + "')";
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

                                _bgWorker1.RunWorkerAsync();
                            }
                        }
                        else if (rb_lactating.Checked)/////// EXPRESS LANE
                        {
                            if (MessageBox.Show("Are you sure you want to generate Number?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);


                                if (cmb_lane.Text == "EXPRESS LANE")
                                {

                                    if (txt_expresslane.Text == "0")
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);
                                    }


                                    if (Convert.ToInt32(txt_expresslane.Text) > Convert.ToInt32(txtonholdexpress.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);
                                    }
                                    else if (Convert.ToInt32(txt_expresslane.Text) < Convert.ToInt32(txtonholdexpress.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txtonholdexpress.Text) + 1);
                                    }




                                }
                                else if (cmb_lane.Text == "REGULAR LANE")
                                {

                                    if (txt_regularlane.Text == "0")
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_regularlane.Text) + 1);
                                    }



                                    if (Convert.ToInt32(txt_regularlane.Text) > Convert.ToInt32(txtonholdregular.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_regularlane.Text) + 1);
                                    }
                                    else if (Convert.ToInt32(txt_regularlane.Text) < Convert.ToInt32(txtonholdregular.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txtonholdregular.Text) + 1);
                                    }


                                }


                                MySqlCommand cmd1 = con.CreateCommand();
                                cmd1.CommandType = CommandType.Text;
                                cmd1.CommandText = "insert into number_db (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("MMMM dd, yyyy") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "Lactating" + "','" + "None" + "')";
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

                                _bgWorker1.RunWorkerAsync();
                            }
                        }
                        else if (rb_senior.Checked)/////// EXPRESS LANE
                        {
                            if (MessageBox.Show("Are you sure you want to generate Number?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {


                                //txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);


                                if (cmb_lane.Text == "EXPRESS LANE")
                                {

                                    if (txt_expresslane.Text == "0")
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);
                                    }


                                    if (Convert.ToInt32(txt_expresslane.Text) > Convert.ToInt32(txtonholdexpress.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);
                                    }
                                    else if (Convert.ToInt32(txt_expresslane.Text) < Convert.ToInt32(txtonholdexpress.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txtonholdexpress.Text) + 1);
                                    }




                                }
                                else if (cmb_lane.Text == "REGULAR LANE")
                                {

                                    if (txt_regularlane.Text == "0")
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_regularlane.Text) + 1);
                                    }



                                    if (Convert.ToInt32(txt_regularlane.Text) > Convert.ToInt32(txtonholdregular.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_regularlane.Text) + 1);
                                    }
                                    else if (Convert.ToInt32(txt_regularlane.Text) < Convert.ToInt32(txtonholdregular.Text))
                                    {
                                        txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txtonholdregular.Text) + 1);
                                    }


                                }


                                MySqlCommand cmd1 = con.CreateCommand();
                                cmd1.CommandType = CommandType.Text;
                                cmd1.CommandText = "insert into number_db (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("MMMM dd, yyyy") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "Senior Citizen" + "','" + "None" + "')";
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

                                _bgWorker1.RunWorkerAsync();
                            }
                        }
                        else
                        {

                            MessageBox.Show("Please select CATEGORY to proceed ", "Select Category", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }



                    }
                    else
                    {
                        MessageBox.Show("This Number already existed for today.");
                    }


                }
                else if (cmb_lane.Text == "REGULAR LANE")
                {

                    int i = 0;
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * FROM number_db where Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Number ='" + txt_mynumber.Text + "'AND Lane ='" + cmb_lane.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());
                    if (i == 0)
                    {
                        if (MessageBox.Show("Are you sure you want to generate Number?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_regularlane.Text) + 1);


                            if (cmb_lane.Text == "EXPRESS LANE")
                            {

                                if (txt_expresslane.Text == "0")
                                {
                                    txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);
                                }


                                if (Convert.ToInt32(txt_expresslane.Text) > Convert.ToInt32(txtonholdexpress.Text))
                                {
                                    txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_expresslane.Text) + 1);
                                }
                                else if (Convert.ToInt32(txt_expresslane.Text) < Convert.ToInt32(txtonholdexpress.Text))
                                {
                                    txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txtonholdexpress.Text) + 1);
                                }




                            }
                            else if (cmb_lane.Text == "REGULAR LANE")
                            {

                                if (txt_regularlane.Text == "0")
                                {
                                    txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_regularlane.Text) + 1);
                                }



                                if (Convert.ToInt32(txt_regularlane.Text) > Convert.ToInt32(txtonholdregular.Text))
                                {
                                    txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_regularlane.Text) + 1);
                                }
                                else if (Convert.ToInt32(txt_regularlane.Text) < Convert.ToInt32(txtonholdregular.Text))
                                {
                                    txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txtonholdregular.Text) + 1);
                                }


                            }


                            MySqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "insert into number_db (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("MMMM dd, yyyy") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "None" + "','" + "None" + "')";
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

                            _bgWorker1.RunWorkerAsync();
                        }

                    }



                }




                //clear();

                //con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message + "Please try again.");
            }
            finally
            {
                // Any cleanup or closing operations can be performed here
                // This code block will be executed regardless of whether an exception occurred or not
            }


            //printnew();
         // printpreview();


        }

        private void frm_GenerateNumbers_FormClosed(object sender, FormClosedEventArgs e)
        {
          // this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rb_pwd_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pwd.Checked == true || rb_lactating.Checked == true || rb_pregnant.Checked == true || rb_senior.Checked == true)
            {
                cmb_lane.Text = "EXPRESS LANE";
            }
            else
            {
                cmb_lane.Text = "REGULAR LANE";
            }
        }
        private void clear()
        {

            rb_pwd.Invoke((MethodInvoker)delegate {

                rb_pwd.Checked = false;

            });




            rb_lactating.Invoke((MethodInvoker)delegate {

                rb_lactating.Checked = false;

            });



            rb_pregnant.Invoke((MethodInvoker)delegate {

                rb_pregnant.Checked = false;

            });




            rb_senior.Invoke((MethodInvoker)delegate {

                rb_senior.Checked = false;

            });



            cmb_lane.Invoke((MethodInvoker)delegate {

                cmb_lane.Text = "REGULAR LANE";

            });



           
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void rb_lactating_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pwd.Checked == true || rb_lactating.Checked == true || rb_pregnant.Checked == true || rb_senior.Checked == true)
            {
                cmb_lane.Text = "EXPRESS LANE";
            }
            else
            {
                cmb_lane.Text = "REGULAR LANE";
            }
        }

        private void rb_pregnant_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pwd.Checked == true || rb_lactating.Checked == true || rb_pregnant.Checked == true || rb_senior.Checked == true)
            {
                cmb_lane.Text = "EXPRESS LANE";
            }
            else
            {
                cmb_lane.Text = "REGULAR LANE";
            }
        }

        private void rb_senior_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pwd.Checked == true || rb_lactating.Checked == true || rb_pregnant.Checked == true || rb_senior.Checked == true)
            {
                cmb_lane.Text = "EXPRESS LANE";
            }
            else
            {
                cmb_lane.Text = "REGULAR LANE";
            }
        }

        private void rb_senior_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rb_pwd.Checked == true || rb_lactating.Checked == true || rb_pregnant.Checked == true || rb_senior.Checked == true)
            {
                cmb_lane.Text = "EXPRESS LANE";
            }
            else
            {
                cmb_lane.Text = "REGULAR LANE";
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPos = 0; // Y-coordinate for positioning the content
            using (MySqlConnection connection = new MySqlConnection(cs.DBcon))
            {
                connection.Open();

                string query = "SELECT * FROM number_db WHERE Number='"+ txt_mynumber.Text +"' AND Lane = '"+ cmb_lane.Text +"' AND Date = '"+ txt_date.Text +"'";
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


            /*
            using (Font font = new Font("Arial", 12))
            {
                // Draw text
                e.Graphics.DrawString("Hello, World!", font, Brushes.Black, new PointF(50, 50));

                // Draw shapes
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(50, 100, 200, 100));
                e.Graphics.FillEllipse(Brushes.Red, new Rectangle(300, 100, 100, 100));

                // Draw images
                //Image image = Image.FromFile("queue.ico");
               // e.Graphics.DrawImage(image, new Rectangle(50, 250, 200, 150));
            }
            */


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


        private void printpreview()
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += printDocument1_PrintPage;
            printPreviewDialog.Document = printDocument;

            printPreviewDialog.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           // printnew();


        


        

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
