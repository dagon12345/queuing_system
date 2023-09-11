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

        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do long lasting work


            expressnumber();
            // done();
            //callme();
            //statuschange();
            tablenumber1();
            tablenumber2();
            tablenumber3();
            tablenumber4();
            tablenumber5();
            tablenumber6();
            tablenumber7();
            tablenumber8();
            tablenumber9();
            tablenumber10();
            tablenumber11();
            tablenumber12();
            tablenumber13();
            tablenumber14();
            tablenumber15();
            tablenumber16();
            tablenumber17();
            tablenumber18();
            tablenumber19();
            tablenumber20();


            nowserving1();
            nowserving2();
            nowserving3();
            nowserving4();
            nowserving5();
            nowserving6();
            nowserving7();
            nowserving8();
            nowserving9();
            nowserving10();
            nowserving11();
            nowserving12();
            nowserving13();
            nowserving14();
            nowserving15();
            nowserving16();
            nowserving17();
            nowserving18();
            nowserving19();
            nowserving20();


            caller();





          

            if (lblcaller.Text == "CALLING...")
            {
                string client = "Client number";
                if (lblnumber.Text.Trim().Length > 0)
                {
                    SpVoice obj = new SpVoice();
                    obj.Speak(label25.Text + client + lblnumber.Text + lbltblnumber.Text + lbllane.Text, SpeechVoiceSpeakFlags.SVSFDefault);

                }

                string client1 = "Client number";
                if (lblnumber.Text.Trim().Length > 0)
                {
                    SpVoice obj = new SpVoice();
                    obj.Speak(label25.Text + client1 + lblnumber.Text + lbltblnumber.Text + lbllane.Text, SpeechVoiceSpeakFlags.SVSFDefault);

                }

            }

            Thread.Sleep(1);



            //print();
        }

        public void nowserving1()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 1" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend1.Invoke((MethodInvoker)delegate
            {
                dgextend1.DataSource = dt;
                dgextend1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend1.ClearSelection();
            });
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
        public void nowserving2()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 2" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend2.Invoke((MethodInvoker)delegate
            {
                dgextend2.DataSource = dt;
                dgextend2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend2.ClearSelection();
            });
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
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 3" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend3.Invoke((MethodInvoker)delegate
            {
                dgextend3.DataSource = dt;
                dgextend3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend3.ClearSelection();
            });
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
        public void nowserving4()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 4" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend4.Invoke((MethodInvoker)delegate
            {
                dgextend4.DataSource = dt;
                dgextend4.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend4.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend4.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend4.ClearSelection();
            });
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
        public void nowserving5()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 5" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend5.Invoke((MethodInvoker)delegate
            {
                dgextend5.DataSource = dt;
                dgextend5.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend5.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend5.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend5.ClearSelection();
            });
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
        public void nowserving6()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 6" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend6.Invoke((MethodInvoker)delegate
            {
                dgextend6.DataSource = dt;
                dgextend6.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend6.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend6.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend6.ClearSelection();
            });
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
        public void nowserving7()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 7" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend7.Invoke((MethodInvoker)delegate
            {
                dgextend7.DataSource = dt;
                dgextend7.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend7.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend7.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend7.ClearSelection();
            });
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
        public void nowserving8()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 8" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend8.Invoke((MethodInvoker)delegate
            {
                dgextend8.DataSource = dt;
                dgextend8.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend8.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend8.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend8.ClearSelection();
            });
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
        public void nowserving9()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 9" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend9.Invoke((MethodInvoker)delegate
            {
                dgextend9.DataSource = dt;
                dgextend9.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend9.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend9.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend9.ClearSelection();
            });
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
        public void nowserving10()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 10" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend10.Invoke((MethodInvoker)delegate
            {
                dgextend10.DataSource = dt;
                dgextend10.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend10.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend10.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend10.ClearSelection();
            });
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
        public void nowserving11()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 11" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend11.Invoke((MethodInvoker)delegate
            {
                dgextend11.DataSource = dt;
                dgextend11.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend11.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend11.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend11.ClearSelection();
            });
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
        public void nowserving12()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 12" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend12.Invoke((MethodInvoker)delegate
            {
                dgextend12.DataSource = dt;
                dgextend12.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend12.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend12.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend12.ClearSelection();
            });
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
        public void nowserving13()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 13" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend13.Invoke((MethodInvoker)delegate
            {
                dgextend13.DataSource = dt;
                dgextend13.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend13.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend13.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend13.ClearSelection();
            });
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
        public void nowserving14()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 14" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend14.Invoke((MethodInvoker)delegate
            {
                dgextend14.DataSource = dt;
                dgextend14.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend14.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend14.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend14.ClearSelection();
            });
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
        public void nowserving15()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 15" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend15.Invoke((MethodInvoker)delegate
            {
                dgextend15.DataSource = dt;
                dgextend15.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend15.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend15.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend15.ClearSelection();
            });
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
        public void nowserving16()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 16" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend16.Invoke((MethodInvoker)delegate
            {
                dgextend16.DataSource = dt;
                dgextend16.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend16.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend16.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend16.ClearSelection();
            });
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
        public void nowserving17()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 17" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend17.Invoke((MethodInvoker)delegate
            {
                dgextend17.DataSource = dt;
                dgextend17.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend17.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend17.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend17.ClearSelection();
            });
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
        public void nowserving18()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 18" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend18.Invoke((MethodInvoker)delegate
            {
                dgextend18.DataSource = dt;
                dgextend18.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend18.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend18.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend18.ClearSelection();
            });
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
        public void nowserving19()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 19" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend19.Invoke((MethodInvoker)delegate
            {
                dgextend19.DataSource = dt;
                dgextend19.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend19.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend19.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend19.ClearSelection();
            });
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
        public void nowserving20()
        {
            try
            { 
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Number,Lane,Surname from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 20" + "'LIMIT 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgextend20.Invoke((MethodInvoker)delegate
            {
                dgextend20.DataSource = dt;
                dgextend20.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend20.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgextend20.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgextend20.ClearSelection();
            });
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
        public void tablenumber1()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='"+"ON TABLE NUMBER 1"+ "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.Invoke((MethodInvoker)delegate
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.ClearSelection();

                    if (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


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

        public void tablenumber2()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 2" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.Invoke((MethodInvoker)delegate
                {
                    dataGridView2.DataSource = dt;
                    dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView2.ClearSelection();

                    if (dataGridView2.Rows.Count > 0)
                    {
                        dataGridView2.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView2.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


                con.Close();
            }
            catch (Exception ex)
            {
                disable();

                MessageBox.Show(ex.Message);
            }
            finally
            {

            }

        }

        public void tablenumber3()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 3" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView3.Invoke((MethodInvoker)delegate
                {
                    dataGridView3.DataSource = dt;
                    dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView3.ClearSelection();

                    if (dataGridView3.Rows.Count > 0)
                    {
                        dataGridView3.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView3.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


                con.Close();
            }
            catch (Exception ex)
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

        public void tablenumber4()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 4" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView4.Invoke((MethodInvoker)delegate
                {
                    dataGridView4.DataSource = dt;
                    dataGridView4.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView4.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView4.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView4.ClearSelection();
                    if (dataGridView4.Rows.Count > 0)
                    {
                        dataGridView4.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView4.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }



                });


                con.Close();
            }
            catch (Exception ex)
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


        public void tablenumber5()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 5" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView5.Invoke((MethodInvoker)delegate
                {
                    dataGridView5.DataSource = dt;
                    dataGridView5.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView5.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView5.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView5.ClearSelection();

                    if (dataGridView5.Rows.Count > 0)
                    {
                        dataGridView5.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView5.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


                con.Close();
            }
            catch (Exception ex)
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

        public void tablenumber6()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 6" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView6.Invoke((MethodInvoker)delegate
                {
                    dataGridView6.DataSource = dt;
                    dataGridView6.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView6.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView6.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView6.ClearSelection();

                    if (dataGridView6.Rows.Count > 0)
                    {
                        dataGridView6.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView6.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


                con.Close();
            }
            catch (Exception ex)
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


        public void tablenumber7()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 7" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView7.Invoke((MethodInvoker)delegate
                {
                    dataGridView7.DataSource = dt;
                    dataGridView7.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView7.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView7.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView7.ClearSelection();

                    if (dataGridView7.Rows.Count > 0)
                    {
                        dataGridView7.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView7.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


                con.Close();
            }
            catch (Exception ex)
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

        public void tablenumber8()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 8" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView8.Invoke((MethodInvoker)delegate
                {
                    dataGridView8.DataSource = dt;
                    dataGridView8.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView8.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView8.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView8.ClearSelection();

                    if (dataGridView8.Rows.Count > 0)
                    {
                        dataGridView8.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView8.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


                con.Close();
            }
            catch (Exception ex)
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


        public void tablenumber9()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 9" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView9.Invoke((MethodInvoker)delegate
                {
                    dataGridView9.DataSource = dt;
                    dataGridView9.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView9.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView9.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView9.ClearSelection();

                    if (dataGridView9.Rows.Count > 0)
                    {
                        dataGridView9.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView9.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


                con.Close();
            }
            catch (Exception ex)
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


        public void tablenumber10()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 10" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView10.Invoke((MethodInvoker)delegate
                {
                    dataGridView10.DataSource = dt;
                    dataGridView10.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView10.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView10.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView10.ClearSelection();

                    if (dataGridView10.Rows.Count > 0)
                    {
                        dataGridView10.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView10.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


                con.Close();
            }
            catch (Exception ex)
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


        public void tablenumber11()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 11" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView11.Invoke((MethodInvoker)delegate
                {
                    dataGridView11.DataSource = dt;
                    dataGridView11.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView11.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView11.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView11.ClearSelection();

                    if (dataGridView11.Rows.Count > 0)
                    {
                        dataGridView11.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView11.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


                con.Close();
            }
            catch (Exception ex)
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


        public void tablenumber12()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 12" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView12.Invoke((MethodInvoker)delegate
                {
                    dataGridView12.DataSource = dt;
                    dataGridView12.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView12.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView12.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView12.ClearSelection();

                    if (dataGridView12.Rows.Count > 0)
                    {
                        dataGridView12.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView12.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


                con.Close();
            }
            catch (Exception ex)
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





        public void tablenumber13()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 13" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView13.Invoke((MethodInvoker)delegate
                {
                    dataGridView13.DataSource = dt;
                    dataGridView13.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView13.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView13.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView13.ClearSelection();

                    if (dataGridView13.Rows.Count > 0)
                    {
                        dataGridView13.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView13.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


                con.Close();
            }
            catch (Exception ex)
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


        public void tablenumber14()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 14" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView14.Invoke((MethodInvoker)delegate
                {
                    dataGridView14.DataSource = dt;
                    dataGridView14.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView14.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView14.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView14.ClearSelection();
                    if (dataGridView14.Rows.Count > 0)
                    {
                        dataGridView14.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView14.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }



                });


                con.Close();
            }
            catch (Exception ex)
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

        public void tablenumber15()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 15" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView15.Invoke((MethodInvoker)delegate
                {
                    dataGridView15.DataSource = dt;
                    dataGridView15.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView15.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView15.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView15.ClearSelection();

                    if (dataGridView15.Rows.Count > 0)
                    {
                        dataGridView15.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView15.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


                con.Close();
            }
            catch (Exception ex)
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


        public void tablenumber16()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 16" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView16.Invoke((MethodInvoker)delegate
                {
                    dataGridView16.DataSource = dt;
                    dataGridView16.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView16.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView16.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView16.ClearSelection();

                    if (dataGridView16.Rows.Count > 0)
                    {
                        dataGridView16.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView16.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


                con.Close();
            }
            catch (Exception ex)
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

        public void tablenumber17()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 17" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView17.Invoke((MethodInvoker)delegate
                {
                    dataGridView17.DataSource = dt;
                    dataGridView17.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView17.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView17.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView17.ClearSelection();


                    if (dataGridView17.Rows.Count > 0)
                    {
                        dataGridView17.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView17.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }

                });


                con.Close();
            }
            catch (Exception ex)
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



        public void tablenumber18()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 18" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView18.Invoke((MethodInvoker)delegate
                {
                    dataGridView18.DataSource = dt;
                    dataGridView18.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView18.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView18.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView18.ClearSelection();
                    if (dataGridView18.Rows.Count > 0)
                    {
                        dataGridView18.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView18.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }



                });


                con.Close();
            }
            catch (Exception ex)
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




        public void tablenumber19()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 19" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView19.Invoke((MethodInvoker)delegate
                {
                    dataGridView19.DataSource = dt;
                    dataGridView19.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView19.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView19.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView19.ClearSelection();

                    if (dataGridView19.Rows.Count > 0)
                    {
                        dataGridView19.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView19.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }


                });


                con.Close();
            }
            catch (Exception ex)
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



        public void tablenumber20()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,Surname from db_confirmed WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TableNo='" + "ON TABLE NUMBER 20" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView20.Invoke((MethodInvoker)delegate
                {
                    dataGridView20.DataSource = dt;
                    dataGridView20.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView20.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView20.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView20.ClearSelection();


                    if (dataGridView20.Rows.Count > 0)
                    {
                        dataGridView20.Rows[0].DefaultCellStyle.BackColor = Color.SeaGreen; // Change the color to your preference
                        dataGridView20.Rows[0].DefaultCellStyle.ForeColor = Color.White; // Change the color to your preference
                    }

                });


                con.Close();
            }
            catch (Exception ex)
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
