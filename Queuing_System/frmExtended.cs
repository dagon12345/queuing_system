using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
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
                callerdata.Start();


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
          

      

            //con.Close();
            ///// REGULAR LANE TABLE
            con.Open();
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select CallerStatus,Number,TableNumber,Lane,Name from db_callerservice ";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                da1.Fill(dt1);
                foreach (DataRow dr in dt1.Rows)
                {


                   
                lblcaller.Invoke((MethodInvoker)delegate { lblcaller.Text = dr["CallerStatus"].ToString(); });
                lblnumber.Invoke((MethodInvoker)delegate { lblnumber.Text = dr["Number"].ToString(); });
                lbltblnumber.Invoke((MethodInvoker)delegate { lbltblnumber.Text = dr["TableNumber"].ToString(); });
                lbllane.Invoke((MethodInvoker)delegate { lbllane.Text = dr["Lane"].ToString(); });
                labelNameOfClient.Invoke((MethodInvoker)delegate { labelNameOfClient.Text = dr["Name"].ToString(); });

                /*Even if the social worker typed all upper case letters
                 the letters will always return a uppercase firs letter
                followed by lowercases letters.*/
                labelNameOfClient.Invoke((MethodInvoker)delegate {
                    string text = labelNameOfClient.Text.Trim();
                    labelNameOfClient.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
                });

            }
                con.Close();

           
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
                    this.datagridConfirmedData.Columns["TableNumber"].Visible = false;

                    datagridConfirmedData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    datagridConfirmedData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    datagridConfirmedData.ClearSelection();

                   

                    textCounter.Text = datagridConfirmedData.Rows.Count.ToString();
                });


                con.Close();

            }
            catch (Exception ex)
            {

                disable();
                lblconstatus.Invoke((MethodInvoker)delegate {lblconstatus.Text =
                "Connection lost, Reconnecting.......... ";
                });

            }
            finally
            {

            }

        }

        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do long lasting work


            expressnumber();
            listDoneData();
            nowserving1();
            nowServingPriority1();
            caller();




            if (lblcaller.Text == "CALLING...")
            {
               
                //Filter TABLE word and call table string.
                string MyString = lbltblnumber.Text;
                char[] MyChar = { 'A', 'B', 'E', 'L', 'T', ' ' };
                string NewString = MyString.TrimStart(MyChar);

                //string client = "Client number";
                string client = "Client ";
                string on = " on";
                string table = "Table";
                string name = "name";
                string nowserving = "Now serving";



                int labelvoice = Convert.ToInt32(labelVoiceNumber.Text);


                string inputedName = labelNameOfClient.Text.Trim();
                labelNameOfClient.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(inputedName.ToLower());
            

             

                if (lblnumber.Text.Trim().Length > 0)
                {
                    /*In this section "obj.Rate = -3", means speed of the voice of to robot caller
                     and the "obj.Voice = obj.GetVoices().Item(1) set for a girl voice
                    while the number 0 is set for a male voice." */

                    
                    SpVoice obj = new SpVoice();
                    obj.Rate = -2;
                    obj.Volume = 100;
                    obj.Voice = obj.GetVoices().Item(labelvoice); 
                    obj.Speak(nowserving + client + name + inputedName + on + table + NewString + lbllane.Text, SpeechVoiceSpeakFlags.SVSFDefault);

                }


                if (lblnumber.Text.Trim().Length > 0)
                {
                    SpVoice obj = new SpVoice();
                    obj.Rate = -2;
                    obj.Volume = 100;
                    obj.Voice = obj.GetVoices().Item(labelvoice);
                    obj.Speak(nowserving + client + name + inputedName + on + table + NewString + lbllane.Text, SpeechVoiceSpeakFlags.SVSFDefault);

                }

              




            }
                Thread.Sleep(1);

        }
        public void nowServingPriority1()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Number,Lane,TableNo,Name from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'AND Lane = '" + "PRIORITY LANE" + "'ORDER BY id DESC LIMIT 1";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {




                    richTextBoxDisplayPriority.Invoke((MethodInvoker)delegate { richTextBoxDisplayPriority.Text = dr["Name"].ToString(); });
                    labelPriorityTable1.Invoke((MethodInvoker)delegate { labelPriorityTable1.Text = dr["TableNo"].ToString(); });







                }
                con.Close();
            }
            catch (Exception)
            {
                /*
                disable();

                lblconstatus.Invoke((MethodInvoker)delegate {
                    lblconstatus.Text = "Connection lost, Reconnecting.......... ";
                });
                */


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
            cmd.CommandText = "select Number,Lane,TableNo,Name from db_extended WHERE Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'AND Lane = '" + "REGULAR LANE" + "' ORDER BY id DESC LIMIT 1 ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
                      foreach (DataRow dr in dt.Rows)
                      {
                          richTextBoxDisplayRegular.Invoke((MethodInvoker)delegate { richTextBoxDisplayRegular.Text = dr["Name"].ToString(); });

                          lblTableNumberOne.Invoke((MethodInvoker)delegate { lblTableNumberOne.Text = dr["TableNo"].ToString(); });

                      }
            con.Close();
            }
            catch (Exception)
                 {
                     /*
                     disable();
                     lblconstatus.Invoke((MethodInvoker)delegate { lblconstatus.Text = "Connection lost, Reconnecting.......... "; });
                    */
                 }
            finally
                  {
                  
                  }
            
        }
      
        public void expressnumber()
        {

            try
            {
               
                con.Open();
                enable();
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
             

                //labelTime.Text = DateTime.Now.ToLongTimeString();
                this.ActiveControl = null;
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

        private void callerdata_Tick(object sender, EventArgs e)
        {

            if (lblcaller.Text == "CALLING...")
            {
                
                //callerdata.Stop();
                try
                {
                    con.Open();
                    MySqlCommand cmd4 = con.CreateCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "update db_callerservice SET CallerStatus = '" + "IDLE" + "', Number = '" + "0" + "',TableNumber = '" + "-----" + "' ,Lane = '" + "-----" + "',Name = '" + " " + "'";
                    cmd4.ExecuteNonQuery();
                    con.Close();
                }
                catch(Exception ex)
                {
                    //MessageBox.Show("Connection Lost restarting the form...");
                    //this.Close();

                    lblconstatus.Text = ex.Message;
                    lblconstatus.ForeColor = Color.Crimson;
                }

                //numbertimer.Stop();
                progressbartimer.Start();
                progressbartimer.Tick += (s, args) =>
                {
                    if (progressBar1.Value < progressBar1.Maximum)
                    {
                        progressBar1.Value++;

                    }
                    else if(progressBar1.Value == 100)
                    {
                        progressbartimer.Stop(); // Stop the timer when loading is complete                                     
                        progressBar1.Value = 0;

                        lblcaller.Text = "IDLE";
                        //callerdata.Start();
                        
                    }
                };
                // Simulate loading by incrementing the progress bar
            }

         
        }



        private void updaterTimer_Tick(object sender, EventArgs e)
        {
           
         
        }

        private void progressbartimer_Tick(object sender, EventArgs e)
        {

        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonFemale.Checked == true)
            {
                labelVoiceNumber.Text = "1";
            }
            else if(radioButtonMale.Checked == true)
            {
                labelVoiceNumber.Text = "0";
            }
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFemale.Checked == true)
            {
                labelVoiceNumber.Text = "1";
            }
            else if (radioButtonMale.Checked == true)
            {
                labelVoiceNumber.Text = "0";
            }
        }

        private void richTextBoxDisplayRegular_TextChanged(object sender, EventArgs e)
        {
            /*Even if the social worker typed all upper case letters
                 the letters will always return a uppercase firs letter
                followed by lowercases letters.*/

            string text = richTextBoxDisplayRegular.Text.Trim();
            richTextBoxDisplayRegular.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());


            /*This code below is to make Richtextbox align Center since it has
           no option on its properties*/

            richTextBoxDisplayRegular.SelectAll();
            richTextBoxDisplayRegular.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void richTextBoxDisplayPriority_TextChanged(object sender, EventArgs e)
        {
            /*Even if the social worker typed all upper case letters
                 the letters will always return a uppercase firs letter
                followed by lowercases letters.*/

            string text = richTextBoxDisplayPriority.Text.Trim();
            richTextBoxDisplayPriority.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());

            
            /*This code below is to make Richtextbox align Center since it has
             no option on its properties*/
            richTextBoxDisplayPriority.SelectAll();
            richTextBoxDisplayPriority.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
