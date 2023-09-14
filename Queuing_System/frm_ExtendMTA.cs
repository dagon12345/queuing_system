using MySql.Data.MySqlClient;
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

namespace Queuing_System
{
    public partial class frm_ExtendMTA : Form
    {

        ConnectionString cs = new ConnectionString();
        MySqlConnection con = null;
        public frm_ExtendMTA()
        {
            InitializeComponent();
        }
        BackgroundWorker _bgWorker;
        bool _iNeedToCloseAfterBgWorker;

        private void frm_ExtendMTA_Load(object sender, EventArgs e)
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


        public void callme()
        {

            try
            {


                //REGULAR LANE
                if (datagridregular.Rows.Count == 0)
                {




                    txt_number.Invoke((MethodInvoker)delegate
                    {

                        txt_number.Text = "0";
                    });










                    lblthird.Invoke((MethodInvoker)delegate
                    {

                        lblthird.Text = "0";
                    });













                }


                ////////////////NOW SERVING

                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from db_MTAnumber WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "' ORDER BY Number DESC";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                datagridregular.DataSource = dt;
                foreach (DataRow dr in dt.Rows)
                {

                    txt_number.Invoke((MethodInvoker)delegate
                    {

                        txt_number.Text = dr["Number"].ToString();
                    });


                }
                con.Close();


                ////////////////FIRST NUMBER
                ///




                ////////////////3RD NUMBER
                ///

                con.Open();
                MySqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "SELECT Date,Lane,number,TableNo FROM db_MTAnumber WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 4";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
                da3.Fill(dt3);
                foreach (DataRow dr in dt3.Rows)
                {

                    if (dt3.Rows.Count < 4)
                    {



                        lblthird.Invoke((MethodInvoker)delegate
                        {

                            lblthird.Text = "0";
                        });


                    }
                    else
                    {

                        lblthird.Invoke((MethodInvoker)delegate
                        {

                            lblthird.Text = dr["Number"].ToString();
                        });





                    }

                }
                con.Close();





        }
            catch(Exception)
            {

            }


             
            }

     


        public void done()
        {
            /////DONE first

            try
            {
                if (donedatagrid.Rows.Count == 0)
                {

                    txtdone1.Invoke((MethodInvoker)delegate {



                        txtdone1.Text = "0";
                    });

                    txtdone2.Invoke((MethodInvoker)delegate {



                        txtdone2.Text = "0";
                    });


                    txtdone3.Invoke((MethodInvoker)delegate {



                        txtdone3.Text = "0";
                    });



                    lblstatus1.Invoke((MethodInvoker)delegate {



                        lblstatus1.Text = "----------";
                    });


                    lblstatus2.Invoke((MethodInvoker)delegate {



                        lblstatus2.Text = "----------";
                    });



                    lblstatus3.Invoke((MethodInvoker)delegate {



                        lblstatus3.Text = "----------";
                    });







                }


                con.Open();

                MySqlCommand cmd0 = con.CreateCommand();
                cmd0.CommandType = CommandType.Text;
                cmd0.CommandText = "select * from db_doneMTA WHERE date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY id ASC";
                cmd0.ExecuteNonQuery();
                DataTable dt0 = new DataTable();
                MySqlDataAdapter da0 = new MySqlDataAdapter(cmd0);
                da0.Fill(dt0);
                donedatagrid.DataSource = dt0;
                foreach (DataRow dr in dt0.Rows)
                {



                    txtdone1.Invoke((MethodInvoker)delegate {



                        txtdone1.Text = dr["Number"].ToString();
                    });


                    lblstatus1.Invoke((MethodInvoker)delegate {



                        lblstatus1.Text = dr["Lane"].ToString();
                    });




                }



                /////DONE second

                MySqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "SELECT * FROM db_doneMTA WHERE date ='" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY id DESC LIMIT 2";
                cmd6.ExecuteNonQuery();
                DataTable dt6 = new DataTable();
                MySqlDataAdapter da6 = new MySqlDataAdapter(cmd6);
                da6.Fill(dt6);

                foreach (DataRow dr in dt6.Rows)
                {

                    if (dt6.Rows.Count < 2)
                    {

                        txtdone2.Invoke((MethodInvoker)delegate {



                            txtdone2.Text = "0";
                        });



                    }
                    else
                    {


                        txtdone2.Invoke((MethodInvoker)delegate {



                            txtdone2.Text = dr["Number"].ToString();
                        });



                        lblstatus2.Invoke((MethodInvoker)delegate {



                            lblstatus2.Text = dr["Lane"].ToString();

                        });


                    }


                }




                /////DONE third

                MySqlCommand cmd7 = con.CreateCommand();
                cmd7.CommandType = CommandType.Text;
                cmd7.CommandText = "SELECT * FROM db_doneMTA  WHERE date ='" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY id DESC LIMIT 3";
                cmd7.ExecuteNonQuery();
                DataTable dt7 = new DataTable();
                MySqlDataAdapter da7 = new MySqlDataAdapter(cmd7);
                da7.Fill(dt7);

                foreach (DataRow dr in dt7.Rows)
                {

                    if (dt7.Rows.Count < 3)
                    {

                        txtdone3.Invoke((MethodInvoker)delegate {



                            txtdone3.Text = "0";

                        });


                    }
                    else
                    {


                        txtdone3.Invoke((MethodInvoker)delegate 
                        {
                            txtdone3.Text = dr["Number"].ToString();

                        });



                        lblstatus3.Invoke((MethodInvoker)delegate
                        {
                            lblstatus3.Text = dr["Lane"].ToString();

                        });

                    }


                }
                enable();
                con.Close();
            }
            catch (Exception ex)
            {
                 disable();
                
                lblconstatus.Invoke((MethodInvoker)delegate {
                    // Access button_add here
                    // lblconstatus.Text = "An error occured: " + ex.Message;
                    lblconstatus.Text = ex.Message;
                });
            }
            finally
            {

            }
        }


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



        void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            // btn_add.Enabled = true;
            if (_iNeedToCloseAfterBgWorker)
                Close();
        }

        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do long lasting work

            done();
            callme();



            //print();
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
    }
}
