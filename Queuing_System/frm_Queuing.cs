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
using SpeechLib;//include this namespace


namespace Queuing_System
{
    public partial class frm_Queuing : Form
    {

        ConnectionString cs = new ConnectionString();
        MySqlConnection con = null;

        private SpVoice voice;
        public frm_Queuing()
        {
            InitializeComponent();


         
        }

        BackgroundWorker _bgWorker;
        BackgroundWorker _bgWorker1;
        BackgroundWorker _bgWorker2;


        bool _iNeedToCloseAfterBgWorker;


        void _bgWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            caller();

            if (_iNeedToCloseAfterBgWorker)
                Close();
        }

        string combo2;
        void _bgWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          
          
            // Do long lasting work
            Thread.Sleep(100);

            try
            {
                //btn_add.Enabled = true;


                btnrepeatexpress.Invoke((MethodInvoker)delegate {
                    // Access button here
                    btnrepeatexpress.Enabled = true;

                });


                btnconfirmexpress.Invoke((MethodInvoker)delegate {
                    // Access button here
                    btnconfirmexpress.Enabled = true;
                });



                con.Open();
                MySqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "update db_callerservice SET CallerStatus = '" + "IDLE" + "', Number = '" + "0" + "',TableNumber = '" + "-----" + "' ,Lane = '" + "-----" + "'";
                cmd4.ExecuteNonQuery();
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //if (txtexpressselectedno.Text.Trim().Length > 0)
            //    {
            //            SpVoice obj = new SpVoice();
            //            obj.Speak(label10.Text + txtexpressselectedno.Text + txtexpresstableno.Text + label9.Text, SpeechVoiceSpeakFlags.SVSFDefault);



            //    }




            //    if (txtexpressselectedno.Text.Trim().Length > 0)
            //    {
            //        SpVoice obj = new SpVoice();
            //        obj.Speak(label10.Text + txtexpressselectedno.Text + txtexpresstableno.Text + label9.Text, SpeechVoiceSpeakFlags.SVSFDefault);



            //    }


        }


