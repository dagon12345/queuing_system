﻿using System;
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

            date_timer.Start();
            clear();


        }

        /// <summary>
        /// /FOR PRINTING
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _bgWorker1_RunWorkerCompleted1(object sender, RunWorkerCompletedEventArgs e)
        {
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

            lblstatus.Invoke((MethodInvoker)delegate {
                // Access lblstatus here
                lblstatus.Text = "Printing.....";
            });




            Thread.Sleep(1500);
            print();


        }




        void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblstatus.Text = "Ready to release";
         
            lbl_connection.Text = "Successfully connected to SQL Server";
            btn_generate.Enabled = true;
            cmb_lane.Enabled = true;
            if (_iNeedToCloseAfterBgWorker)
                Close();
        }

        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do long lasting work

            btn_generate.Invoke((MethodInvoker)delegate {
                // Access button_add here
                btn_generate.Enabled = false;
            });


            lblstatus.Invoke((MethodInvoker)delegate {
                // Access button_add here
                lbl_connection.Text = "Checking SQL Connection";
            });


        
            /*
            lblstatus.Invoke((MethodInvoker)delegate {
                // Access lblstatus here
                lblstatus.Text = "Printing.....";
            });

            */


            Thread.Sleep(1000);

            try
            {
            }
            catch (Exception)
            {
                MessageBox.Show("Can't connect to the SQL Server. Try again..", "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            con = new MySqlConnection(cs.DBcon);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }
                con.Open();

                post();

          

            //print();
        }

        private void cmb_lane_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if(cmb_lane.Text == "EXPRESS LANE")
            {
                grp_category.Enabled = true;
            }
            else
            {
                grp_category.Enabled = false;
            }
            */
        }

        private int? CountDataExpress()
        {
            // Establish a connection to the database

            using (MySqlConnection connection = new MySqlConnection(cs.DBcon))
            {
                connection.Open();

                // Create a SQL query to count the data in the table
                string query = "SELECT COUNT(*) FROM number_db  WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Lane = '" + "EXPRESS LANE" + "'";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Execute the query and retrieve the count
                   // int count = Convert.ToInt32(command.ExecuteScalar());
                  // return count;

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        private int? CountDataRegular()
        {
            // Establish a connection to the database

            using (MySqlConnection connection = new MySqlConnection(cs.DBcon))
            {
                connection.Open();

                // Create a SQL query to count the data in the table
                string query = "SELECT COUNT(*) FROM number_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Lane = '" + "REGULAR LANE" + "'";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Execute the query and retrieve the count
                    // int count = Convert.ToInt32(command.ExecuteScalar());
                    // return count;

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return null;
                    }

                }
            }
        }

        public void post()
        {
            /*
            txt_mynumber.Invoke((MethodInvoker)delegate {
                // Access button_add here
               
            });
            */

            if(datagridregularlane.Rows.Count == 0)
            {
                txt_regularlane.Text = "0";
            }
            if(datagridexpress.Rows.Count == 0)
            {
                txt_expresslane.Text = "0";
            }
            if(datagridonholdregular.Rows.Count == 0)
            {
                txtonholdregular.Text = "0";
            }
            if(datagridonholdexpress.Rows.Count == 0)
            {
                txtonholdexpress.Text = "0";
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



            if (datagridonholdregular !=null)
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


            /*

            
            if (datagridregularlane.Rows.Count == 0 && datagridexpress.Rows.Count == 0 && datagridonholdregular.Rows.Count == 0 && datagridonholdexpress.Rows.Count == 0)
            
            {

                MySqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "select * from done_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Lane = '" + "EXPRESS LANE" + "' ORDER BY Number DESC";
                cmd5.ExecuteNonQuery();
                DataTable dt5 = new DataTable();
                MySqlDataAdapter da5 = new MySqlDataAdapter(cmd5);
                da5.Fill(dt5);
                foreach (DataRow dr in dt5.Rows)
                {


                    txt_expresslane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_expresslane.Text = dr["Number"].ToString();
                    });


                }


                MySqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "select * from done_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Lane = '" + "REGULAR LANE" + "' ORDER BY Number DESC";
                cmd6.ExecuteNonQuery();
                DataTable dt6 = new DataTable();
                MySqlDataAdapter da6 = new MySqlDataAdapter(cmd6);
                da6.Fill(dt6);
                foreach (DataRow dr in dt6.Rows)
                {


                    txt_regularlane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_regularlane.Text = dr["Number"].ToString();
                    });


                }


            }

            




                /*

                txt_regularlane.Invoke((MethodInvoker)delegate
                {
                     if (datagridregularlane.Rows.Count == 0)
                     {
                         txt_regularlane.Text = "0";
                     }
                });

                */
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
                /*

            txt_expresslane.Invoke((MethodInvoker)delegate
            {
                if (datagridexpress.Rows.Count == 0)
                {
                    txt_expresslane.Text = "0";
                }
            });
                */

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

      
        private void frm_GenerateNumbers_Load(object sender, EventArgs e)
        {
            //clear();
          




            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += _bgWorker_DoWork;
            _bgWorker.RunWorkerCompleted += _bgWorker_RunWorkerCompleted;



            _bgWorker1 = new BackgroundWorker();
            _bgWorker1.DoWork += _bgWorker1_DoWork1;
            _bgWorker1.RunWorkerCompleted += _bgWorker1_RunWorkerCompleted1;


            _bgWorker.RunWorkerAsync();


        }

        private void date_timer_Tick(object sender, EventArgs e)
        {
           txt_date.Text = DateTime.Now.ToString("MMMM dd, yyyy");

       
            if (lbl_connection.Text == "Successfully connected to SQL Server")
            {
                post();


              

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
                                      cmd1.CommandText = "insert into number_db (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("MMMM dd, yyyy") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "Person with disability(PWD)" + "','" + "ON TABLE NUMBER 1" + "')";
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
                                     cmd1.CommandText = "insert into number_db (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("MMMM dd, yyyy") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "Pregnant" + "','" + "ON TABLE NUMBER 1" + "')";
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
                                     cmd1.CommandText = "insert into number_db (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("MMMM dd, yyyy") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "Lactating" + "','" + "ON TABLE NUMBER 1" + "')";
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
                                     cmd1.CommandText = "insert into number_db (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("MMMM dd, yyyy") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "Senior Citizen" + "','" + "ON TABLE NUMBER 1" + "')";
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
                        cmd1.CommandText = "insert into number_db (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("MMMM dd, yyyy") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "None" + "','" + "ON TABLE NUMBER 1" + "')";
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
            rb_pwd.Checked = false;
            rb_lactating.Checked = false;
            rb_pregnant.Checked = false;
            rb_senior.Checked = false;

            cmb_lane.Text = "REGULAR LANE";
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
    }
}
