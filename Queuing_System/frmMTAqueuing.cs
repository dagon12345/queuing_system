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
    public partial class frmMTAqueuing : Form
    {
        ConnectionString cs = new ConnectionString();
        MySqlConnection con = null;

        private SpVoice voice;
        public frmMTAqueuing()
        {
            InitializeComponent();
        }

        BackgroundWorker _bgWorker;
        BackgroundWorker _bgWorker1;
        BackgroundWorker _bgWorker2;


        bool _iNeedToCloseAfterBgWorker;

        void _bgWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            //btn_add.Enabled = true;
            btnrepeatexpress.Enabled = true;
            btnconfirmexpress.Enabled = true;
            if (_iNeedToCloseAfterBgWorker)
                Close();
        }

        string combo2;


        void _bgWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            /*
            comboBox1.Invoke((MethodInvoker)delegate {
                // Access comboBox1 here
                combo2 = comboBox2.Text;
            });
            */

            btn_repeat.Invoke((MethodInvoker)delegate {
                // Access button here
                btnrepeatexpress.Enabled = false;
            });


            btn_add.Invoke((MethodInvoker)delegate {
                // Access button here
                btnconfirmexpress.Enabled = false;
            });



            // Do long lasting work
            Thread.Sleep(1000);



            if (txtexpressselectedno.Text.Trim().Length > 0)
            {
                SpVoice obj = new SpVoice();
                obj.Speak(label10.Text + txtexpressselectedno.Text + label9.Text, SpeechVoiceSpeakFlags.SVSFDefault);   
            }


        }



        void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            //btn_add.Enabled = true;
            btn_repeat.Enabled = true;
            btn_add.Enabled = true;
            if (_iNeedToCloseAfterBgWorker)
                Close();
        }

        string combo;
        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            /*
            comboBox1.Invoke((MethodInvoker)delegate {
                // Access comboBox1 here
                combo = comboBox1.Text;
            });
            */


            btn_repeat.Invoke((MethodInvoker)delegate {
                // Access button here
                btn_repeat.Enabled = false;
            });


            btn_add.Invoke((MethodInvoker)delegate {
                // Access button here
                btn_add.Enabled = false;
            });



            // Do long lasting work
            Thread.Sleep(1000);



            if (txtnumber.Text.Trim().Length > 0)
            {
                SpVoice obj = new SpVoice();
                obj.Speak(label5.Text + txtnumber.Text + label1.Text, SpeechVoiceSpeakFlags.SVSFDefault);

            }


        }

        public void regularandexpressconfirmed()
        {
            try
            {

                    con.Open();


                    enable();


                    ///// REGULAR LANE TABLE
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from db_MTAnumber WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "' ORDER BY Number ASC";
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
                        datagridregular.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    });



                    ///// EXPRESS LANE TABLE
                    MySqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select * from db_MTAnumber WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "PRIORITY LANE" + "' ORDER BY Number ASC";
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
                        datagridexpress.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    });

                    //btn_add.Enabled = false;

                con.Close();

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

        void _bgWorker2_DoWork(object sender, DoWorkEventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("an error occured please try again: ", ex.Message);
            }
            finally
            {

            }






            // done();

            Thread.Sleep(100);

        }

        private void frmMTAqueuing_Load(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(cs.DBcon);

                // display();


                regularandexpressconfirmed();///// DETECTION IF CONNECTION IS OPEN HERE---- >>>  CHANGE TEXT COLOR ALSO
                postregularlane();
                top2regularlane();
                postexpresslane();
                top2expresslane();
                done();





                datetimer.Start();
                voice = new SpVoice();
                datagridtimer.Start();






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


        public void done()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from db_doneMTA WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY id DESC";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                dataGridView2.Invoke((MethodInvoker)delegate {

                    dataGridView2.DataSource = dt;
                    da.Fill(dt);
                    this.dataGridView2.Columns["id"].Visible = false;
                    dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                });
                con.Close();

            }
            catch (Exception ex)
            {
                disable();

            }
            finally
            {

            }

        }


        public void display()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from db_MTAnumber WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
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


        //public void done()
        //{
        //    try
        //    {
        //        con.Open();
        //        MySqlCommand cmd = con.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "select * from done_db WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY id DESC";
        //        cmd.ExecuteNonQuery();
        //        DataTable dt = new DataTable();
        //        MySqlDataAdapter da = new MySqlDataAdapter(cmd);

        //        dataGridView2.Invoke((MethodInvoker)delegate {

        //            dataGridView2.DataSource = dt;
        //            da.Fill(dt);
        //            this.dataGridView2.Columns["id"].Visible = false;
        //            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //            dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        //        });
        //        con.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        disable();
        //        /*
        //        lblconstatus.Invoke((MethodInvoker)delegate {
        //            // Access button_add here
        //            lblconstatus.Text = "An error occured: " + ex.Message;
        //        });
        //        */

        //    }
        //    finally
        //    {

        //    }

        //}

        public void postexpresslane()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from db_MTAnumber WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "PRIORITY LANE" + "' ORDER BY Number DESC";
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
            catch (Exception ex)
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
                cmd.CommandText = "SELECT Date,Lane,number FROM db_MTAnumber WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "PRIORITY LANE" + "' ORDER BY Number ASC LIMIT 2";
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
            catch (Exception ex)
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
                cmd.CommandText = "select * from db_MTAnumber WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "' ORDER BY Number DESC";
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
            catch (Exception ex)
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
                cmd.CommandText = "SELECT Date,Lane,number FROM db_MTAnumber WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 2";
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

            catch (Exception ex)
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

        public void clearregular()
        {
            txtdate.Clear();
            txtnumber.Clear();
            txtlane.Clear();
            txtcategory.Clear();

        }
        public void clearexpress()
        {
            txtexpressdate.Clear();
            txtexpressselectedno.Clear();
            txtexpresslane.Clear();
            txtexpresscategory.Clear();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

             
                    if (datagridregular.Rows.Count == 0)
                    {
                        MessageBox.Show("There is nothing here.");
                    }
                    else if (txtnumber.Text == "")
                    {
                        MessageBox.Show("Please select data confirm.");
                    }
                    else if (txtnumber.Text == "")
                    {
                        MessageBox.Show("All data are confirmed or there is no data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (MessageBox.Show("Are you sure you want to move this data to confirmed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        con.Open();

                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into db_doneMTA (Date,Lane,Category,Number) values ('" + txtdate.Text + "','" + txtlane.Text + "','" + txtcategory.Text + "','" + txtnumber.Text + "')";
                    cmd1.ExecuteNonQuery();

                    MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "delete from db_MTAnumber WHERE Date = '" + txtdate.Text + "' and  Number='" + txtnumber.Text + "' and Lane = '" + txtlane.Text + "' ";
                        cmd.ExecuteNonQuery();

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


            else if (txt_number.Text.Trim().Length > 0)
            {
                /*
                     txttable.Text = comboBox1.Text;
                     MySqlCommand cmd = con.CreateCommand();
                     cmd.CommandType = CommandType.Text;
                     cmd.CommandText = "update db_confirmed set TableNo = '" + comboBox1.Text + "' where DATE='" + txtdate.Text + "' AND Lane='" + txtlane.Text + "' AND Number='" + txtnumber.Text + "'";
                     cmd.ExecuteNonQuery();

                 */


                _bgWorker.RunWorkerAsync();


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
                        cmd.CommandText = "delete from db_doneMTA WHERE Date='" + DateTime.Now.ToString("yyyy-MM-dd") + "' ";
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
        void _bgWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            if (_iNeedToCloseAfterBgWorker)
                Close();
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


        }

        private void datagridtimer_Tick(object sender, EventArgs e)
        {
            try
            {

                _bgWorker2.RunWorkerAsync();

                // enable();



            }
            catch (Exception ex)
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


                txt_number.Text = "0";
            }

            if (datagridexpress.Rows.Count == 0)
            {
                txtexpressdate.Clear();
                txtexpressselectedno.Clear();
                txtexpresslane.Clear();
                txtexpresscategory.Clear();

                txtexpressnumbertop.Text = "0";
            }


        }

        private void datagridregular_MouseHover(object sender, EventArgs e)
        {
            datagridtimer.Stop();
        }

        private void datagridregular_MouseLeave(object sender, EventArgs e)
        {
            datagridtimer.Start();
        }

        private void datagridexpress_MouseHover(object sender, EventArgs e)
        {
            datagridtimer.Stop();
        }

        private void datagridexpress_MouseLeave(object sender, EventArgs e)
        {
            datagridtimer.Start();
        }

        private void datagridregular_MouseHover_1(object sender, EventArgs e)
        {
            datagridtimer.Stop();
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
            else if (txtexpressnumbertop.Text.Trim().Length > 0)
            {
                /*
                     txtexpresstableno.Text = comboBox2.Text;
                     MySqlCommand cmd = con.CreateCommand();
                     cmd.CommandType = CommandType.Text;
                     cmd.CommandText = "update db_confirmed set TableNo = '" + comboBox2.Text + "' where DATE='" + txtexpressdate.Text + "' AND Lane='" + txtexpresslane.Text + "' AND Number='" + txtexpressselectedno.Text + "'";
                     cmd.ExecuteNonQuery();
                */

                _bgWorker1.RunWorkerAsync();

            }
        }

        private void btnconfirmexpress_Click(object sender, EventArgs e)
        {
            try
            {

                    if (datagridexpress.Rows.Count == 0)
                    {
                        MessageBox.Show("There is nothing here.");
                    }
                    else if (txtexpressselectedno.Text == "")
                    {
                        MessageBox.Show("Please select data confirm.");
                    }
                    else if (txtexpressnumbertop.Text == "")
                    {
                        MessageBox.Show("Please select data you want to Confirm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (MessageBox.Show("Are you sure you want to move this data to confirmed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        con.Open();

                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into db_doneMTA (Date,Lane,Category,Number) values ('" + txtexpressdate.Text + "','" + txtexpresslane.Text + "','" + txtexpresscategory.Text + "','" + txtexpressselectedno.Text + "')";
                    cmd1.ExecuteNonQuery();

                    MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "delete from db_MTAnumber WHERE Date = '" + txtexpressdate.Text + "' and  Number='" + txtexpressselectedno.Text + "' and Lane = '" + txtexpresslane.Text + "' ";
                        cmd.ExecuteNonQuery();
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
            catch (Exception ex)
            {

                MessageBox.Show("An error occured: " + ex.Message);


            }
            finally
            {

            }
        }

        private void datagridregular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                con.Open();

                int i = Convert.ToInt32(datagridregular.SelectedCells[0].Value.ToString());
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from db_MTAnumber where id=" + i + "";
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
                   // txttable.Text = dr["TableNo"].ToString();
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
                cmd.CommandText = "select * from db_MTAnumber where id=" + i + "";
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
                    //txtexpresstableno.Text = dr["TableNo"].ToString();
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

        private void datagridregular_MouseLeave_1(object sender, EventArgs e)
        {
            datagridtimer.Start();
        }

        private void datagridexpress_MouseHover_1(object sender, EventArgs e)
        {
            datagridtimer.Stop();
        }

        private void datagridexpress_MouseLeave_1(object sender, EventArgs e)
        {
            datagridtimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ExtendMTA fe = new frm_ExtendMTA();
            fe.Show();
        }
    }
}
