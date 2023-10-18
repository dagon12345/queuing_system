using MySql.Data.MySqlClient;
using SpeechLib;
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
    public partial class formVerifierCaller : Form
    {
        ConnectionString cs = new ConnectionString();
        MySqlConnection con = null;

        BackgroundWorker _bgWorker;
        BackgroundWorker _bgWorker1;
        BackgroundWorker _bgWorker2;
        public formVerifierCaller()
        {
            InitializeComponent();
        }

        private void formVerifierCaller_Load(object sender, EventArgs e)
        {

            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += _bgWorker_DoWork;
            _bgWorker.RunWorkerCompleted += _bgWorker_RunWorkerCompleted;


            _bgWorker1 = new BackgroundWorker();
            _bgWorker1.DoWork += _bgWorker1_DoWork;
            _bgWorker1.RunWorkerCompleted += _bgWorker1_RunWorkerCompleted;


            _bgWorker2 = new BackgroundWorker();
            _bgWorker2.DoWork += _bgWorker2_DoWork;
            _bgWorker2.RunWorkerCompleted += _bgWorker2_RunWorkerCompleted;

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

        private void _bgWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonCallPriority.Invoke((MethodInvoker)delegate {

                buttonCall.Enabled = true;
                buttonCallPriority.Enabled = true;
                buttonPrevious.Enabled = true;
                buttonNext.Enabled = true;
                buttonNextPriority.Enabled = true;
                buttonPreviousPriority.Enabled = true;
            });
        }

        private void _bgWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            string nowCalling = "Now calling ";
            string clientNumber = "Client Number ";
            string priorityLane = "Priority Lane";

            if (textRegular.Text.Trim().Length > 0)
            {
                /*In this section "obj.Rate = -3", means speed of the voice of to robot caller
                 and the "obj.Voice = obj.GetVoices().Item(1) set for a girl voice
                while the number 0 is set for a male voice." */


                SpVoice obj = new SpVoice();
                obj.Rate = -2;
                obj.Volume = 100;
                obj.Voice = obj.GetVoices().Item(1);
                obj.Speak(nowCalling + clientNumber + textPriority.Text + priorityLane, SpeechVoiceSpeakFlags.SVSFDefault);

            }

            if (textRegular.Text.Trim().Length > 0)
            {
                /*In this section "obj.Rate = -3", means speed of the voice of to robot caller
                 and the "obj.Voice = obj.GetVoices().Item(1) set for a girl voice
                while the number 0 is set for a male voice." */


                SpVoice obj = new SpVoice();
                obj.Rate = -2;
                obj.Volume = 100;
                obj.Voice = obj.GetVoices().Item(1);
                obj.Speak(nowCalling + clientNumber + textPriority.Text + priorityLane, SpeechVoiceSpeakFlags.SVSFDefault);

            }

            Thread.Sleep(100);
        }

        private void _bgWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonCall.Invoke((MethodInvoker)delegate {

                buttonCall.Enabled = true;
                buttonCallPriority.Enabled = true;
                buttonPrevious.Enabled = true;
                buttonNext.Enabled = true;
                buttonNextPriority.Enabled = true;
                buttonPreviousPriority.Enabled = true;
            });
        }

        private void _bgWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string nowCalling = "Now calling ";
            string clientNumber = "Client Number ";
            string regularLane = "Regular Lane";

            if (textRegular.Text.Trim().Length > 0)
            {
                /*In this section "obj.Rate = -3", means speed of the voice of to robot caller
                 and the "obj.Voice = obj.GetVoices().Item(1) set for a girl voice
                while the number 0 is set for a male voice." */


                SpVoice obj = new SpVoice();
                obj.Rate = -2;
                obj.Volume = 100;
                obj.Voice = obj.GetVoices().Item(1);
                obj.Speak(nowCalling + clientNumber + textRegular.Text + regularLane, SpeechVoiceSpeakFlags.SVSFDefault);

            }

            if (textRegular.Text.Trim().Length > 0)
            {
                /*In this section "obj.Rate = -3", means speed of the voice of to robot caller
                 and the "obj.Voice = obj.GetVoices().Item(1) set for a girl voice
                while the number 0 is set for a male voice." */


                SpVoice obj = new SpVoice();
                obj.Rate = -2;
                obj.Volume = 100;
                obj.Voice = obj.GetVoices().Item(1);
                obj.Speak(nowCalling + clientNumber + textRegular.Text + regularLane, SpeechVoiceSpeakFlags.SVSFDefault);

            }

            Thread.Sleep(100);
        }

        void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {




                //Close();
        }

        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {


            post();
            Thread.Sleep(1000);


        }
        public void enable()
        {

            groupBox1.Invoke((MethodInvoker)delegate
            {

                groupBox1.Enabled = true;
            });

   

            pic_check.Invoke((MethodInvoker)delegate {

                pic_check.Visible = true;
            });





            lbl_connection.Invoke((MethodInvoker)delegate {

                lbl_connection.Text = "Successfully connected to SQL Server";
                lbl_connection.ForeColor = Color.SeaGreen;

            });



        }

        public void disable()
        {
            if (groupBox1.IsHandleCreated)
            {
                groupBox1.Invoke((MethodInvoker)delegate
                {

                    groupBox1.Enabled = false;
                });
            }
            else
            {

            }

        


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
        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int next = Convert.ToInt32(textRegular.Text);
                next++;
                textRegular.Text = next.ToString();

                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "update db_verifierRegular SET  Number = '" + textRegular.Text + "',Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Lane  = '" + labelRegular.Text + "'";
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection Error please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.Message);
            }

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                int next = Convert.ToInt32(textRegular.Text);
                next--;
                if (next == 0)
                {
                    MessageBox.Show("You've reached the minimum number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (next >= 1)
                {
                    con.Open();
                    textRegular.Text = next.ToString();
                    MySqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "update db_verifierRegular SET  Number = '" + textRegular.Text + "',Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Lane  = '" + labelRegular.Text + "'";
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.Message);
            }

        }

        private void buttonPreviousPriority_Click(object sender, EventArgs e)
        {
            try
            {
                int previous = Convert.ToInt32(textPriority.Text);
                previous--;
                if (previous == 0)
                {
                    MessageBox.Show("You've reached the minimum number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (previous >= 1)
                {
                    con.Open();
                    textPriority.Text = previous.ToString();
                    MySqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "update db_verifierPriority SET  Number = '" + textPriority.Text + "',Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Lane  = '" + labelPriority.Text + "'";
                    cmd2.ExecuteNonQuery();
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               //MessageBox.Show(ex.Message);
            }
        }

        private void buttonNextPriority_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int next = Convert.ToInt32(textPriority.Text);
                next++;
                textPriority.Text = next.ToString();

                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "update db_verifierPriority SET  Number = '" + textPriority.Text + "',Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Lane  = '" + labelPriority.Text + "'";
                cmd2.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.Message);
            }
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                _bgWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {


            }
            finally
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formVerifierExtend fe = new formVerifierExtend();
            fe.Show();
        }

        private void buttonCall_Click(object sender, EventArgs e)
        {
            try
            {
                _bgWorker1.RunWorkerAsync();

                buttonCall.Enabled = false;
                buttonCallPriority.Enabled = false;
                buttonPrevious.Enabled = false;
                buttonNext.Enabled = false;
                buttonNextPriority.Enabled = false;
                buttonPreviousPriority.Enabled = false;
            }
            catch(Exception)
            {

            }

        }

        private void buttonCallPriority_Click(object sender, EventArgs e)
        {
            try
            {
                _bgWorker2.RunWorkerAsync();
                buttonCall.Enabled = false;
                buttonCallPriority.Enabled = false;
                buttonPrevious.Enabled = false;
                buttonNext.Enabled = false;
                buttonNextPriority.Enabled = false;
                buttonPreviousPriority.Enabled = false;

            }
            catch(Exception)
            {

            }
        }
    }
}
