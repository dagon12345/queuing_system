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

        private void frmExtended_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(cs.DBcon);
            if (con.State == ConnectionState.Open)
            {
                con.Close();


            }
            con.Open();

       
          numbertimer.Start();
            

        }

        public void callme()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                txt_number.Text = "0";
                txttable.Text = "All Clients are served.";

            }
            ////////////////NOW SERVING
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from number_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ORDER BY number DESC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            foreach (DataRow dr in dt.Rows)
            {

                txt_number.Text = dr["Number"].ToString();
                txttable.Text = dr["TableNo"].ToString();



            }


            ////////////////FIRST NUMBER
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT Date,number FROM number_db WHERE number LIMIT 2";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                if (dt.Rows.Count < 2)
                {
                    lblfirst.Text = "0";

                }
                else
                {
                    lblfirst.Text = dr["Number"].ToString();
                }
            }

            ////////////////2ND NUMBER
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT Date,number FROM number_db WHERE number LIMIT 3";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr in dt2.Rows)
            {
                if (dt.Rows.Count < 3)
                {
                    lblsecond.Text = "0";

                }
                else
                {
                    lblsecond.Text = dr["Number"].ToString();
                }
            }

            ////////////////3RD NUMBER
            MySqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "SELECT Date,number FROM number_db WHERE number LIMIT 4";
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
            da3.Fill(dt3);
            foreach (DataRow dr in dt3.Rows)
            {

                if (dt.Rows.Count < 4)
                {
                    lblthird.Text = "0";

                }
                else
                {
                    lblthird.Text = dr["Number"].ToString();
                }

            }


   


        }

        private void numbertimer_Tick(object sender, EventArgs e)
        {


            callme();

        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {
            
      
            
        }
    }
}
