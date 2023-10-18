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

    public partial class formVerifierExtend : Form
    {
        ConnectionString cs = new ConnectionString();
        MySqlConnection con = null;
        BackgroundWorker _bgWorker;

        public formVerifierExtend()
        {
            InitializeComponent();
        }

        private void formVerifierExtend_Load(object sender, EventArgs e)
        {
            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += _bgWorker_DoWork;
            _bgWorker.RunWorkerCompleted += _bgWorker_RunWorkerCompleted;

            try
            {
                // Create and open a SQL connection

                con = new MySqlConnection(cs.DBcon);
                dateTimer.Start();


            }

            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message);
                this.Close();

            }
            finally
            {


            }

        }

        public void enable()
        {
           
            pic_check.Invoke((MethodInvoker)delegate {

                pic_check.Visible = true;
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

        public void disable()
        {
         
       
            if (pic_check.IsHandleCreated)
            {

                pic_check.Invoke((MethodInvoker)delegate {

                    pic_check.Visible = false;
                });
            }
            else
            {

            }


        }

        public void post()
        {

            try
            {

                con.Open();


                enable();



                //// REGULAR LANE
                ///
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from db_verifierRegular ORDER BY Number DESC";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach (DataRow dr in dt2.Rows)
                {


                    textRegular.Invoke((MethodInvoker)delegate
                    {
                        textRegular.Text = dr["Number"].ToString();
                    });




                }



                //// Priority LANE
                MySqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select * from db_verifierPriority ORDER BY Number DESC";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
                da3.Fill(dt3);
                foreach (DataRow dr in dt3.Rows)
                {



                    textPriority.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        textPriority.Text = dr["Number"].ToString();

                    });


                }






                //////// IF DATE CHANGE RESET TO ZERO ANG COUNTING
                //// Priority LANE
                MySqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "select * from db_verifierPriority ORDER BY Number DESC";
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
                        cmd0.CommandText = "update db_verifierRegular SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + "1" + "'";
                        cmd0.ExecuteNonQuery();


                        MySqlCommand cmd4 = con.CreateCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "update db_verifierPriority SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + "1" + "'";
                        cmd4.ExecuteNonQuery();
                    }



                }

                con.Close();
            }



            catch (Exception ex)
            {


                if (lbl_connection.IsHandleCreated)
                {

                    disable();
                    lbl_connection.Invoke((MethodInvoker)delegate
                    {
                        lbl_connection.Text = "Connection lost, Reconnecting.......... ";
                        lbl_connection.ForeColor = Color.Crimson;

                        // MessageBox.Show("an error occured:" + ex.Message);
                    });
                }

                else
                {
                }

            }
            finally
            {

            }



        }
        private void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            post();
            Thread.Sleep(1000);
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            try
            {

                _bgWorker.RunWorkerAsync();
                this.ActiveControl = null;
            }
            catch (Exception ex)
            {


            }
            finally
            {

            }
        }
    }
}