        void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            caller();
            if (_iNeedToCloseAfterBgWorker)
                    Close();
          
        }

        string combo;
        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {



            // Do long lasting work
            Thread.Sleep(100);

            try
            {
                con.Close();


                btn_repeat.Invoke((MethodInvoker)delegate {
                    // Access button here
                    btn_repeat.Enabled = true;

                });


                btn_add.Invoke((MethodInvoker)delegate {
                    // Access button here
                    btn_add.Enabled = true;
                });


                //btn_add.Enabled = true;


                con.Open();
                MySqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "update db_callerservice SET CallerStatus = '" + "IDLE" + "', Number = '" + "0" + "',TableNumber = '" + "-----" + "' ,Lane = '" + "-----" + "'";
                cmd4.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }









        }

  
        public void regularandexpressconfirmed()
        {
            try
            {

                if (rb_socialworker.Checked == true)/////
                {


                   
                    con.Open();


                    enable();


                    // Access button_add here

                    ///// REGULAR LANE TABLE
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    tablenumbercmb.Invoke((MethodInvoker)delegate
                    {
                        cmd1.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "'AND TableNo = '" + tablenumbercmb.Text + "' ORDER BY Number ASC";
                    });
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                    da1.Fill(dt1);
                    datagridregular.Invoke((MethodInvoker)delegate
                    {



                        datagridregular.DataSource = dt1;
                        this.datagridregular.Columns["id"].Visible = false;
                        // this.datagridregular.Columns["TableNo"].Visible = false;
                        this.datagridregular.Columns["Date"].Visible = false;
                        this.datagridregular.Columns["Category"].Visible = false;
                        datagridregular.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridregular.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridregular.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridregular.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        datagridregular.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        datagridregular.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridregular.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    });






                    ///// EXPRESS LANE TABLE
                    MySqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    tablenumbercmb.Invoke((MethodInvoker)delegate
                    {
                        cmd2.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "PRIORITY LANE" + "'AND TableNo = '" + tablenumbercmb.Text + "' ORDER BY Number ASC";
                    });
                    cmd2.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                    da2.Fill(dt2);
                    datagridexpress.Invoke((MethodInvoker)delegate
                    {
                        datagridexpress.DataSource = dt2;
                        this.datagridexpress.Columns["id"].Visible = false;
                        // this.datagridexpress.Columns["TableNo"].Visible = false;
                        this.datagridexpress.Columns["Date"].Visible = false;
                        this.datagridexpress.Columns["Category"].Visible = false;
                        //datagridexpress.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        datagridexpress.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridexpress.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridexpress.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridexpress.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        datagridexpress.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        datagridexpress.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridexpress.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    });

                    con.Close();
                }
                else if (rb_numbercaller.Checked == true) ///NUMBER CALLER DISABLED DONE
                {


                   
                    con.Open();


                    enable();


                    ///// REGULAR LANE TABLE
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "' ORDER BY Number ASC";
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                    da1.Fill(dt1);
                    datagridregular.Invoke((MethodInvoker)delegate
                    {



                        datagridregular.DataSource = dt1;
                        this.datagridregular.Columns["id"].Visible = false;
                        // this.datagridregular.Columns["TableNo"].Visible = false;
                        this.datagridregular.Columns["Date"].Visible = false;
                        this.datagridregular.Columns["Category"].Visible = false;
                        datagridregular.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridregular.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridregular.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridregular.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        datagridregular.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        datagridregular.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridregular.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    });



                    ///// EXPRESS LANE TABLE
                    MySqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "PRIORITY LANE" + "' ORDER BY Number ASC";
                    cmd2.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                    da2.Fill(dt2);
                    datagridexpress.Invoke((MethodInvoker)delegate
                    {
                        datagridexpress.DataSource = dt2;
                        this.datagridexpress.Columns["id"].Visible = false;
                        // this.datagridexpress.Columns["TableNo"].Visible = false;
                        this.datagridexpress.Columns["Date"].Visible = false;
                        this.datagridexpress.Columns["Category"].Visible = false;
                        //datagridexpress.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        datagridexpress.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridexpress.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridexpress.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridexpress.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        datagridexpress.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        datagridexpress.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        datagridexpress.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    });


                    btn_add.Invoke((MethodInvoker)delegate
                    {


                        btn_add.Enabled = false;
                    });

                    btnconfirmexpress.Invoke((MethodInvoker)delegate
                    {


                        btnconfirmexpress.Enabled = false;
                    });


                    con.Close();
                }



            }
            catch (Exception ex)
            {
                disable();


                if (lblconstatus.IsHandleCreated)
                {


                    lblconstatus.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        lblconstatus.Text = "An error occured: " + ex.Message;
                        // lblconstatus.Text = "Connection lost, Reconnecting.......... ";
                        // lblconstatus.ForeColor = Color.Crimson;
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
        private void _bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update the progress bar value
            progressBar1.Value = e.ProgressPercentage;
        }
        private void frm_Queuing_Load(object sender, EventArgs e)
        {

            try
            {

                con = new MySqlConnection(cs.DBcon);
                timer1.Start();
                datetimer.Start();
                voice = new SpVoice();
                datagridtimer.Stop();
                pic_loading.Visible = false;
                gb_served.Enabled = false;
                gb_missed.Enabled = false;
                dg_rankings.Enabled = false;

                con.Open();
                MySqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "update db_callerservice SET CallerStatus = '" + "IDLE" + "', Number = '" + "0" + "',TableNumber = '" + "-----" + "' ,Lane = '" + "-----" + "'";
                cmd3.ExecuteNonQuery();
                con.Close();

                caller();
                savemissed();
               // missed();

            }
            catch (Exception ex)
            {
                datagridtimer.Stop();
                MessageBox.Show("An error occurred: " + ex.Message);
                this.Close();
            }




            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += _bgWorker_DoWork;
            _bgWorker.RunWorkerCompleted += _bgWorker_RunWorkerCompleted;
 

            _bgWorker1 = new BackgroundWorker();
            _bgWorker1.DoWork += _bgWorker1_DoWork;
            _bgWorker1.RunWorkerCompleted += _bgWorker1_RunWorkerCompleted;


            _bgWorker2 = new BackgroundWorker();
            _bgWorker2.DoWork += _bgWorker2_DoWork;
            _bgWorker2.RunWorkerCompleted += _bgWorker2_RunWorkerCompleted;


        }


        public void display()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            datagridregular.Invoke((MethodInvoker)delegate
            {
                datagridregular.DataSource = dt;
                da.Fill(dt);
                this.datagridregular.Columns["id"].Visible = false;
                this.datagridregular.Columns["TableNo"].Visible = false;
                datagridregular.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagridregular.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagridregular.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagridregular.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagridregular.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                //lbl_total.Text = datagridregular.Rows.Count.ToString();


                if (datagridregular.Rows.Count == 0)
                {

                    txt_number.Text = "0";
                    lblnext.Text = "0";
                }
            });


            con.Close();
        }



        public void done()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from done_db WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY id DESC";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                dataGridView2.Invoke((MethodInvoker)delegate {

                    dataGridView2.DataSource = dt;
                    da.Fill(dt);
                    this.dataGridView2.Columns["id"].Visible = false;
                    dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    int rowCount = dataGridView2.Rows.Count;
                    // Display the counts on labels
                    lbldonecount.Text = "Data's processed: " + rowCount.ToString();
                });
                con.Close();

            }
            catch (Exception)
            {
                disable();

            }
            finally
            {

            }

        }


        public void missed()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "select * from db_missed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY id DESC";
                //cmd.CommandText = "select * from db_missed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY id DESC";
                cmd.CommandText = "select * from db_missed WHERE Date = '" + DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + "' ORDER BY id DESC";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                dg_missed.Invoke((MethodInvoker)delegate {

                    dg_missed.DataSource = dt;
                    da.Fill(dt);
                    this.dg_missed.Columns["id"].Visible = false;
                    dg_missed.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dg_missed.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dg_missed.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dg_missed.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dg_missed.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


  


                    int rowCount = dg_missed.Rows.Count;
                    // Display the counts on labels
                    lblcount.Text = "Data's missed: " + rowCount.ToString();



                });
                con.Close();

            }
            catch (Exception)
            {
                disable();

            }
            finally
            {

            }

        }



        public void postexpresslane()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "PRIORITY LANE" + "' ORDER BY Number DESC";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtexpressnumbertop.Invoke((MethodInvoker)delegate
                    {
                        txtexpressnumbertop.Text = dr["Number"].ToString();
                    });

                    /*
                  txtexpressdate.Text = dr["Date"].ToString();
                  txtexpressselectedno.Text = dr["Number"].ToString();
                  txtexpresslane.Text = dr["Lane"].ToString();
                  txtexpresscategory.Text = dr["Category"].ToString();
                  txtexpresstableno.Text = dr["TableNo"].ToString();
                      */

                }
                con.Close();
            }
            catch (Exception)
            {
                disable();
                /*
                lblconstatus.Invoke((MethodInvoker)delegate {

                    lblconstatus.Text = "An error occured: " + ex.Message;
                });
                */

            }

        }


        public void top2expresslane()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Date,Lane,number FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "PRIORITY LANE" + "' ORDER BY Number ASC LIMIT 2";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtexpressnextnumber.Invoke((MethodInvoker)delegate
                    {
                        if (dt.Rows.Count < 2)
                        {
                            txtexpressnextnumber.Text = "0";

                        }
                        else
                        {
                            txtexpressnextnumber.Text = dr["Number"].ToString();
                        }
                    });

                }
                con.Close();
            }
            catch (Exception)
            {
                disable();
                /*
                lblconstatus.Invoke((MethodInvoker)delegate
                {

                    lblconstatus.Text = "An error occured: " + ex.Message;
                });
                */
            }

        }

        public void postregularlane()
        {



            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "' ORDER BY Number DESC";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {

                    txt_number.Invoke((MethodInvoker)delegate
                    {

                        txt_number.Text = dr["Number"].ToString();
                    });


                    /*
                   txtdate.Text = dr["Date"].ToString();
                   txtnumber.Text = dr["Number"].ToString();
                   txtlane.Text = dr["Lane"].ToString();
                   txtcategory.Text = dr["Category"].ToString();
                   txttable.Text = dr["TableNo"].ToString();
                     */



                }
                con.Close();
            }
            catch (Exception)
            {
                disable();

                /*
                lblconstatus.Invoke((MethodInvoker)delegate {

                    lblconstatus.Text = "An error occured: " + ex.Message;
                });
                */

            }
        }





        public void top2regularlane()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Date,Lane,number FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 2";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    lblnext.Invoke((MethodInvoker)delegate
                    {

                        if (dt.Rows.Count < 2)
                        {
                            lblnext.Text = "0";

                        }

                        else
                        {
                            lblnext.Text = dr["Number"].ToString();
                        }
                    });
                }
                con.Close();
            }

            catch (Exception)
            {
                disable();

                /*
                lblconstatus.Invoke((MethodInvoker)delegate {

                    lblconstatus.Text = "An error occured: " + ex.Message;
                });
                
                */
            }
        }

        private void datetimer_Tick(object sender, EventArgs e)
        {
            datetodaylbl.Text = DateTime.Now.ToShortDateString();
           
        }
        public void clearcheckregular()
        {
            txt_reason.Clear();
            check_onhold.Checked = false;

        }

        private void changeVoiceButton_Click(object sender, EventArgs e)
        {

        }

        public void clearregular()
        {
            txtdate.Clear();
            txtnumber.Clear();
            txtlane.Clear();
            txtcategory.Clear();
            txttable.Clear();
            txt_information.Clear();
            txtsurname.Clear();

        }
        public void clearexpress()
        {
            txtexpressdate.Clear();
            txtexpressselectedno.Clear();
            txtexpresslane.Clear();
            txtexpresstableno.Clear();
            txtexpresscategory.Clear();
            txt_priorinformation.Clear();
            txtsurnameprio.Clear();

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                if (btn_add.Text == "DONE")
                {
                    if (datagridregular.Rows.Count == 0)
                    {
                        MessageBox.Show("There is nothing here.");
                    }
                    else if (txtnumber.Text == "")
                    {
                        MessageBox.Show("Please select data confirm.");
                    }
                    else if (txttable.Text == "None")
                    {
                        MessageBox.Show("Please call the number first before confirming.");
                    }
                    else if (txtnumber.Text == "")
                    {
                        MessageBox.Show("All data are confirmed or there is no data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txt_information.Text == "Not Displayed" || txt_information.Text == "")
                    {
                        MessageBox.Show("Please call and display this number first before confirming.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (MessageBox.Show("Are you sure you want to move this data to confirmed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        con.Open();

                            MySqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "insert into done_db (Date,Lane,Category,Number,TableNumber) values ('" + txtdate.Text + "','" + txtlane.Text + "','" + txtcategory.Text + "','" + txtnumber.Text + "','" + txttable.Text + "')";
                            cmd1.ExecuteNonQuery();

                            MySqlCommand cmd = con.CreateCommand();
                            cmd.CommandText = "delete from db_confirmed WHERE Date = '" + txtdate.Text + "' and  Number='" + txtnumber.Text + "' and Lane = '" + txtlane.Text + "' ";
                            cmd.ExecuteNonQuery();


                            MySqlCommand cmd2 = con.CreateCommand();
                            cmd2.CommandText = "delete from db_extended WHERE Date = '" + txtdate.Text + "' and  Number='" + txtnumber.Text + "' and Lane = '" + txtlane.Text + "' ";
                            cmd2.ExecuteNonQuery();



                        con.Close();




                        MessageBox.Show("Data confirmed thank you!", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     



                            regularandexpressconfirmed();


                            postregularlane();
                            top2regularlane();


                            postexpresslane();
                            top2expresslane();


                            done();


                            clearregular();

                            datagridregular.ClearSelection();
                            datagridexpress.ClearSelection();


                            //  _bgWorker.RunWorkerAsync();
                            /*
                                if (datagridregular.Rows.Count == 0)
                                {

                                }
                                else
                                {
                                    _bgWorker.RunWorkerAsync();
                                }


                                */
                    
                    }



                }
                else if (btn_add.Text == "Hold")
                {


                    if (datagridregular.Rows.Count == 0)
                    {
                        MessageBox.Show("There is nothing here.");
                    }


                    else if (txtnumber.Text == "")
                    {
                        MessageBox.Show("Please select data you want to put in OnHold.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txt_reason.Text == "")
                    {
                        MessageBox.Show("Please input reason first before putting in OnHold.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_reason.Focus();
                    }

                    else if (txttable.Text == "None")
                    {
                        MessageBox.Show("Please call the number first before holding.");
                    }
                    else if (MessageBox.Show("Are you sure you want to put this data on hold?", "Onhold", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                       
                            MySqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "insert into db_onhold (Date,Number,Lane,Category,Surname,TableNo,Status) values ('" + txtdate.Text + "','" + txtnumber.Text + "','" + txtlane.Text + "','" + txtcategory.Text + "','" + txtsurname.Text + "','" + txttable.Text + "','" + txt_reason.Text + "')";
                            cmd1.ExecuteNonQuery();

                            MySqlCommand cmd = con.CreateCommand();
                            cmd.CommandText = "delete from db_confirmed WHERE Date = '" + txtdate.Text + "' and  Number='" + txtnumber.Text + "' and Lane = '" + txtlane.Text + "' ";
                            cmd.ExecuteNonQuery();


                        MySqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandText = "delete from db_extended WHERE Date = '" + txtdate.Text + "' and  Number='" + txtnumber.Text + "' and Lane = '" + txtlane.Text + "' ";
                        cmd2.ExecuteNonQuery();



                        MessageBox.Show("Data out on hold thank you!", "Hold", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // txt_number.Text = "0";

                        con.Close();

                            /*
                            clear();
                            onhold();
                            post();
                            datetimer.Start();
                            */

                            // display();


                            regularandexpressconfirmed();


                            postregularlane();
                            top2regularlane();


                            postexpresslane();
                            top2expresslane();


                            done();


                            clearregular();

                            datagridregular.ClearSelection();
                            datagridexpress.ClearSelection();

                            clearcheckregular();



                       
                    }

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


        
        private void btn_repeat_Click(object sender, EventArgs e)
        {
            if (txt_number.Text == "0")
            {
                MessageBox.Show("All numbers are served");
            }
            else if (txtnumber.Text == "")
            {
                MessageBox.Show("Please select data to call.");
            }
            else
            {
                try
                {
            
                    con.Open();
                    int i = 0;
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    //cmd.CommandText = "select * from db_confirmed WHERE Lane='" + txtlane.Text + "' AND TableNo='" + txttable.Text + "'AND  Information='" + "Displayed" + "'";
                    cmd.CommandText = "select * from db_confirmed WHERE Lane='" + txtlane.Text + "' AND TableNo='" + txttable.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());
                    con.Close();
                    if (i == 0)
                    {




                      
                            ////Updating information
                            con.Open();
                            MySqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "update db_confirmed SET Information = '" + "Displayed" + "' WHERE TableNo='" + txttable.Text + "' AND Category='" + txtcategory.Text + "' AND Number='" + txtnumber.Text + "' ";
                            cmd1.ExecuteNonQuery();
                            txt_information.Text = "Displayed";
                            con.Close();

                            /////////displaying in extended form
                            con.Open();
                            MySqlCommand cmd2 = con.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = "insert into db_extended (Date,Number,Lane,Category,Surname,TableNo) values ('" + txtdate.Text + "','" + txtnumber.Text + "','" + txtlane.Text + "','" + txtcategory.Text + "','" + txtsurname.Text + "','" + txttable.Text + "')";
                            cmd2.ExecuteNonQuery();
                            con.Close();





                            //// Number caller here.
                            con.Open();
                            MySqlCommand cmd3 = con.CreateCommand();
                            cmd3.CommandType = CommandType.Text;
                            cmd3.CommandText = "update db_callerservice SET CallerStatus = '" + "CALLING..." + "', Number = '" + txtnumber.Text + "',TableNumber = '" + txttable.Text + "',Lane = '" + txtlane.Text + "'";
                            cmd3.ExecuteNonQuery();
                            con.Close();
                        caller();
                        
                        // Reset progress bar to zero
                        progressbartimer.Start(); // Start the timer to increment progress
                         
                            // Simulate loading by incrementing the progress bar
                            progressbartimer.Tick += (s, args) =>
                            {
                                if (progressBar1.Value < progressBar1.Maximum)
                                {
                                    progressBar1.Value++;
                                    
                                }
                                else
                                {
                                    progressbartimer.Stop(); // Stop the timer when loading is complete
                                                   // MessageBox.Show("Loading complete!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             
                                    progressBar1.Value = 0;
                                    _bgWorker.RunWorkerAsync();

                                }
                            };

                        
                    }
                    else
                    {
                    
                        MessageBox.Show("There is number on your table still not yet confirmed, please display and confirm this data before proceeding to other number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows.Count == 0)
                {
                    MessageBox.Show("There is nothing to delete here.");
                }
                else
                {
                    //DELETE USERS FROM DATABASE.
                    if (MessageBox.Show("Are you sure you want to delete or clear this table?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        con.Open();


                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "delete from done_db WHERE Date='" + DateTime.Now.ToString("yyyy-MM-dd") + "' ";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Table cleared");
                        done();

                      
                        
                    }
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


        public void savemissed()
        {
            //////// IF DATE CHANGE RESET TO ZERO ANG COUNTING
            //// Priority LANE
            ///
            //con.Close();
            con.Open();
            MySqlCommand cmd5 = con.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "select * from db_confirmed WHERE Date='" + DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + "'";
            cmd5.ExecuteNonQuery();
            DataTable dt5 = new DataTable();
            MySqlDataAdapter da5 = new MySqlDataAdapter(cmd5);
            da5.Fill(dt5);
            foreach (DataRow dr in dt5.Rows)
            {


                var previousdate = DateTime.Parse(dr["Date"].ToString());
                var now = DateTime.Parse(DateTime.Now.ToShortDateString());

                if (now > previousdate)
                {

                    MySqlCommand cmd0 = con.CreateCommand();
                    cmd0.CommandType = CommandType.Text;
                    cmd0.CommandText = "insert into db_missed (Date,Number,Lane,Category,TableNo)values ('" + dr["Date"].ToString() + "','" + dr["Number"].ToString() + "','" + dr["Lane"].ToString() + "','" + dr["Category"].ToString() + "','" + dr["TableNo"].ToString() + "')";
                    cmd0.ExecuteNonQuery();


                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "delete from db_confirmed WHERE Date = '" + DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + "'";
                    cmd1.ExecuteNonQuery();

                }



            }
            con.Close();

        }
        void _bgWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            if (_iNeedToCloseAfterBgWorker)
                Close();
        }

        public void caller()
        {
            try
            {
         
            con.Open();
            // Access button_add here
            lblcaller.Invoke((MethodInvoker)delegate {

        
            ///// REGULAR LANE TABLE
         
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from db_callerservice ";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {


                    lblcaller.Text = dr["CallerStatus"].ToString();
                    lblnumber.Text = dr["Number"].ToString();
                    lbltblnumber.Text = dr["TableNumber"].ToString();
                    lbllane.Text = dr["Lane"].ToString();


                }
            con.Close();
            
            });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //disable();

                //lblconstatus.Invoke((MethodInvoker)delegate {
                //    lblconstatus.Text = "Connection lost, Reconnecting.......... ";
                //});



            }
            finally
            {

            }

        }
        void _bgWorker2_DoWork(object sender, DoWorkEventArgs e)
        {



            // display();
            regularandexpressconfirmed();///// DETECTION IF CONNECTION IS OPEN HERE---- >>>  CHANGE TEXT COLOR ALSO


            postregularlane();
            top2regularlane();



            postexpresslane();
            top2expresslane();


            done();
            rankings();

          
            //savemissed();
            // missed();

            Thread.Sleep(100);

        }


        public void disable()
        {
            if (gb_regular.IsHandleCreated)
            {
                gb_regular.Invoke((MethodInvoker)delegate {

                    gb_regular.Enabled = false;
                });
            }
            else
            {
                // Handle the scenario where the control's handle is not yet created
                // You can choose to delay the operation or perform alternative actions
            }




            if (gb_express.IsHandleCreated)
            {
                gb_express.Invoke((MethodInvoker)delegate {

                    gb_express.Enabled = false;
                });
            }
            else
            {
                // Handle the scenario where the control's handle is not yet created
                // You can choose to delay the operation or perform alternative actions
            }




            if (gb_served.IsHandleCreated)
            {
                gb_served.Invoke((MethodInvoker)delegate {

                    gb_served.Enabled = false;
                });
            }
            else
            {
                // Handle the scenario where the control's handle is not yet created
                // You can choose to delay the operation or perform alternative actions
            }



            if (pic_check.IsHandleCreated)
            {
                pic_check.Invoke((MethodInvoker)delegate {

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
                pic_loading.Invoke((MethodInvoker)delegate {

                    pic_loading.Visible = true;
                });



            }
            else
            {
                // Handle the scenario where the control's handle is not yet created
                // You can choose to delay the operation or perform alternative actions
            }



            if (gb_served.IsHandleCreated)
            {
                gb_served.Invoke((MethodInvoker)delegate {

                    gb_served.Enabled = false;
                });



            }
            else
            {
                // Handle the scenario where the control's handle is not yet created
                // You can choose to delay the operation or perform alternative actions
            }



            if (gb_missed.IsHandleCreated)
            {
                gb_missed.Invoke((MethodInvoker)delegate {

                    gb_missed.Enabled = false;
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
            gb_regular.Invoke((MethodInvoker)delegate {

                gb_regular.Enabled = true;
            });


            gb_express.Invoke((MethodInvoker)delegate {

                gb_express.Enabled = true;
            });

            gb_served.Invoke((MethodInvoker)delegate {

                gb_served.Enabled = true;
            });

            lblconstatus.Invoke((MethodInvoker)delegate {

                lblconstatus.ForeColor = Color.SeaGreen;
                lblconstatus.Text = "Connection Secured.";
            });

            pic_check.Invoke((MethodInvoker)delegate {

                pic_check.Visible = true;
            });


            pic_loading.Invoke((MethodInvoker)delegate {

                pic_loading.Visible = false;
            });

            gb_served.Invoke((MethodInvoker)delegate {

                gb_served.Enabled = true;
            });


            gb_missed.Invoke((MethodInvoker)delegate {

                gb_missed.Enabled = true;
            });
        }



        public void rankings()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT TableNumber, COUNT(TableNumber) AS 'Total' from done_db GROUP BY TableNumber ORDER BY Total DESC";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                dg_rankings.Invoke((MethodInvoker)delegate {
                    dg_rankings.DataSource = dt;
                    da.Fill(dt);
                });
               

   
              


                dg_rankings.ClearSelection();

                con.Close();


            }
           catch (Exception)
            {
               //disable();

           }
           finally
           {

           }




        }
        private void datagridtimer_Tick(object sender, EventArgs e)
        {
            try
            {
              

                _bgWorker2.RunWorkerAsync();

                // enable();



            }
            catch (Exception)
            {

                // timer_confirmed.Stop();      // Access button_add here
                //  lblconstatus.Text = "An error occurred: " + ex.Message;



            }
            finally
            {

            }





            if (datagridregular.Rows.Count == 0)
            {
                txtdate.Clear();
                txtnumber.Clear();
                txtlane.Clear();
                txtcategory.Clear();
                txttable.Clear();


                txt_number.Text = "0";
            }

            if (datagridexpress.Rows.Count == 0)
            {
                txtexpressdate.Clear();
                txtexpressselectedno.Clear();
                txtexpresslane.Clear();
                txtexpresstableno.Clear();
                txtexpresscategory.Clear();

                txtexpressnumbertop.Text = "0";
            }
        }

        private void btn_extend_Click(object sender, EventArgs e)
        {
          


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void datagridregular_MouseHover(object sender, EventArgs e)
        {
            datagridtimer.Stop();
            lblstatus.Text = "Auto refresh stopped.";
            lblstatus.ForeColor = Color.Crimson;
        }

        private void datagridregular_MouseLeave(object sender, EventArgs e)
        {
            datagridtimer.Start();
            lblstatus.Text = "Auto refresh start.";
            lblstatus.ForeColor = Color.SeaGreen;
        }

        private void datagridexpress_MouseHover(object sender, EventArgs e)
        {
            datagridtimer.Stop();
            lblstatus.Text = "Auto refresh stopped.";
            lblstatus.ForeColor = Color.Crimson;
        }

        private void datagridexpress_MouseLeave(object sender, EventArgs e)
        {
            datagridtimer.Start();
            lblstatus.Text = "Auto refresh start.";
            lblstatus.ForeColor = Color.SeaGreen;
        }

        private void btnrepeatexpress_Click(object sender, EventArgs e)
        {
            if (txtexpressnumbertop.Text == "0")
            {
                MessageBox.Show("All numbers are served");
            }
            else if (txtexpressselectedno.Text == "")
            {
                MessageBox.Show("Please select data to call.");
            }
            else
            {
                try
                {
                    con.Open();
                    int i = 0;
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    //cmd.CommandText = "select * from db_confirmed WHERE Lane='" + txtexpresslane.Text + "' AND TableNo='" + txtexpresstableno.Text + "'AND  Information='" + "Displayed" + "'";
                    cmd.CommandText = "select * from db_confirmed WHERE Lane='" + txtexpresslane.Text + "' AND TableNo='" + txtexpresstableno.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());
                    con.Close();
                    if (i == 0)
                    {

                     


                        con.Open();
                        MySqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "update db_confirmed SET Information = '" + "Displayed" + "' WHERE TableNo='" + txtexpresstableno.Text + "' AND Category='" + txtexpresscategory.Text + "' AND Number='" + txtexpressselectedno.Text + "'";
                        cmd1.ExecuteNonQuery();
                        txt_priorinformation.Text = "Displayed";
                        con.Close();


                            /////////displaying in extended form express
                            con.Open();
                            MySqlCommand cmd2 = con.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = "insert into db_extended (Date,Number,Lane,Category,Surname,TableNo) values ('" + txtexpressdate.Text + "','" + txtexpressselectedno.Text + "','" + txtexpresslane.Text + "','" + txtexpresscategory.Text + "','" + txtsurnameprio.Text + "','" + txtexpresstableno.Text + "')";
                            cmd2.ExecuteNonQuery();
                            con.Close();




                       


                            con.Open();
                            MySqlCommand cmd3 = con.CreateCommand();
                            cmd3.CommandType = CommandType.Text;
                            cmd3.CommandText = "update db_callerservice SET CallerStatus = '" + "CALLING..." + "', Number = '" + txtexpressselectedno.Text + "',TableNumber = '" + txtexpresstableno.Text + "', Lane = '" + txtexpresslane.Text + "'";
                            cmd3.ExecuteNonQuery();
                            con.Close();
                        caller();
                        // Reset progress bar to zero
                        progressbartimer.Start(); // Start the timer to increment progress
                            // Simulate loading by incrementing the progress bar
                            progressbartimer.Tick += (s, args) =>
                            {
                                if (progressBar1.Value < progressBar1.Maximum)
                                {
                                    progressBar1.Value++;
                               
                                }
                                else
                                {

                                    progressbartimer.Stop(); // Stop the timer when loading is complete
                                    progressBar1.Value = 0;

                                    _bgWorker1.RunWorkerAsync();



                                }
                            };


                     


                        
                    }
                    else
                    {
                       
                        MessageBox.Show("There is number on your table still not yet confirmed, please display and confirm this data before proceeding to other number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void check_onhold_CheckedChanged(object sender, EventArgs e)
        {
            if (check_onhold.Checked == true)
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

                btn_add.Text = "DONE";
                btn_add.BackColor = Color.SeaGreen;
            }
        }

        private void checkexpress_CheckedChanged(object sender, EventArgs e)
        {
            if (checkexpress.Checked == true)
            {
                lblexpressreason.Visible = true;
                txtexpressreason.Visible = true;

                btnconfirmexpress.Text = "Hold";
                btnconfirmexpress.BackColor = Color.DarkCyan;
                txtexpressreason.Focus();
            }
            else
            {
                lblexpressreason.Visible = false;
                txtexpressreason.Visible = false;

                btnconfirmexpress.Text = "DONE";
                btnconfirmexpress.BackColor = Color.SeaGreen;
            }
        }
        public void clearcheckexpress()
        {
            checkexpress.Checked = false;
            txtexpressreason.Clear();
        }
        private void btnconfirmexpress_Click(object sender, EventArgs e)
        {
            try
            {

                if (btnconfirmexpress.Text == "DONE")
                {
                    if (datagridexpress.Rows.Count == 0)
                    {
                        MessageBox.Show("There is nothing here.");
                    }
                    else if (txtexpresstableno.Text == "None")
                    {
                        MessageBox.Show("Please call the number first before confirming.");
                    }
                    else if (txtexpressselectedno.Text == "")
                    {
                        MessageBox.Show("Please select data confirm.");
                    }
                    else if (txtexpressnumbertop.Text == "")
                    {
                        MessageBox.Show("Please select data you want to Confirm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txt_priorinformation.Text == "Not Displayed" || txt_priorinformation.Text == "")
                    {
                        MessageBox.Show("Please call and display this number first before confirming.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (MessageBox.Show("Are you sure you want to move this data to confirmed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        con.Open();
                       
                            MySqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "insert into done_db (Date,Lane,Category,Number,TableNumber) values ('" + txtexpressdate.Text + "','" + txtexpresslane.Text + "','" + txtexpresscategory.Text + "','" + txtexpressselectedno.Text + "','" + txtexpresstableno.Text + "')";
                            cmd1.ExecuteNonQuery();

                            MySqlCommand cmd = con.CreateCommand();
                            cmd.CommandText = "delete from db_confirmed WHERE Date = '" + txtexpressdate.Text + "' and  Number='" + txtexpressselectedno.Text + "' and Lane = '" + txtexpresslane.Text + "' ";
                            cmd.ExecuteNonQuery();


                            MySqlCommand cmd2 = con.CreateCommand();
                            cmd2.CommandText = "delete from db_extended WHERE Date = '" + txtexpressdate.Text + "' and  Number='" + txtexpressselectedno.Text + "' and Lane = '" + txtexpresslane.Text + "' ";
                            cmd2.ExecuteNonQuery();




                        con.Close();



                        MessageBox.Show("Data confirmed thank you!", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       

                            regularandexpressconfirmed();


                            postregularlane();
                            top2regularlane();


                            postexpresslane();
                            top2expresslane();


                            done();



                            clearexpress();
                            datagridregular.ClearSelection();
                            datagridexpress.ClearSelection();


                            /*
                            if (datagridexpress.Rows.Count == 0)
                            {

                            }
                            else
                            {
                                _bgWorker1.RunWorkerAsync();
                            }
                            */

                       


                    }



                }
                else if (btnconfirmexpress.Text == "Hold")
                {


                    if (datagridexpress.Rows.Count == 0)
                    {
                        MessageBox.Show("There is nothing here.");
                    }
                    else if (txtexpressnumbertop.Text == "")
                    {
                        MessageBox.Show("Please select data you want to put in OnHold.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (txtexpressreason.Text == "")
                    {
                        MessageBox.Show("Please input reason first before putting in OnHold.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtexpressreason.Focus();
                    }

                    else if (txtexpresstableno.Text == "None")
                    {
                        MessageBox.Show("Please call the number first before Holding.");
                    }

                    else if (MessageBox.Show("Are you sure you want to put this data on hold?", "Onhold", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        con.Open();
                            MySqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "insert into db_onhold (Date,Number,Lane,Category,Surname,TableNo,Status) values ('" + txtexpressdate.Text + "','" + txtexpressnumbertop.Text + "','" + txtexpresslane.Text + "','" + txtexpresscategory.Text + "','" + txtsurnameprio.Text + "','" + txtexpresstableno.Text + "','" + txtexpressreason.Text + "')";
                            cmd1.ExecuteNonQuery();

                            MySqlCommand cmd = con.CreateCommand();
                            cmd.CommandText = "delete from db_confirmed WHERE Date = '" + txtexpressdate.Text + "' and  Number='" + txtexpressselectedno.Text + "' and Lane = '" + txtexpresslane.Text + "' ";
                            cmd.ExecuteNonQuery();


                        MySqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandText = "delete from db_extended WHERE Date = '" + txtexpressdate.Text + "' and  Number='" + txtexpressselectedno.Text + "' and Lane = '" + txtexpresslane.Text + "' ";
                        cmd2.ExecuteNonQuery();


                        con.Close();
                        MessageBox.Show("Data put on hold", "Onhold", MessageBoxButtons.OK, MessageBoxIcon.Information);
              

                   

                      

                            regularandexpressconfirmed();


                            postregularlane();
                            top2regularlane();


                            postexpresslane();
                            top2expresslane();


                            done();

                            clearexpress();

                            clearcheckexpress();
                            datagridregular.ClearSelection();
                            datagridexpress.ClearSelection();




                    }
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmExtended fe = new frmExtended();
            fe.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void datagridregular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
                con.Open();

                int i = Convert.ToInt32(datagridregular.SelectedCells[0].Value.ToString());
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
                    txtsurname.Text = dr["Surname"].ToString();
                    txttable.Text = dr["TableNo"].ToString();
                    txt_information.Text = dr["Information"].ToString();
                    //txtstatcomplete.Text = dr["Status"].ToString();

                }

                con.Close();

            }
            catch (Exception ex)
            {

                lblconstatus.Invoke((MethodInvoker)delegate {
                    // Access button_add here
                    lblconstatus.Text = "An error occured: " + ex.Message;
                });
            }
        }

        private void datagridexpress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                con.Open();



                int i = Convert.ToInt32(datagridexpress.SelectedCells[0].Value.ToString());
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from db_confirmed where id=" + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtexpressdate.Text = dr["Date"].ToString();
                    txtexpressselectedno.Text = dr["Number"].ToString();
                    txtexpresslane.Text = dr["Lane"].ToString();
                    txtexpresscategory.Text = dr["Category"].ToString();
                    txtsurnameprio.Text = dr["Surname"].ToString();
                    txtexpresstableno.Text = dr["TableNo"].ToString();
                    txt_priorinformation.Text = dr["Information"].ToString();
                    //txtstatcomplete.Text = dr["Status"].ToString();

                }

                con.Close();

            }
            catch (Exception ex)
            {

                lblconstatus.Invoke((MethodInvoker)delegate {
                    // Access button_add here
                    lblconstatus.Text = "An error occured: " + ex.Message;
                });
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btn_updateandconfirm_Click(object sender, EventArgs e)


        {

           

          
            if (btn_updateandconfirm.Text == "Done")
            {
                lblstatus.Text = "Auto refresh start.";
                lblstatus.ForeColor = Color.SeaGreen;
                if (rb_socialworker.Checked == true)
                {

              
                if (tablenumbercmb.Text == "")
                {
                    MessageBox.Show("Please select your table number", "Select Table Number", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                        try
                        { 
                        // display();
                        regularandexpressconfirmed();///// DETECTION IF CONNECTION IS OPEN HERE---- >>>  CHANGE TEXT COLOR ALSO



                        postregularlane();
                        top2regularlane();



                        postexpresslane();
                        top2expresslane();


                        done();
                            rankings();
                            missed();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("an error occured please try again: ", ex.Message);
                        }
                        finally
                        {

                        }


                        btn_updateandconfirm.BackColor = Color.DarkGoldenrod;
                        datagridtimer.Start();

                    groupBox1.Enabled = false;
                    gb_regular.Enabled = true;
                    gb_express.Enabled = true;
                        dg_rankings.Enabled = true;

                        btn_updateandconfirm.Text = "Update";


                      







                    }

                }
                else if (rb_numbercaller.Checked == true)
                {
                    try
                    {

                        // display();
                        regularandexpressconfirmed();///// DETECTION IF CONNECTION IS OPEN HERE---- >>>  CHANGE TEXT COLOR ALSO



                        postregularlane();
                        top2regularlane();



                        postexpresslane();
                        top2expresslane();


                        done();
                        rankings();
                        missed();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("an error occured please try again: ",ex.Message);
                    }
                    finally
                    {

                    }



                    btn_updateandconfirm.BackColor = Color.DarkGoldenrod;
                    datagridtimer.Start();

                    groupBox1.Enabled = false;
                    gb_regular.Enabled = true;
                    gb_express.Enabled = true;
                    dg_rankings.Enabled = true;

                    btn_updateandconfirm.Text = "Update";
                }

            }
            else if (btn_updateandconfirm.Text == "Update")
            {


                lblstatus.Text = "Auto refresh stopped.";
                lblstatus.ForeColor = Color.Crimson;


                if (rb_socialworker.Checked == true)
                {

              
                if (tablenumbercmb.Text == "")
                {
                    MessageBox.Show("Please select your table number", "Select Table Number", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    btn_updateandconfirm.BackColor = Color.SeaGreen;
                    datagridtimer.Stop();
                    btn_updateandconfirm.Text = "Done";
                    groupBox1.Enabled = true;
                    gb_regular.Enabled = false;
                    gb_express.Enabled = false;
                    gb_served.Enabled = false;
                    gb_missed.Enabled = false;
                    datagridexpress.DataSource = null;
                    datagridregular.DataSource = null;
                    dataGridView2.DataSource = null;
                    dg_missed.DataSource = null;
                    dg_rankings.DataSource = null;
                    clearregular();
                    clearexpress();

                }

                }
                else if(rb_numbercaller.Checked == true)
                {
                    btn_updateandconfirm.BackColor = Color.SeaGreen;
                    datagridtimer.Stop();
                    btn_updateandconfirm.Text = "Done";
                    groupBox1.Enabled = true;
                    gb_regular.Enabled = false;
                    gb_express.Enabled = false;
                    gb_served.Enabled = false;
                    gb_missed.Enabled = false;
                    datagridexpress.DataSource = null;
                    datagridregular.DataSource = null;
                    dataGridView2.DataSource = null;
                    dg_missed.DataSource = null;
                    dg_rankings.DataSource = null;
                    clearregular();
                    clearexpress();
                }



            }
        }

        private void rb_socialworker_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_socialworker.Checked == true)
            {
                lbltableno.Visible = true;
                tablenumbercmb.Visible = true;
            }
            else
            {
                lbltableno.Visible = false;
                tablenumbercmb.Visible = false;
            }
        }

        private void rb_numbercaller_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_socialworker.Checked == true)
            {
                lbltableno.Visible = true;
                tablenumbercmb.Visible = true;
                btnconfirmexpress.Enabled = true;
                btn_add.Enabled = true;
            }
            else if(rb_numbercaller.Enabled == true)
            {
                lbltableno.Visible = false;
                tablenumbercmb.Visible = false;
                btnconfirmexpress.Enabled = false;
                btn_add.Enabled = false;    
            }
        }

        private void dataGridView2_MouseHover(object sender, EventArgs e)
        {
            datagridtimer.Stop();
            lblstatus.Text = "Auto refresh stopped.";
            lblstatus.ForeColor = Color.Crimson;

        }

        private void dataGridView2_MouseLeave(object sender, EventArgs e)
        {
            datagridtimer.Start();
            lblstatus.Text = "Auto refresh start.";
            lblstatus.ForeColor = Color.SeaGreen;
        }

        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            datagridtimer.Stop();
            lblstatus.Text = "Auto refresh stopped.";
            lblstatus.ForeColor = Color.Crimson;
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            datagridtimer.Start();
            lblstatus.Text = "Auto refresh start.";
            lblstatus.ForeColor = Color.SeaGreen;
        }

        private void dg_rankings_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0 && e.ColumnIndex >= 0)
            {
                // Apply color to the top row cells
                e.CellStyle.BackColor = Color.SeaGreen;
                e.CellStyle.ForeColor = Color.White;
            }

            if (e.RowIndex == 1 && e.ColumnIndex >= 0)
            {
                // Apply color to the top row cells
                e.CellStyle.BackColor = Color.DarkCyan;
                e.CellStyle.ForeColor = Color.Black;
            }

            if (e.RowIndex == 2 && e.ColumnIndex >= 0)
            {
                // Apply color to the top row cells
                e.CellStyle.BackColor = Color.Yellow;
                e.CellStyle.ForeColor = Color.Black;
            }

        }

        private void datagridregular_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == this.datagridregular.Columns["Information"].Index)
                {

                    string Status = e.Value.ToString();

                    if (Status != null)
                    {

                        if (Status == "Not Displayed")
                        {

                            this.datagridregular.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Black;
                            this.datagridregular.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;

                        }

                        else if (Status == "Displayed")
                        {

                            this.datagridregular.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                            this.datagridregular.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

                        }


                    }

                }

            }
            catch (Exception)
            {
            }
        }

        private void datagridexpress_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == this.datagridexpress.Columns["Information"].Index)
                {

                    string Status = e.Value.ToString();

                    if (Status != null)
                    {

                        if (Status == "Not Displayed")
                        {

                            this.datagridexpress.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Black;
                            this.datagridexpress.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;

                        }

                        else if (Status == "Displayed")
                        {

                            this.datagridexpress.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                            this.datagridexpress.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

                        }


                    }

                }

            }
            catch (Exception)
            {
            }
        }

        private void progressbartimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblcaller.Text == "CALLING...")
            {
                btn_repeat.Enabled = false;
                btnrepeatexpress.Enabled = false;
            }
            else
            {
                btn_repeat.Enabled = true;
                btnrepeatexpress.Enabled = true;
            }
        }
    }
}
