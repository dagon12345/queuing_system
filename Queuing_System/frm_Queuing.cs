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
    public partial class Queuing : Form
    {
        ConnectionString cs = new ConnectionString();
        MySqlConnection con = null;


        public Queuing()
        {
            InitializeComponent();
            datetimer.Start();
        }

        BackgroundWorker _bgWorker;
        BackgroundWorker _bgWorker1;
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
            comboBox1.Invoke((MethodInvoker)delegate {
                // Access comboBox1 here
                combo2 = comboBox2.Text;
            });


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



            if (txt_number.Text.Trim().Length > 0)
            {
                SpVoice obj = new SpVoice();
                obj.Speak(label10.Text + txtexpressnumber.Text + combo2 + label9.Text, SpeechVoiceSpeakFlags.SVSFDefault);

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
            comboBox1.Invoke((MethodInvoker)delegate {
                // Access comboBox1 here
                combo = comboBox1.Text;
            });


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



            if (txt_number.Text.Trim().Length > 0)
            {
                SpVoice obj = new SpVoice();
                obj.Speak(label5.Text + txt_number.Text  + combo + label1.Text, SpeechVoiceSpeakFlags.SVSFDefault);

            }


        }

        /*
        void btnWorkIt_Click(object sender, EventArgs e)
        {
            // Note how the Form remains accessible
            _bgWorker.RunWorkerAsync();
        }

        */

        public void regularandexpressconfirmed()
        {
            ///// REGULAR LANE TABLE
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "REGULAR LANE" + "' ORDER BY Number ASC";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            da1.Fill(dt1);
            datagridregular.DataSource = dt1;
            this.datagridregular.Columns["id"].Visible = false;
            this.datagridregular.Columns["TableNo"].Visible = false;
            datagridregular.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridregular.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridregular.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridregular.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridregular.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridregular.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            ///// EXPRESS LANE TABLE
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "EXPRESS LANE" + "' ORDER BY Number ASC";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            datagridexpress.DataSource = dt2;
            this.datagridexpress.Columns["id"].Visible = false;
            this.datagridexpress.Columns["TableNo"].Visible = false;
            datagridexpress.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridexpress.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridexpress.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridexpress.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridexpress.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridexpress.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        } 

        private void frm_Queuing_Load(object sender, EventArgs e)
        {

            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += _bgWorker_DoWork;
            _bgWorker.RunWorkerCompleted += _bgWorker_RunWorkerCompleted;

            _bgWorker1 = new BackgroundWorker();
            _bgWorker1.DoWork += _bgWorker1_DoWork;
            _bgWorker1.RunWorkerCompleted += _bgWorker1_RunWorkerCompleted;
            try
            {
                con = new MySqlConnection(cs.DBcon);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }
                con.Open();

                // display();
                regularandexpressconfirmed();


                postregularlane();
                top2regularlane();


                postexpresslane();
                top2expresslane();




                done();
              
                updating();
                datagridtimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }


        }


        public void display()
        {
            
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
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



        }

        public void updating()
        {
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update number_db SET TableNo= '"+ comboBox1.Text +"' WHERE Number ='" + txt_number.Text + "' AND Date='"+ DateTime.Now.ToString("MMMM dd, yyyy") + "'";
            cmd1.ExecuteNonQuery();
        }


        public void done()
        {

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from done_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ORDER BY id DESC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            dataGridView2.DataSource = dt;
            da.Fill(dt);
            this.dataGridView2.Columns["id"].Visible = false;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void postexpresslane()
        {

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "EXPRESS LANE" + "' ORDER BY Number DESC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtexpressnumber.Text = dr["Number"].ToString();


                txtexpressdate.Text = dr["Date"].ToString();
                txtexpressselectedno.Text = dr["Number"].ToString();
                txtexpresslane.Text = dr["Lane"].ToString();
                txtexpresscategory.Text = dr["Category"].ToString();
                txtexpresstableno.Text = dr["TableNo"].ToString();

            }
        }


        public void top2expresslane()
        {

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Date,Lane,number FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "EXPRESS LANE" + "' ORDER BY Number ASC LIMIT 2";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                if (dt.Rows.Count < 2)
                {
                    txtexpressnextnumber.Text = "0";

                }
                else
                {
                    txtexpressnextnumber.Text = dr["Number"].ToString();
                }

            }
        }

        public void postregularlane()
        {

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "REGULAR LANE" + "' ORDER BY Number DESC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_number.Text = dr["Number"].ToString();



                txtdate.Text = dr["Date"].ToString();
                txtnumber.Text = dr["Number"].ToString();
                txtlane.Text = dr["Lane"].ToString();
                txtcategory.Text = dr["Category"].ToString();
                txttable.Text = dr["TableNo"].ToString();

                

            }
        }


        public void top2regularlane()
        {

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Date,Lane,number FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 2";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                if (dt.Rows.Count < 2)
                {
                    lblnext.Text = "0";

                }
                
                else
                {
                    lblnext.Text = dr["Number"].ToString();
                }
                
            }
        }

        private void datetimer_Tick(object sender, EventArgs e)
        {
            datetodaylbl.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }
        public void clearcheckregular()
        {
            txt_reason.Clear();
            check_onhold.Checked = false;
            
        }
        private void btn_add_Click(object sender, EventArgs e)
        {

            if (btn_add.Text == "Confirm")
            {
                if (datagridregular.Rows.Count == 0)
                {
                    MessageBox.Show("There is nothing here.");
                }
                else if (txtnumber.Text == "")
                {
                    MessageBox.Show("All data are confirmed or there is no data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("Are you sure you want to move this data to confirmed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into done_db (Date,Lane,Category,Number) values ('" + txtdate.Text + "','" + txtlane.Text + "','" + txtcategory.Text + "','" + txtnumber.Text + "')";
                    cmd1.ExecuteNonQuery();

                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete from db_confirmed WHERE Date = '" + txtdate.Text + "' and  Number='" + txtnumber.Text + "' and Lane = '" + txtlane.Text + "' ";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data moved to confirmed ready to Queue", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);



                  

                    regularandexpressconfirmed();


                    postregularlane();
                    top2regularlane();


                    postexpresslane();
                    top2expresslane();


                    done();




                    datagridregular.ClearSelection();
                    datagridexpress.ClearSelection();


                  //  _bgWorker.RunWorkerAsync();



                    if (datagridregular.Rows.Count == 0)
                    {

                    }
                    else
                    {
                        _bgWorker.RunWorkerAsync();
                    }
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
                else if (MessageBox.Show("Are you sure you want to put this data on hold?", "Onhold", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into db_onhold (Date,Number,Lane,Category,TableNo,Status) values ('" + txtdate.Text + "','" + txtnumber.Text + "','" + txtlane.Text + "','" + txtcategory.Text + "','" + txttable.Text + "','" + txt_reason.Text + "')";
                    cmd1.ExecuteNonQuery();

                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete from db_confirmed WHERE Date = '" + txtdate.Text + "' and  Number='" + txtnumber.Text + "' and Lane = '" + txtlane.Text + "' ";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data put on hold", "Onhold", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // txt_number.Text = "0";



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




                    datagridregular.ClearSelection();
                    datagridexpress.ClearSelection();

                    clearcheckregular();



                }
            }


            /*
            
            if (datagridregular.Rows.Count == 0)
            {
                MessageBox.Show("All numbers are served");
                txt_number.Text = "0";
                lblnext.Text = "0";
            }
            else if(comboBox1.Text == "")

            {
                MessageBox.Show("Select table number first");


            }
            else if (MessageBox.Show("Are you sure you want to proceed to the next number?", "Proceed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

               
                //int numRows = dataGridView1.Rows.Count;
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into done_db (Date,Number)values ('" + DateTime.Now.ToString("MMMM dd, yyyy") + "','" + txt_number.Text + "')";
                cmd1.ExecuteNonQuery();



                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "delete from number_db WHERE Number='" + txt_number.Text + "' ";
                cmd.ExecuteNonQuery();

          


                display();
                done();
                postregularlane();
                top2regularlane();

                updating();

                


                if (datagridregular.Rows.Count == 0)
                {
                  
                }
                else
                {

                    _bgWorker.RunWorkerAsync();
                 
                }
                

            }
            */

        }
   
        private void btn_repeat_Click(object sender, EventArgs e)
        {
            if (txt_number.Text == "0")
            {
                MessageBox.Show("All numbers are served");
            }
            else if(comboBox1.Text == "")
            {
                MessageBox.Show("Select table number first");
            }

            else if (txt_number.Text.Trim().Length > 0)
            {

                _bgWorker.RunWorkerAsync();


                /*
                SpVoice obj = new SpVoice();
                obj.Speak(label5.Text + txt_number.Text + comboBox1.Text, SpeechVoiceSpeakFlags.SVSFDefault);
                */
        }
    }

        private void btn_clear_Click(object sender, EventArgs e)
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




                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete from done_db WHERE Date='" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Table cleared");
                    done();
                    //txt_number.Text = "0";
                    //display();
                }
            }


            
        }

        private void datagridtimer_Tick(object sender, EventArgs e)
        {



            // display();
            regularandexpressconfirmed();


            postregularlane();
            top2regularlane();


            postexpresslane();
            top2expresslane();


            done();


          

            datagridregular.ClearSelection();
            datagridexpress.ClearSelection();



            if(datagridregular.Rows.Count == 0)
            {
                txtdate.Clear();
                txtnumber.Clear();
                txtlane.Clear();
                txtcategory.Clear();
                txttable.Clear();
                
            }

            if(datagridexpress.Rows.Count==0)
            {
                txtexpressdate.Clear();
                txtexpressselectedno.Clear();
                txtexpresslane.Clear();
                txtexpresstableno.Clear();
                txtexpresscategory.Clear();
            }
        }

        private void btn_extend_Click(object sender, EventArgs e)
        {
            frmExtended fe = new frmExtended();
            fe.Show();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void btnrepeatexpress_Click(object sender, EventArgs e)
        {
            if (txtexpressnumber.Text == "0")
            {
                MessageBox.Show("All numbers are served");
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Select table number first");
                comboBox2.Focus();
            }

            else if (txtexpressnumber.Text.Trim().Length > 0)
            {
                _bgWorker1.RunWorkerAsync();
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

                btn_add.Text = "Confirm";
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
               lblexpressreason.Visible= false;
               txtexpressreason.Visible = false;

               btnconfirmexpress.Text  = "Confirm";
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

            if (btnconfirmexpress.Text == "Confirm")
            {
                if (datagridexpress.Rows.Count == 0)
                {
                    MessageBox.Show("There is nothing here.");
                }
                else if (txtexpressnumber.Text == "")
                {
                    MessageBox.Show("Please select data you want to Confirm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("Are you sure you want to move this data to confirmed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into done_db (Date,Lane,Category,Number) values ('" + txtexpressdate.Text + "','" + txtexpresslane.Text + "','" + txtexpresscategory.Text + "','" + txtexpressnumber.Text + "')";
                    cmd1.ExecuteNonQuery();

                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete from db_confirmed WHERE Date = '" + txtexpressdate.Text + "' and  Number='" + txtexpressnumber.Text + "' and Lane = '" + txtexpresslane.Text + "' ";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data moved to confirmed ready to Queue", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    regularandexpressconfirmed();


                    postregularlane();
                    top2regularlane();


                    postexpresslane();
                    top2expresslane();


                    done();




                    datagridregular.ClearSelection();
                    datagridexpress.ClearSelection();


                    if(datagridexpress.Rows.Count==0)
                    {

                    }
                    else
                    {
                        _bgWorker1.RunWorkerAsync();
                    }
                  

                }



            }
            else if (btnconfirmexpress.Text == "Hold")
            {


                if (datagridexpress.Rows.Count == 0)
                {
                    MessageBox.Show("There is nothing here.");
                }
                else if (txtexpressnumber.Text == "")
                {
                    MessageBox.Show("Please select data you want to put in OnHold.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtexpressreason.Text == "")
                {
                    MessageBox.Show("Please input reason first before putting in OnHold.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtexpressreason.Focus();
                }
                else if (MessageBox.Show("Are you sure you want to put this data on hold?", "Onhold", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into db_onhold (Date,Number,Lane,Category,TableNo,Status) values ('" + txtexpressdate.Text + "','" + txtexpressnumber.Text + "','" + txtexpresslane.Text + "','" + txtexpresscategory.Text + "','" + txtexpresstableno.Text + "','" + txtexpressreason.Text + "')";
                    cmd1.ExecuteNonQuery();

                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete from db_confirmed WHERE Date = '" + txtexpressdate.Text + "' and  Number='" + txtexpressnumber.Text + "' and Lane = '" + txtexpresslane.Text + "' ";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data put on hold", "Onhold", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // txt_number.Text = "0";



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




                    datagridregular.ClearSelection();
                    datagridexpress.ClearSelection();

                    //clearcheckregular();



                }
            }

        }
    }
}
