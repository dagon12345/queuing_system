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

namespace Queuing_System
{
    public partial class Main_menu : Form
    {
        ConnectionString cs = new ConnectionString();
        MySqlConnection con = null;
            
        public Main_menu()
        {
            InitializeComponent();
            datetimer.Start();
            //display();
        }

        private void datetimer_Tick(object sender, EventArgs e)
        {
            datetodaylbl.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            display();

            post();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            int i = 0;
            txt_number.Text = Convert.ToString(Convert.ToInt32(txt_number.Text) + 1);


            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * FROM number_db where Date = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' AND Number ='" + txt_number.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {

                
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into number_db (Date,Number)values ('" + DateTime.Now.ToString("MMMM dd, yyyy") + "','" + txt_number.Text + "')";
                cmd1.ExecuteNonQuery();


                display();
            }
            else
            {
                MessageBox.Show("This Number already existed for today.");
            }
        }
        public void display()
        {

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from number_db WHERE Date = '"+ DateTime.Now.ToString("MMMM dd, yyyy") + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            dataGridView1.DataSource = dt;
            da.Fill(dt);
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["TableNo"].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        public void post()
        {

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from number_db";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_number.Text = dr["Number"].ToString();

            }
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(cs.DBcon);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();


                }
                con.Open();


                post();


                if (dataGridView1.Rows.Count == 0)
                {
                    txt_number.Text = "0";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();   
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //DELETE USERS FROM DATABASE.
            if (MessageBox.Show("Are you sure you want to delete this data?...", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("There is nothing to delete here.");
                }
                else
                {
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete from number_db WHERE Date='" + DateTime.Now.ToString("MMMM dd, yyyy") + "' ";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Table resetted");
                    txt_number.Text = "0";
                    display();
                }
                
            }
          
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There is nothing to delete here.");
            }
            else if (MessageBox.Show("Are you sure you want to rollback data?...", "Rollback", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


               
             
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete from number_db WHERE Number='" + txt_number.Text + "' ";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data rollback by 1");
                   // txt_number.Text = "0";
                    display();
                

            }
        }
    }
}
