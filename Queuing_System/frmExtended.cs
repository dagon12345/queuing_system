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



            //REGULAR LANE
            if (datagridregular.Rows.Count == 0)
            {
                txt_number.Text = "0";
                lblfirst.Text = "0";
                lblsecond.Text = "0";
                lblthird.Text = "0";
                txttable.Text = "All Clients are served.";

                
                table1.Text = "TABLE NUMBER HERE";
                table2.Text = "TABLE NUMBER HERE";
                table3.Text = "TABLE NUMBER HERE";


                txtstatus1.Text = "STATUS";
                txtstatus2.Text = "STATUS";
                txtstatus3.Text = "STATUS";
                

            }


            ////////////////NOW SERVING
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "REGULAR LANE" + "' ORDER BY Number DESC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            datagridregular.DataSource = dt;
            foreach (DataRow dr in dt.Rows)
            {

                txt_number.Text = dr["Number"].ToString();
                txttable.Text = dr["TableNo"].ToString();



            }


            ////////////////FIRST NUMBER
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT Date,Lane,number,TableNo FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 2";
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
                    table1.Text = dr["TableNo"].ToString();
                }
            }

            ////////////////2ND NUMBER
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT Date,Lane,number,TableNo FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 3";
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
                    table2.Text = dr["TableNo"].ToString();
                }
            }

            ////////////////3RD NUMBER
            MySqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "SELECT Date,Lane,number,TableNo FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "REGULAR LANE" + "'ORDER BY Number ASC LIMIT 4";
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
                    table3.Text = dr["TableNo"].ToString();
                }

            }




            /////DONE first


     


        }

        

        public void expressnumber()
        {

            // express lane

            if (datagridexpress.Rows.Count == 0)
            {
                txtexpressnumber.Text = "0";
                lblexpressfirst.Text = "0";
                lblexpress2nd.Text = "0";
                lblexpress3rd.Text = "0";
                txtexpresstable.Text = "All Clients are served.";


                expresstable1.Text = "TABLE NUMBER HERE";
                expresstable2.Text = "TABLE NUMBER HERE";
                expresstable3.Text = "TABLE NUMBER HERE";



                txtstatusexpress1.Text = "STATUS";
                txtstatusexpress2.Text = "STATUS";
                txtstatusexpress3.Text = "STATUS";

            }
            ////////////////NOW SERVING
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "EXPRESS LANE" + "' ORDER BY Number DESC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            datagridexpress.DataSource = dt;
            foreach (DataRow dr in dt.Rows)
            {

                txtexpressnumber.Text = dr["Number"].ToString();
                txtexpresstable.Text = dr["TableNo"].ToString();



            }


            ////////////////FIRST NUMBER
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT Date,Lane,number,TableNo FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "EXPRESS LANE" + "'ORDER BY Number ASC LIMIT 2";
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
                    expresstable1.Text = dr["TableNo"].ToString();
                }
            }

            ////////////////2ND NUMBER
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT Date,Lane,number,TableNo FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "EXPRESS LANE" + "'ORDER BY Number ASC LIMIT 3";
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
                    expresstable2.Text = dr["TableNo"].ToString();
                }
            }

            ////////////////3RD NUMBER
            MySqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "SELECT Date,Lane,number,TableNo FROM db_confirmed WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND LANE = '" + "EXPRESS LANE" + "'ORDER BY Number ASC LIMIT 4";
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
                    expresstable3.Text = dr["TableNo"].ToString();
                }

            }




          


        }

        public void statuschange()
        {

            



            ///// FOR regular LANE
            if (table1.Text == "TABLE NUMBER HERE")
            {
                txtstatus1.Text = "STATUS";
                txtstatus1.ForeColor = Color.DarkCyan;
            }
            else 
            {
                txtstatus1.Text = "NOW SERVING";
                txtstatus1.ForeColor = Color.SeaGreen;
            }



            if(table2.Text == "TABLE NUMBER HERE")
            {
                txtstatus2.Text = "STATUS";
                txtstatus2.ForeColor = Color.DarkCyan;

            }
            else
            {
                txtstatus2.Text = "NOW SERVING";
                txtstatus2.ForeColor = Color.SeaGreen;
            }


            if (table3.Text == "TABLE NUMBER HERE")
            {
                txtstatus3.Text = "STATUS";
                txtstatus3.ForeColor = Color.DarkCyan;
            }
            else 
            {
                txtstatus3.Text = "NOW SERVING";
                txtstatus3.ForeColor = Color.SeaGreen;
            }







            if(lblfirst.Text == "0")
            {
                txtstatus1.Text = "STATUS";
                table1.Text = "TABLE NUMBER HERE";
            }
            else if(lblsecond.Text == "0")
            {
                txtstatus2.Text = "STATUS";
                table2.Text = "TABLE NUMBER HERE";
            }
            else if(lblthird.Text == "0")
            {
                txtstatus3.Text = "STATUS";
                table3.Text = "TABLE NUMBER HERE";
            }





            //.... FOR express lane



            if (lblexpressfirst.Text == "0")
            {
                txtstatusexpress1.Text = "STATUS";
                expresstable1.Text = "TABLE NUMBER HERE";
            }
            else if (lblexpress2nd.Text == "0")
            {
                txtstatusexpress2.Text = "STATUS";
                expresstable2.Text = "TABLE NUMBER HERE";
            }
            else if (lblexpress3rd.Text == "0")
            {
                txtstatusexpress3.Text = "STATUS";
                expresstable3.Text = "TABLE NUMBER HERE";
            }





            if (expresstable1.Text == "TABLE NUMBER HERE")
            {
                txtstatusexpress1.Text = "STATUS";
                txtstatusexpress1.ForeColor = Color.DarkCyan;
            }
            else
            {
                txtstatusexpress1.Text = "NOW SERVING";
                txtstatusexpress1.ForeColor = Color.SeaGreen;
            }



            if (expresstable2.Text == "TABLE NUMBER HERE")
            {
                txtstatusexpress2.Text = "STATUS";
                txtstatusexpress2.ForeColor = Color.DarkCyan;
            }
            else
            {
                txtstatusexpress2.Text = "NOW SERVING";
                txtstatusexpress2.ForeColor = Color.SeaGreen;
            }


            if (expresstable3.Text == "TABLE NUMBER HERE")
            {
                txtstatusexpress3.Text = "STATUS";
                txtstatusexpress3.ForeColor = Color.DarkCyan;
            }
            else
            {
                txtstatusexpress3.Text = "NOW SERVING";
                txtstatusexpress3.ForeColor = Color.SeaGreen;
            }


        }
         public void done()
        {
            /////DONE first


            if (donedatagrid.Rows.Count == 0)
            {
                txtdone1.Text = "0";
                txtdone2.Text = "0";
                txtdone3.Text = "0";


                lblstatus1.Text = "----------";
                lblstatus2.Text = "----------";
                lblstatus3.Text = "----------";


            }

         

            
            MySqlCommand cmd0 = con.CreateCommand();
            cmd0.CommandType = CommandType.Text;
            cmd0.CommandText = "select * from done_db WHERE date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ORDER BY id ASC";
            cmd0.ExecuteNonQuery();
            DataTable dt0 = new DataTable();
            MySqlDataAdapter da0 = new MySqlDataAdapter(cmd0);
            da0.Fill(dt0);
            donedatagrid.DataSource = dt0;
            foreach (DataRow dr in dt0.Rows)
            {



                txtdone1.Text = dr["Number"].ToString();
                lblstatus1.Text = dr["Lane"].ToString();   

            }
            


            /////DONE second

            MySqlCommand cmd6 = con.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            //cmd6.CommandText = "SELECT id,Date,number FROM done_db WHERE Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND number LIMIT 2 ";
            cmd6.CommandText = "SELECT * FROM done_db WHERE date ='" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ORDER BY id DESC LIMIT 2";
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
            cmd7.CommandText = "SELECT * FROM done_db  WHERE date ='" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ORDER BY id DESC LIMIT 3";
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


            statuschange();
        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {
            
      
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
