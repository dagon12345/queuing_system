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
                lblfirst.Text = "0";
                lblsecond.Text = "0";
                lblthird.Text = "0";
                txttable.Text = "All Clients are served.";

            }
            ////////////////NOW SERVING
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "REGULAR LANE" + "' ORDER BY Number DESC";
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
            cmd1.CommandText = "SELECT Date,Lane,number FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 2";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                if (dt1.Rows.Count < 2)
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
            cmd2.CommandText = "SELECT Date,Lane,number FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 3";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr in dt2.Rows)
            {
                if (dt2.Rows.Count < 3)
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
            cmd3.CommandText = "SELECT Date,Lane,number FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 4";
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
            da3.Fill(dt3);
            foreach (DataRow dr in dt3.Rows)
            {

                if (dt3.Rows.Count < 4)
                {
                    lblthird.Text = "0";

                }
                else
                {
                    lblthird.Text = dr["Number"].ToString();
                }

            }




            /////DONE first


            if (dataGridView2.Rows.Count == 0)
            {
               txtdone1.Text = "0";
               txtdone2.Text = "0";
               txtdone3.Text = "0";
               

            }
            MySqlCommand cmd0 = con.CreateCommand();
                cmd0.CommandType = CommandType.Text;
                cmd0.CommandText = "select * from done_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ORDER BY id ASC";
                cmd0.ExecuteNonQuery();
                DataTable dt0 = new DataTable();
                MySqlDataAdapter da0 = new MySqlDataAdapter(cmd0);
                da0.Fill(dt0);
            dataGridView2.DataSource = dt0;
            foreach (DataRow dr in dt0.Rows)
                 {
               
                   
                     
                         txtdone1.Text = dr["Number"].ToString();
                     
               
                 }


                 /////DONE second

                 MySqlCommand cmd6 = con.CreateCommand();
                 cmd6.CommandType = CommandType.Text;
                 //cmd6.CommandText = "SELECT id,Date,number FROM done_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND number LIMIT 2 ";
                 cmd6.CommandText = "SELECT number,date FROM done_db WHERE date ='"+ DateTime.Now.ToString("MMMM dd, yyyy") + "' ORDER BY number DESC LIMIT 2";
                 cmd6.ExecuteNonQuery();
                 DataTable dt6 = new DataTable();
                 MySqlDataAdapter da6 = new MySqlDataAdapter(cmd6);
                 da6.Fill(dt6);

                 foreach (DataRow dr in dt6.Rows)
                 {

                if (dt6.Rows.Count < 2)
                {
                    txtdone2.Text = "0";

                }
                else
                {

                    txtdone2.Text = dr["Number"].ToString();
                }


                 }




                 /////DONE third

                 MySqlCommand cmd7 = con.CreateCommand();
                 cmd7.CommandType = CommandType.Text;
                 cmd7.CommandText = "SELECT number,date FROM done_db  WHERE date ='" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ORDER BY number DESC LIMIT 3";
                 cmd7.ExecuteNonQuery();
                 DataTable dt7 = new DataTable();
                 MySqlDataAdapter da7 = new MySqlDataAdapter(cmd7);
                 da7.Fill(dt7);

                 foreach (DataRow dr in dt7.Rows)
                 {

                if (dt7.Rows.Count < 3)
                {
                    txtdone3.Text = "0";

                }
                else
                {

                    txtdone3.Text = dr["Number"].ToString();
                }


                 }



















        }

        public void expressnumber()
        {
            if (dataGridView3.Rows.Count == 0)
            {
                txtexpressnumber.Text = "0";
                lblexpressfirst.Text = "0";
                lblexpress2nd.Text = "0";
                lblexpress3rd.Text = "0";
                txtexpresstable.Text = "All Clients are served.";

            }
            ////////////////NOW SERVING
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "EXPRESS LANE" + "' ORDER BY Number DESC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            foreach (DataRow dr in dt.Rows)
            {

                txtexpressnumber.Text = dr["Number"].ToString();
                txtexpresstable.Text = dr["TableNo"].ToString();



            }


            ////////////////FIRST NUMBER
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT Date,Lane,number FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "EXPRESS LANE" + "'ORDER BY Number ASC LIMIT 2";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                if (dt1.Rows.Count < 2)
                {
                    lblexpressfirst.Text = "0";

                }
                else
                {
                    lblexpressfirst.Text = dr["Number"].ToString();
                }
            }

            ////////////////2ND NUMBER
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT Date,Lane,number FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "EXPRESS LANE" + "'ORDER BY Number ASC LIMIT 3";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr in dt2.Rows)
            {
                if (dt2.Rows.Count < 3)
                {
                    lblexpress2nd.Text = "0";

                }
                else
                {
                    lblexpress2nd.Text = dr["Number"].ToString();
                }
            }

            ////////////////3RD NUMBER
            MySqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "SELECT Date,Lane,number FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "EXPRESS LANE" + "'ORDER BY Number ASC LIMIT 4";
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
            da3.Fill(dt3);
            foreach (DataRow dr in dt3.Rows)
            {

                if (dt3.Rows.Count < 4)
                {
                    lblexpress3rd.Text = "0";

                }
                else
                {
                    lblexpress3rd.Text = dr["Number"].ToString();
                }

            }




          


        }
         public void done()
        {
            /////DONE first


            if (dataGridView2.Rows.Count == 0)
            {
                txtdone1.Text = "0";
                txtdone2.Text = "0";
                txtdone3.Text = "0";


            }
            MySqlCommand cmd0 = con.CreateCommand();
            cmd0.CommandType = CommandType.Text;
            cmd0.CommandText = "select * from done_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ORDER BY id ASC";
            cmd0.ExecuteNonQuery();
            DataTable dt0 = new DataTable();
            MySqlDataAdapter da0 = new MySqlDataAdapter(cmd0);
            da0.Fill(dt0);
            dataGridView2.DataSource = dt0;
            foreach (DataRow dr in dt0.Rows)
            {



                txtdone1.Text = dr["Number"].ToString();
                lblstatus1.Text = dr["Lane"].ToString();   

            }


            /////DONE second

            MySqlCommand cmd6 = con.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            //cmd6.CommandText = "SELECT id,Date,number FROM done_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND number LIMIT 2 ";
            cmd6.CommandText = "SELECT number,date,Lane FROM done_db WHERE date ='" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ORDER BY number DESC LIMIT 2";
            cmd6.ExecuteNonQuery();
            DataTable dt6 = new DataTable();
            MySqlDataAdapter da6 = new MySqlDataAdapter(cmd6);
            da6.Fill(dt6);

            foreach (DataRow dr in dt6.Rows)
            {

                if (dt6.Rows.Count < 2)
                {
                    txtdone2.Text = "0";

                }
                else
                {

                    txtdone2.Text = dr["Number"].ToString();
                    lblstatus2.Text = dr["Lane"].ToString();
                }


            }




            /////DONE third

            MySqlCommand cmd7 = con.CreateCommand();
            cmd7.CommandType = CommandType.Text;
            cmd7.CommandText = "SELECT number,date,Lane FROM done_db  WHERE date ='" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ORDER BY number DESC LIMIT 3";
            cmd7.ExecuteNonQuery();
            DataTable dt7 = new DataTable();
            MySqlDataAdapter da7 = new MySqlDataAdapter(cmd7);
            da7.Fill(dt7);

            foreach (DataRow dr in dt7.Rows)
            {

                if (dt7.Rows.Count < 3)
                {
                    txtdone3.Text = "0";

                }
                else
                {

                    txtdone3.Text = dr["Number"].ToString();
                    lblstatus3.Text = dr["Lane"].ToString();
                }


            }
        }
        private void numbertimer_Tick(object sender, EventArgs e)
        {
            expressnumber();
            done();

            callme();

        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {
            
      
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
