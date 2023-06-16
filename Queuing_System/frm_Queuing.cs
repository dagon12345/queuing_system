using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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


        public frm_Queuing()
        {
            InitializeComponent();
            datetimer.Start();
        }

        private void frm_Queuing_Load(object sender, EventArgs e)
        {

           try
           {


                con = new MySqlConnection(cs.DBcon);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();


                }
                con.Open();

                display();
                post();

                done();
                top2();
                updating();
                datagridtimer.Start();
         
   
                  
                    if(txt_number.Text == "0")
                    {

                    }

                    else if (txt_number.Text.Trim().Length > 0)
                    {

                        SpVoice obj = new SpVoice();
                        obj.Speak(label5.Text + txt_number.Text + comboBox1.Text, SpeechVoiceSpeakFlags.SVSFDefault);
                    }

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
            cmd.CommandText = "select * from number_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            dataGridView1.DataSource = dt;
            da.Fill(dt);
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["TableNo"].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            lbl_total.Text = dataGridView1.Rows.Count.ToString();


            if (dataGridView1.Rows.Count == 0)
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
        }


        public void post()
        {

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from number_db ORDER BY number DESC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_number.Text = dr["Number"].ToString();

            }
        }


        public void top2()
        {

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Date,number FROM number_db WHERE number LIMIT 2";
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
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
                post();
                top2();

                updating();

                //lbl_total.Text = numRows.ToString();

                if (dataGridView1.Rows.Count == 0)
                {
                  
                }
                else
                {
                    if (txt_number.Text.Trim().Length > 0)
                    {
                        SpVoice obj = new SpVoice();
                        obj.Speak(label5.Text + txt_number.Text + comboBox1.Text, SpeechVoiceSpeakFlags.SVSFDefault);
                    }
                }

            }

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
                SpVoice obj = new SpVoice();
                obj.Speak(label5.Text + txt_number.Text + comboBox1.Text, SpeechVoiceSpeakFlags.SVSFDefault);
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
           


            display();
            post();

            done();
            top2();

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void btn_extend_Click(object sender, EventArgs e)
        {
            frmExtended fe = new frmExtended();
            fe.Show();



        }
    }
}
