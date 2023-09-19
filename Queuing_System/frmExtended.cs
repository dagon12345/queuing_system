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
using SpeechLib;

namespace Queuing_System
{
    public partial class frmExtended : Form
    {

        ConnectionString cs = new ConnectionString();
        MySqlConnection con = null;
        public frmExtended()
        {
            InitializeComponent();
        }


        BackgroundWorker _bgWorker;
        bool _iNeedToCloseAfterBgWorker;

        private void frmExtended_Load(object sender, EventArgs e)
        {
            try
            {

                con = new MySqlConnection(cs.DBcon);



                numbertimer.Start();
            }
            catch (Exception ex)
            {
                numbertimer.Stop();
                MessageBox.Show("An error occurred: " + ex.Message);
                this.Close();
            }
            finally
            {

            }

            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += _bgWorker_DoWork;
            _bgWorker.RunWorkerCompleted += _bgWorker_RunWorkerCompleted;

        }

        public void caller()
        {
            // Access button_add here
            lblcaller.Invoke((MethodInvoker)delegate {

                //con.Close();
                ///// REGULAR LANE TABLE
                con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select CallerStatus,Number,TableNumber,Lane from db_callerservice ";
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
        void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            // btn_add.Enabled = true;
            if (_iNeedToCloseAfterBgWorker)
                Close();
        }

        public void listDoneData()
        {
            try
            {

                // Access button_add here
                // con.Close();
                // con.Open();


                con.Open();


                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT * FROM done_db WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY id DESC";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                da1.Fill(dt1);
                datagridConfirmedData.Invoke((MethodInvoker)delegate
                {
                    datagridConfirmedData.DataSource = dt1;
                    this.datagridConfirmedData.Columns["id"].Visible = false;
                    this.datagridConfirmedData.Columns["Date"].Visible = false;
                    this.datagridConfirmedData.Columns["Category"].Visible = false;

                    //datagridConfirmedData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    datagridConfirmedData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //datagridConfirmedData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //datagridConfirmedData.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    datagridConfirmedData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    datagridConfirmedData.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    datagridConfirmedData.ClearSelection();
                });


                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                /*
                 *  disable();
                lblconstatus.Invoke((MethodInvoker)delegate {
                    // Access button_add here
                    lblconstatus.Text = "An error occured: " + ex.Message;
                });*/
            }
            finally
            {

            }

        }

        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do long lasting work


            expressnumber();
            // done();
            //callme();
            //statuschange();


            listDoneData();
            nowserving1();
            nowserving2();
            nowserving3();
            nowServingPriority1();
            nowServingPriority2();
            nowServingPriority3();






            caller();





          

            if (lblcaller.Text == "CALLING...")
            {
                string client = "Client number";
                if (lblnumber.Text.Trim().Length > 0)
                {
                    SpVoice obj = new SpVoice();
                    obj.Speak(label9.Text + client + lblnumber.Text + lbltblnumber.Text + lbllane.Text, SpeechVoiceSpeakFlags.SVSFDefault);

                }

                string client1 = "Client number";
                if (lblnumber.Text.Trim().Length > 0)
                {
                    SpVoice obj = new SpVoice();
                    obj.Speak(label9.Text + client1 + lblnumber.Text + lbltblnumber.Text + lbllane.Text, SpeechVoiceSpeakFlags.SVSFDefault);

                }

            }

            Thread.Sleep(1);



            //print();
        }
        public void nowServingPriority1()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,TableNo from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'AND Lane = '" + "PRIORITY LANE" + "'ORDER BY id DESC LIMIT 1";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {




                    textPriority1.Invoke((MethodInvoker)delegate { textPriority1.Text = dr["Number"].ToString(); });
                    labelPriorityTable1.Invoke((MethodInvoker)delegate { labelPriorityTable1.Text = dr["TableNo"].ToString(); });







                }
                con.Close();
            }
            catch (Exception)
            {
                disable();

                lblconstatus.Invoke((MethodInvoker)delegate {
                    lblconstatus.Text = "Connection lost, Reconnecting.......... ";
                });



            }
            finally
            {

            }
        }
        public void nowServingPriority2()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,TableNo from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'AND Lane = '" + "PRIORITY LANE" + "'ORDER BY id DESC LIMIT 2";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {





                    textPriority2.Invoke((MethodInvoker)delegate { textPriority2.Text = dr["Number"].ToString(); });
                    lblPriorityTable2.Invoke((MethodInvoker)delegate { lblPriorityTable2.Text = dr["TableNo"].ToString(); });
                    lblNowservingPriority2.Invoke((MethodInvoker)delegate { lblNowservingPriority2.Text = "Now Serving"; });



                }
                con.Close();
            }
            catch (Exception)
            {
                disable();

                lblconstatus.Invoke((MethodInvoker)delegate {
                    lblconstatus.Text = "Connection lost, Reconnecting.......... ";
                });



            }
            finally
            {

            }
        }
        public void nowServingPriority3()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,TableNo from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'AND Lane = '" + "PRIORITY LANE" + "'ORDER BY id DESC LIMIT 3";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    
                
              


                    textPriority3.Invoke((MethodInvoker)delegate { textPriority3.Text = dr["Number"].ToString(); });
                    lblPriorityTable3.Invoke((MethodInvoker)delegate { lblPriorityTable3.Text = dr["TableNo"].ToString(); });
                    lblNowservingPriority3.Invoke((MethodInvoker)delegate { lblNowservingPriority3.Text = "Now Serving"; });



                }
                con.Close();
            }
            catch (Exception)
            {
                disable();

                lblconstatus.Invoke((MethodInvoker)delegate {
                    lblconstatus.Text = "Connection lost, Reconnecting.......... ";
                });



            }
            finally
            {

            }
        }

        public void nowserving1()
        {
            try
            {
                con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,TableNo from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'AND Lane = '" + "REGULAR LANE" + "' ORDER BY id DESC LIMIT 1 ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
                      foreach (DataRow dr in dt.Rows)
                      {
                          textNowServing1.Invoke((MethodInvoker)delegate { textNowServing1.Text = dr["Number"].ToString(); });

                          lblTableNumberOne.Invoke((MethodInvoker)delegate { lblTableNumberOne.Text = dr["TableNo"].ToString(); });

                      }
            con.Close();
            }
            catch (Exception)
            {
                disable();
                lblconstatus.Invoke((MethodInvoker)delegate { lblconstatus.Text = "Connection lost, Reconnecting.......... "; });
               
            }
            finally
{

}

        }
        public void nowserving2()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,TableNo from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'AND Lane = '" + "REGULAR LANE" + "'ORDER BY id DESC LIMIT 2";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textNowServing2.Invoke((MethodInvoker)delegate { textNowServing2.Text = dr["Number"].ToString(); });
                    lblTableNumberTwo.Invoke((MethodInvoker)delegate { lblTableNumberTwo.Text = dr["TableNo"].ToString(); });
                    labelNowServing2.Invoke((MethodInvoker)delegate { labelNowServing2.Text = "Now Serving"; });


                }
                con.Close();
            }
            catch (Exception)
            {
                disable();

                lblconstatus.Invoke((MethodInvoker)delegate {
                    lblconstatus.Text = "Connection lost, Reconnecting.......... ";
                });



            }
            finally
            {

            }
        }
        public void nowserving3()
        {
            try 
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,TableNo from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'AND Lane = '"+ "REGULAR LANE" + "' ORDER BY id DESC LIMIT 3";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
                {
                    textNowServing3.Invoke((MethodInvoker)delegate { textNowServing3.Text = dr["Number"].ToString(); });
                    labelTableThird.Invoke((MethodInvoker)delegate { labelTableThird.Text = dr["TableNo"].ToString(); });
                    labelNowServing3.Invoke((MethodInvoker)delegate { labelNowServing3.Text = "Now Serving"; });


  
                  
                  
                    
                }
            //dgextend3.Invoke((MethodInvoker)delegate
            //{
            //    dgextend3.DataSource = dt;
            //    dgextend3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dgextend3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dgextend3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //    dgextend3.ClearSelection();
            //});
            con.Close();
            }
            catch (Exception)
            {
                disable();

                lblconstatus.Invoke((MethodInvoker)delegate {
                    lblconstatus.Text = "Connection lost, Reconnecting.......... ";
                });



            }
            finally
            {

            }

        }
      



        //public void callme()
        //{

        //    try
        //    { 


        //    //REGULAR LANE
        //    if (datagridregular.Rows.Count == 0)
        //    {

        //        txttable.Invoke((MethodInvoker)delegate {

        //            txttable.Text = "All Clients are served.";
        //        });



        //            txt_number.Invoke((MethodInvoker)delegate {

        //                txt_number.Text = "0";
        //            });



        //            lblfirst.Invoke((MethodInvoker)delegate {

        //                lblfirst.Text = "0";
        //            });




        //            lblsecond.Invoke((MethodInvoker)delegate {

        //                lblsecond.Text = "0";
        //            });



        //            lblthird.Invoke((MethodInvoker)delegate {

        //                lblthird.Text = "0";
        //            });

        //            lblforth.Invoke((MethodInvoker)delegate {

        //                lblforth.Text = "0";
        //            });
        //            lblfifth.Invoke((MethodInvoker)delegate {

        //                lblfifth.Text = "0";
        //            });




        //            table1.Invoke((MethodInvoker)delegate {

        //                table1.Text = "TABLE NUMBER HERE";
        //            });


        //            table2.Invoke((MethodInvoker)delegate {

        //                table2.Text = "TABLE NUMBER HERE";
        //            });


        //            table3.Invoke((MethodInvoker)delegate {

        //                table3.Text = "TABLE NUMBER HERE";
        //            });

        //            table4.Invoke((MethodInvoker)delegate {

        //                table4.Text = "TABLE NUMBER HERE";
        //            });
        //            table5.Invoke((MethodInvoker)delegate {

        //                table5.Text = "TABLE NUMBER HERE";
        //            });





        //            txtstatus1.Invoke((MethodInvoker)delegate {

        //                txtstatus1.Text = "STATUS";
        //            });




        //            txtstatus2.Invoke((MethodInvoker)delegate {

        //                txtstatus2.Text = "STATUS";
        //            });


        //            txtstatus3.Invoke((MethodInvoker)delegate {

        //                txtstatus3.Text = "STATUS";
        //            });
        //            txtstatus4.Invoke((MethodInvoker)delegate {

        //                txtstatus4.Text = "STATUS";
        //            });
        //            txtstatus5.Invoke((MethodInvoker)delegate {

        //                txtstatus5.Text = "STATUS";
        //            });



        //        }


        //        ////////////////NOW SERVING

        //        con.Open();
        //    MySqlCommand cmd = con.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select * from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "' ORDER BY Number ASC LIMIT 1";
        //    cmd.ExecuteNonQuery();
        //    DataTable dt = new DataTable();
        //    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    datagridregular.DataSource = dt;
        //    foreach (DataRow dr in dt.Rows)
        //    {

        //            txt_number.Invoke((MethodInvoker)delegate {

        //                txt_number.Text = dr["Number"].ToString();
        //            });


        //            txttable.Invoke((MethodInvoker)delegate {

        //                txttable.Text = dr["TableNo"].ToString();
        //            });






        //    }
        //        con.Close();


        //        ////////////////FIRST NUMBER
        //        ///
        //        con.Open();
        //        MySqlCommand cmd1 = con.CreateCommand();
        //    cmd1.CommandType = CommandType.Text;
        //    cmd1.CommandText = "SELECT Date,Lane,number,TableNo FROM db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 2";
        //    cmd1.ExecuteNonQuery();
        //    DataTable dt1 = new DataTable();
        //    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
        //    da1.Fill(dt1);
        //    foreach (DataRow dr in dt1.Rows)
        //    {
        //        if (dt1.Rows.Count < 2)
        //        {


        //                lblfirst.Invoke((MethodInvoker)delegate {

        //                    lblfirst.Text = "0";
        //                });



        //        }
        //        else
        //        {

        //                lblfirst.Invoke((MethodInvoker)delegate {

        //                    lblfirst.Text = dr["Number"].ToString();
        //                });



        //                table1.Invoke((MethodInvoker)delegate {

        //                    table1.Text = dr["TableNo"].ToString();
        //                });




        //        }
        //    }
        //        con.Close();

        //        ////////////////2ND NUMBER
        //        ///
        //        con.Open();
        //    MySqlCommand cmd2 = con.CreateCommand();
        //    cmd2.CommandType = CommandType.Text;
        //    cmd2.CommandText = "SELECT Date,Lane,number,TableNo FROM db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 3";
        //    cmd2.ExecuteNonQuery();
        //    DataTable dt2 = new DataTable();
        //    MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
        //    da2.Fill(dt2);
        //    foreach (DataRow dr in dt2.Rows)
        //    {
        //        if (dt2.Rows.Count < 3)
        //        {

        //                lblsecond.Invoke((MethodInvoker)delegate {

        //                    lblsecond.Text = "0";
        //                });



        //        }
        //        else
        //        {

        //                lblsecond.Invoke((MethodInvoker)delegate {

        //                    lblsecond.Text = dr["Number"].ToString();
        //                });


        //                table2.Invoke((MethodInvoker)delegate {

        //                    table2.Text = dr["TableNo"].ToString();
        //                });




        //        }
        //    }
        //        con.Close();

        //        ////////////////3RD NUMBER
        //        ///

        //        con.Open();
        //    MySqlCommand cmd3 = con.CreateCommand();
        //    cmd3.CommandType = CommandType.Text;
        //    cmd3.CommandText = "SELECT Date,Lane,number,TableNo FROM db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 4";
        //    cmd3.ExecuteNonQuery();
        //    DataTable dt3 = new DataTable();
        //    MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
        //    da3.Fill(dt3);
        //    foreach (DataRow dr in dt3.Rows)
        //    {

        //        if (dt3.Rows.Count < 4)
        //        {



        //                lblthird.Invoke((MethodInvoker)delegate {

        //                    lblthird.Text = "0";
        //                });


        //            }
        //        else
        //        {

        //                lblthird.Invoke((MethodInvoker)delegate {

        //                    lblthird.Text = dr["Number"].ToString();
        //                });



        //                table3.Invoke((MethodInvoker)delegate {

        //                    table3.Text = dr["TableNo"].ToString();
        //                });



        //        }

        //    }
        //        con.Close();



        //        ////////////////4TH NUMBER
        //        ///

        //        con.Open();
        //        MySqlCommand cmd4 = con.CreateCommand();
        //        cmd4.CommandType = CommandType.Text;
        //        cmd4.CommandText = "SELECT Date,Lane,number,TableNo FROM db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 5";
        //        cmd4.ExecuteNonQuery();
        //        DataTable dt4 = new DataTable();
        //        MySqlDataAdapter da4 = new MySqlDataAdapter(cmd4);
        //        da4.Fill(dt4);
        //        foreach (DataRow dr in dt4.Rows)
        //        {

        //            if (dt4.Rows.Count < 5)
        //            {



        //                lblforth.Invoke((MethodInvoker)delegate {

        //                    lblforth.Text = "0";
        //                });


        //            }
        //            else
        //            {

        //                lblforth.Invoke((MethodInvoker)delegate {

        //                    lblforth.Text = dr["Number"].ToString();
        //                });



        //                table4.Invoke((MethodInvoker)delegate {

        //                    table4.Text = dr["TableNo"].ToString();
        //                });



        //            }

        //        }
        //        con.Close();






        //        ////////////////5TH NUMBER
        //        ///

        //        con.Open();
        //        MySqlCommand cmd5 = con.CreateCommand();
        //        cmd5.CommandType = CommandType.Text;
        //        cmd5.CommandText = "SELECT Date,Lane,number,TableNo FROM db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 6";
        //        cmd5.ExecuteNonQuery();
        //        DataTable dt5 = new DataTable();
        //        MySqlDataAdapter da5 = new MySqlDataAdapter(cmd5);
        //        da5.Fill(dt5);
        //        foreach (DataRow dr in dt5.Rows)
        //        {

        //            if (dt5.Rows.Count < 6)
        //            {



        //                lblfifth.Invoke((MethodInvoker)delegate {

        //                    lblfifth.Text = "0";
        //                });


        //            }
        //            else
        //            {

        //                lblfifth.Invoke((MethodInvoker)delegate {

        //                    lblfifth.Text = dr["Number"].ToString();
        //                });



        //                table5.Invoke((MethodInvoker)delegate {

        //                    table5.Text = dr["TableNo"].ToString();
        //                });



        //            }

        //        }
        //        con.Close();





        //    }
        //    catch (Exception ex)
        //    {
        //        /*
        //        lblconstatus.Invoke((MethodInvoker)delegate {
        //            // Access button_add here
        //            // lblconstatus.Text = "An error occured: " + ex.Message;
        //            lblconstatus.Text = ex.Message;
        //        });*/
        //    }
        //    finally
        //    {

        //    }
        //    /////DONE first





        //}



        public void expressnumber()
        {

            try
            {
               
                con.Open();
                enable();
                // express lane
                con.Close();


            }
            catch(Exception ex)
            {
                disable();

                lblconstatus.Invoke((MethodInvoker)delegate {
                    // Access button_add here
                     //lblconstatus.Text = "An error occured: " + ex.Message;
                    lblconstatus.Text = "Connection lost, Reconnecting.......... ";
                });



            }
            finally
            {

            }


          


        }

        //public void statuschange()
        //{

        //    ///REGULAR LANE
        //    ///
        //    try
        //    {

        //        txtstatus1.Invoke((MethodInvoker)delegate
        //        {

        //            if (table1.Text == "TABLE NUMBER HERE")
        //            {
        //                txtstatus1.Text = "STATUS";
        //                txtstatus1.ForeColor = Color.DarkCyan;
        //            }
        //            else
        //            {
        //                txtstatus1.Text = "NOW SERVING";
        //                txtstatus1.ForeColor = Color.SeaGreen;
        //            }
        //        });




        //        txtstatus2.Invoke((MethodInvoker)delegate
        //        {
        //            if (table2.Text == "TABLE NUMBER HERE")
        //            {
        //                txtstatus2.Text = "STATUS";
        //                txtstatus2.ForeColor = Color.DarkCyan;

        //            }
        //            else
        //            {
        //                txtstatus2.Text = "NOW SERVING";
        //                txtstatus2.ForeColor = Color.SeaGreen;
        //            }


        //        });






        //        txtstatus3.Invoke((MethodInvoker)delegate
        //        {

        //            if (table3.Text == "TABLE NUMBER HERE")
        //            {
        //                txtstatus3.Text = "STATUS";
        //                txtstatus3.ForeColor = Color.DarkCyan;
        //            }
        //            else
        //            {
        //                txtstatus3.Text = "NOW SERVING";
        //                txtstatus3.ForeColor = Color.SeaGreen;
        //            }

        //        });

        //        txtstatus4.Invoke((MethodInvoker)delegate
        //        {

        //            if (table4.Text == "TABLE NUMBER HERE")
        //            {
        //                txtstatus4.Text = "STATUS";
        //                txtstatus4.ForeColor = Color.DarkCyan;
        //            }
        //            else
        //            {
        //                txtstatus4.Text = "NOW SERVING";
        //                txtstatus4.ForeColor = Color.SeaGreen;
        //            }

        //        });

        //        txtstatus5.Invoke((MethodInvoker)delegate
        //        {

        //            if (table5.Text == "TABLE NUMBER HERE")
        //            {
        //                txtstatus5.Text = "STATUS";
        //                txtstatus5.ForeColor = Color.DarkCyan;
        //            }
        //            else
        //            {
        //                txtstatus5.Text = "NOW SERVING";
        //                txtstatus5.ForeColor = Color.SeaGreen;
        //            }

        //        });





        //        if (lblfirst.Text == "0")
        //        {


        //            txtstatus1.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatus1.Text = "STATUS";
        //            });



        //            table1.Invoke((MethodInvoker)delegate
        //            {


        //                table1.Text = "TABLE NUMBER HERE";
        //            });





        //        }
        //        else if (lblsecond.Text == "0")
        //        {



        //            txtstatus2.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatus2.Text = "STATUS";
        //            });



        //            table2.Invoke((MethodInvoker)delegate
        //            {


        //                table2.Text = "TABLE NUMBER HERE";
        //            });



        //        }
        //        else if (lblthird.Text == "0")
        //        {

        //            txtstatus3.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatus3.Text = "STATUS";
        //            });



        //            table3.Invoke((MethodInvoker)delegate
        //            {


        //                table3.Text = "TABLE NUMBER HERE";
        //            });




        //        }

        //        else if (lblforth.Text == "0")
        //        {

        //            txtstatus4.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatus4.Text = "STATUS";
        //            });



        //            table4.Invoke((MethodInvoker)delegate
        //            {


        //                table4.Text = "TABLE NUMBER HERE";
        //            });




        //        }
        //        else if (lblfifth.Text == "0")
        //        {

        //            txtstatus5.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatus5.Text = "STATUS";
        //            });



        //            table5.Invoke((MethodInvoker)delegate
        //            {


        //                table5.Text = "TABLE NUMBER HERE";
        //            });




        //        }




        //        //.... FOR express lane



        //        if (lblexpressfirst.Text == "0")
        //        {

        //            txtstatusexpress1.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress1.Text = "STATUS";
        //            });



        //            expresstable1.Invoke((MethodInvoker)delegate
        //            {


        //                expresstable1.Text = "TABLE NUMBER HERE";
        //            });




        //        }
        //        else if (lblexpress2nd.Text == "0")
        //        {

        //            txtstatusexpress2.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress2.Text = "STATUS";
        //            });



        //            expresstable2.Invoke((MethodInvoker)delegate
        //            {


        //                expresstable2.Text = "TABLE NUMBER HERE";
        //            });





        //        }
        //        else if (lblexpress3rd.Text == "0")
        //        {


        //            txtstatusexpress3.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress3.Text = "STATUS";
        //            });



        //            expresstable3.Invoke((MethodInvoker)delegate
        //            {


        //                expresstable3.Text = "TABLE NUMBER HERE";
        //            });



        //        }

        //        else if (lblexpress4th.Text == "0")
        //        {


        //            txtstatusexpress4.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress4.Text = "STATUS";
        //            });



        //            expresstable4.Invoke((MethodInvoker)delegate
        //            {


        //                expresstable4.Text = "TABLE NUMBER HERE";
        //            });



        //        }

        //        else if (lblexpress5th.Text == "0")
        //        {


        //            txtstatusexpress5.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress5.Text = "STATUS";
        //            });



        //            expresstable5.Invoke((MethodInvoker)delegate
        //            {


        //                expresstable5.Text = "TABLE NUMBER HERE";
        //            });



        //        }





        //        if (expresstable1.Text == "TABLE NUMBER HERE")
        //        {

        //            txtstatusexpress1.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress1.Text = "STATUS";

        //                txtstatusexpress1.ForeColor = Color.DarkCyan;


        //            });








        //        }
        //        else
        //        {

        //            txtstatusexpress1.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress1.Text = "NOW SERVING";
        //                txtstatusexpress1.ForeColor = Color.SeaGreen;

        //            });


        //        }



        //        if (expresstable2.Text == "TABLE NUMBER HERE")
        //        {

        //            txtstatusexpress2.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress2.Text = "STATUS";
        //                txtstatusexpress2.ForeColor = Color.DarkCyan;

        //            });



        //        }
        //        else
        //        {

        //            txtstatusexpress2.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress2.Text = "NOW SERVING";
        //                txtstatusexpress2.ForeColor = Color.SeaGreen;

        //            });



        //        }


        //        if (expresstable3.Text == "TABLE NUMBER HERE")
        //        {

        //            txtstatusexpress3.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress3.Text = "STATUS";
        //                txtstatusexpress3.ForeColor = Color.DarkCyan;

        //            });



        //        }
        //        else
        //        {

        //            txtstatusexpress3.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress3.Text = "NOW SERVING";
        //                txtstatusexpress3.ForeColor = Color.SeaGreen;

        //            });

        //        }





        //        if (expresstable4.Text == "TABLE NUMBER HERE")
        //        {

        //            txtstatusexpress4.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress4.Text = "STATUS";
        //                txtstatusexpress4.ForeColor = Color.DarkCyan;

        //            });



        //        }
        //        else
        //        {

        //            txtstatusexpress4.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress4.Text = "NOW SERVING";
        //                txtstatusexpress4.ForeColor = Color.SeaGreen;

        //            });

        //        }











        //        if (expresstable5.Text == "TABLE NUMBER HERE")
        //        {

        //            txtstatusexpress5.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress5.Text = "STATUS";
        //                txtstatusexpress5.ForeColor = Color.DarkCyan;

        //            });



        //        }
        //        else
        //        {

        //            txtstatusexpress5.Invoke((MethodInvoker)delegate
        //            {


        //                txtstatusexpress5.Text = "NOW SERVING";
        //                txtstatusexpress5.ForeColor = Color.SeaGreen;

        //            });

        //        }




        //    }
        //    catch(Exception ex)
        //    {

        //    }
        //}
        // public void done()
        //{
        //    /////DONE first

        //    try
        //    {
        //        if (donedatagrid.Rows.Count == 0)
        //        {

        //            txtdone1.Invoke((MethodInvoker)delegate {



        //                txtdone1.Text = "0";
        //            });

        //            txtdone2.Invoke((MethodInvoker)delegate {



        //                txtdone2.Text = "0";
        //            });


        //            txtdone3.Invoke((MethodInvoker)delegate {



        //                txtdone3.Text = "0";
        //            });



        //            lblstatus1.Invoke((MethodInvoker)delegate {



        //                lblstatus1.Text = "----------";
        //            });


        //            lblstatus2.Invoke((MethodInvoker)delegate {



        //                lblstatus2.Text = "----------";
        //            });



        //            lblstatus3.Invoke((MethodInvoker)delegate {



        //                lblstatus3.Text = "----------";
        //            });




            


        //        }


        //        con.Open();

        //        MySqlCommand cmd0 = con.CreateCommand();
        //        cmd0.CommandType = CommandType.Text;
        //        cmd0.CommandText = "select * from done_db WHERE date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY id DESC LIMIT 1";
        //        cmd0.ExecuteNonQuery();
        //        DataTable dt0 = new DataTable();
        //        MySqlDataAdapter da0 = new MySqlDataAdapter(cmd0);
        //        da0.Fill(dt0);
        //        donedatagrid.DataSource = dt0;
        //        foreach (DataRow dr in dt0.Rows)
        //        {



        //            txtdone1.Invoke((MethodInvoker)delegate {



        //                txtdone1.Text = dr["Number"].ToString();
        //            });


        //            lblstatus1.Invoke((MethodInvoker)delegate {



        //                lblstatus1.Text = dr["Lane"].ToString();
        //            });


        //            lbl_tbldone1.Invoke((MethodInvoker)delegate {



        //                lbl_tbldone1.Text = dr["TableNumber"].ToString();
        //            });




        //        }



        //        /////DONE second

        //        MySqlCommand cmd6 = con.CreateCommand();
        //        cmd6.CommandType = CommandType.Text;
        //        //cmd6.CommandText = "SELECT id,Date,number FROM done_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND number LIMIT 2 ";
        //        cmd6.CommandText = "SELECT * FROM done_db WHERE date ='" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY id DESC LIMIT 2";
        //        cmd6.ExecuteNonQuery();
        //        DataTable dt6 = new DataTable();
        //        MySqlDataAdapter da6 = new MySqlDataAdapter(cmd6);
        //        da6.Fill(dt6);

        //        foreach (DataRow dr in dt6.Rows)
        //        {

        //            if (dt6.Rows.Count < 2)
        //            {

        //                txtdone2.Invoke((MethodInvoker)delegate {



        //                    txtdone2.Text = "0";
        //                });

                   

        //            }
        //            else
        //            {


        //                txtdone2.Invoke((MethodInvoker)delegate {



        //                    txtdone2.Text = dr["Number"].ToString();
        //                });



        //                lblstatus2.Invoke((MethodInvoker)delegate {



        //                    lblstatus2.Text = dr["Lane"].ToString();

        //                });

        //                lbl_tbldone2.Invoke((MethodInvoker)delegate {



        //                    lbl_tbldone2.Text = dr["TableNumber"].ToString();
        //                });



        //            }


        //        }




        //        /////DONE third

        //        MySqlCommand cmd7 = con.CreateCommand();
        //        cmd7.CommandType = CommandType.Text;
        //        cmd7.CommandText = "SELECT * FROM done_db  WHERE date ='" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY id DESC LIMIT 3";
        //        cmd7.ExecuteNonQuery();
        //        DataTable dt7 = new DataTable();
        //        MySqlDataAdapter da7 = new MySqlDataAdapter(cmd7);
        //        da7.Fill(dt7);

        //        foreach (DataRow dr in dt7.Rows)
        //        {

        //            if (dt7.Rows.Count < 3)
        //            {

        //                txtdone3.Invoke((MethodInvoker)delegate {



        //                    txtdone3.Text = "0";

        //                });
                        

        //            }
        //            else
        //            {


        //                txtdone3.Invoke((MethodInvoker)delegate {




        //                    txtdone3.Text = dr["Number"].ToString();

        //                });



        //                lblstatus3.Invoke((MethodInvoker)delegate {




        //                    lblstatus3.Text = dr["Lane"].ToString();

        //                });

        //                lbl_tbldone3.Invoke((MethodInvoker)delegate {



        //                    lbl_tbldone3.Text = dr["TableNumber"].ToString();
        //                });


        //            }


        //        }
        //        con.Close();
        //    }
        //    catch(Exception ex)
        //    {
        //        // disable();
        //        /*
        //        lblconstatus.Invoke((MethodInvoker)delegate {
        //            // Access button_add here
        //            // lblconstatus.Text = "An error occured: " + ex.Message;
        //            lblconstatus.Text = ex.Message;
        //        });*/
        //    }
        //    finally
        //    {

        //    }
        //}

        public void disable()
        {
            // Example code running on a non-UI thread



            if (lblconstatus.IsHandleCreated)
            {
                lblconstatus.Invoke((MethodInvoker)delegate {


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
       

            lblconstatus.Invoke((MethodInvoker)delegate {

                lblconstatus.Text = "Connection Secured.";
                lblconstatus.ForeColor = Color.SeaGreen;
            });


            pic_check.Invoke((MethodInvoker)delegate {

                pic_check.Visible = true;
            });


            pic_loading.Invoke((MethodInvoker)delegate {

                pic_loading.Visible = false;
            });
        }





        private void numbertimer_Tick(object sender, EventArgs e)
        {
            try
            {

                _bgWorker.RunWorkerAsync();


            }
            catch (Exception ex)
            {

                // timer_confirmed.Stop();      // Access button_add here
                // lblconstatus.Text = "An error occurred: " + ex.Message;



            }
            finally
            {

            }

        
        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {
            
      
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
