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
using Microsoft.Win32;
using System.Drawing.Printing;
using System.IO;

namespace Queuing_System
{
    public partial class frmGeneratingMTA : Form
    {
        ConnectionString cs = new ConnectionString();
        MySqlConnection con = null;


        BackgroundWorker _bgWorker;
        BackgroundWorker _bgWorker1;

        bool _iNeedToCloseAfterBgWorker;
        public frmGeneratingMTA()
        {
            InitializeComponent();
        }


        public void disable()
        {
            if (btn_generate.IsHandleCreated)
            {
                btn_generate.Invoke((MethodInvoker)delegate {

                    btn_generate.Enabled = false;
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




        public void enable()
        {
            btn_generate.Invoke((MethodInvoker)delegate {

                btn_generate.Enabled = true;
            });


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
        private void clear()
        {
            try
            {

                rb_pwd.Invoke((MethodInvoker)delegate
                {

                    rb_pwd.Checked = false;

                });




                rb_lactating.Invoke((MethodInvoker)delegate {

                    rb_lactating.Checked = false;

                });



                rb_pregnant.Invoke((MethodInvoker)delegate {

                    rb_pregnant.Checked = false;

                });




                rb_senior.Invoke((MethodInvoker)delegate {

                    rb_senior.Checked = false;

                });



                cmb_lane.Invoke((MethodInvoker)delegate {

                    cmb_lane.Text = "REGULAR LANE";

                });


            }
            catch (Exception)
            { }
            finally
            {

            }

        }

        void _bgWorker1_RunWorkerCompleted1(object sender, RunWorkerCompletedEventArgs e)
        {
            date_timer.Start();
            lblstatus.Text = "Ready to release";
            btn_generate.Enabled = true;
            if (_iNeedToCloseAfterBgWorker)
                Close();
        }

        void _bgWorker1_DoWork1(object sender, DoWorkEventArgs e)
        {
            // Do long lasting work





            btn_generate.Invoke((MethodInvoker)delegate {
                // Access button_add here
                btn_generate.Enabled = false;
            });

            date_timer.Stop();


            lblstatus.Invoke((MethodInvoker)delegate {
                // Access lblstatus here
                lblstatus.Text = "Printing.....";
            });

            printnew();
           // printpreview();

            post();
           
            Thread.Sleep(2000);
         
            //   clear();


        }


    

        private void printpreview()
        {

            //PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            //PrintDocument printDocument = new PrintDocument();

            //printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            //printPreviewDialog.Document = printDocument;

            //printPreviewDialog.ShowDialog();


            // Create a PrintPreviewDialog and a PrintDocument
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = new System.Drawing.Printing.PrintDocument();

            // Set the PrintPage event handler to handle the printing logic
            printPreviewDialog.Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);

            // Show the print preview dialog
            printPreviewDialog.ShowDialog();






        }

        private void printnew()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);




            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            printDocument.Print();  // trigger printing



            /*

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
            
        }

*/
        }

        private void frmGeneratingMTA_Load(object sender, EventArgs e)
        {



            if (check_printing.Checked == true)
            {
                lblstatus.Text = "Ready to release";
            }
            else if (check_printing.Checked == false)
            {
                lblstatus.Text = "Ready to release manual";
            }

            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += _bgWorker_DoWork;
            _bgWorker.RunWorkerCompleted += _bgWorker_RunWorkerCompleted;



            _bgWorker1 = new BackgroundWorker();
            _bgWorker1.DoWork += _bgWorker1_DoWork1;
            _bgWorker1.RunWorkerCompleted += _bgWorker1_RunWorkerCompleted1;





            try
            {
                // Create and open a SQL connection

                con = new MySqlConnection(cs.DBcon);

                date_timer.Start();
                clear();
                post();






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







        void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {



            if (_iNeedToCloseAfterBgWorker)
                Close();
        }

        void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {


            post();


            Thread.Sleep(1000);


        }

        public void post()
        {

            try
            {

                con.Open();


                enable();


                if (cmb_lane.Text == "REGULAR LANE")
                {



                    //// REGULAR LANE
                    ///
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from db_MTAregular ORDER BY Number DESC";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_mynumber.Invoke((MethodInvoker)delegate
                        {
                            // Access button_add here
                            txt_mynumber.Text = dr["Number"].ToString();

                            txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_mynumber.Text) + 1);


                        });



                    }




                }
                else if (cmb_lane.Text == "PRIORITY LANE")
                {


                    //// Priority LANE
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                    da1.Fill(dt1);
                    foreach (DataRow dr in dt1.Rows)
                    {


                        txt_mynumber.Invoke((MethodInvoker)delegate
                        {
                            // Access button_add here
                            txt_mynumber.Text = dr["Number"].ToString();


                            txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_mynumber.Text) + 1);


                        });






                    }






                }








                //// REGULAR LANE
                ///
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from db_MTAregular  ORDER BY Number DESC";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach (DataRow dr in dt2.Rows)
                {


                    txt_regularlane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_regularlane.Text = dr["Number"].ToString();

                    });




                }



                //// Priority LANE
                MySqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
                da3.Fill(dt3);
                foreach (DataRow dr in dt3.Rows)
                {



                    txt_prioritylane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_prioritylane.Text = dr["Number"].ToString();

                    });


                }






                //////// IF DATE CHANGE RESET TO ZERO ANG COUNTING
                //// Priority LANE
                MySqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
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
                        cmd0.CommandText = "update db_MTAregular SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + "0" + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "None" + "',TableNo  = '" + "" + "'";
                        cmd0.ExecuteNonQuery();


                        MySqlCommand cmd4 = con.CreateCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "update db_MTApriority SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + "0" + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "None" + "',TableNo  = '" + "" + "'";
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

        private void date_timer_Tick(object sender, EventArgs e)
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
            txt_date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_time.Text = DateTime.Now.ToString("hh:mm:ss tt");



        }

        private void btn_generate_Click(object sender, EventArgs e)
        {

            try
            {



                if (cmb_lane.Text == "")
                {
                    MessageBox.Show("Please select LANE first to proceed", "Select Lane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lblstatus.Text == "Printing.....")
                {
                    MessageBox.Show("Please wait data is printing", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmb_lane.Text == "REGULAR LANE")  //// REGULAR LANE HERE
                {




                    if (MessageBox.Show("Are you sure you want to generate Number? Lane type: " + cmb_lane.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        //INSERTING AND UPDATING.....
                      
                        con.Open();
                        MySqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "insert into db_MTAnumber (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "None" + "','" + "None" + "')";
                        cmd1.ExecuteNonQuery();


                        MySqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "update db_MTAregular SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + txt_mynumber.Text + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "None" + "',TableNo  = '" + "" + "'";
                        cmd2.ExecuteNonQuery();

                       
                        if (check_printing.Checked == true)
                        {
                            _bgWorker1.RunWorkerAsync();
                            lblstatus.Text = "Ready to release";
                        }
                        else if (check_printing.Checked == false)
                        {
                            lblstatus.Text = "Ready to release manual";
                        }


                        con.Close();

                    }


                }

                else if (cmb_lane.Text == "PRIORITY LANE")
                {



                    if (MessageBox.Show("Are you sure you want to generate Number? Lane type: " + cmb_lane.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (rb_pwd.Checked == true)
                        {
                            con.Open();
                            MySqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "insert into db_MTAnumber (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "Person with disability(PWD)" + "','" + "None" + "')";
                            cmd1.ExecuteNonQuery();


                            MySqlCommand cmd2 = con.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = "update db_MTApriority SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + txt_mynumber.Text + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "Person with disability(PWD)" + "',TableNo  = '" + "" + "'";
                            cmd2.ExecuteNonQuery();





                            ////PRININTG OPTION HERE
                            if (check_printing.Checked == true)
                            {
                                _bgWorker1.RunWorkerAsync();
                                lblstatus.Text = "Ready to release";
                            }
                            else if (check_printing.Checked == false)
                            {
                                lblstatus.Text = "Ready to release manual";
                            }


                            con.Close();
                        }
                        else if (rb_pregnant.Checked == true)
                        {
                            con.Open();
                            MySqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "insert into db_MTAnumber  (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "Pregnant" + "','" + "None" + "')";
                            cmd1.ExecuteNonQuery();


                            MySqlCommand cmd2 = con.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = "update db_MTApriority SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + txt_mynumber.Text + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "Pregnant" + "',TableNo  = '" + "" + "'";
                            cmd2.ExecuteNonQuery();





                            ////PRININTG OPTION HERE
                            if (check_printing.Checked == true)
                            {
                                _bgWorker1.RunWorkerAsync();
                                lblstatus.Text = "Ready to release";
                            }
                            else if (check_printing.Checked == false)
                            {
                                lblstatus.Text = "Ready to release manual";
                            }


                            con.Close();
                        }
                        else if (rb_lactating.Checked == true)
                        {
                            con.Open();
                            MySqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "insert into db_MTAnumber (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "Lactating" + "','" + "None" + "')";
                            cmd1.ExecuteNonQuery();


                            MySqlCommand cmd2 = con.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = "update db_MTApriority SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + txt_mynumber.Text + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "Lactating" + "',TableNo  = '" + "" + "'";
                            cmd2.ExecuteNonQuery();





                            ////PRININTG OPTION HERE
                            if (check_printing.Checked == true)
                            {
                                _bgWorker1.RunWorkerAsync();
                                lblstatus.Text = "Ready to release";
                            }
                            else if (check_printing.Checked == false)
                            {
                                lblstatus.Text = "Ready to release manual";
                            }


                            con.Close();
                        }
                        else if (rb_senior.Checked == true)
                        {
                            con.Open();
                            MySqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "insert into db_MTAnumber  (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "Senior Citizen" + "','" + "None" + "')";
                            cmd1.ExecuteNonQuery();


                            MySqlCommand cmd2 = con.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = "update db_MTApriority SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + txt_mynumber.Text + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "Senior Citizen" + "',TableNo  = '" + "" + "'";
                            cmd2.ExecuteNonQuery();





                            ////PRININTG OPTION HERE
                            if (check_printing.Checked == true)
                            {
                                _bgWorker1.RunWorkerAsync();
                                lblstatus.Text = "Ready to release";
                            }
                            else if (check_printing.Checked == false)
                            {
                                lblstatus.Text = "Ready to release manual";
                            }


                            con.Close();
                        }
                        else if (rb_emergency.Checked == true)
                        {
                            con.Open();
                            MySqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "insert into db_MTAnumber  (Date,Number,Lane,Category,TableNo)values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + txt_mynumber.Text + "','" + cmb_lane.Text + "','" + "Emergency" + "','" + "None" + "')";
                            cmd1.ExecuteNonQuery();


                            MySqlCommand cmd2 = con.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = "update db_MTApriority SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + txt_mynumber.Text + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "Emergency" + "',TableNo  = '" + "" + "'";
                            cmd2.ExecuteNonQuery();





                            ////PRININTG OPTION HERE
                            if (check_printing.Checked == true)
                            {
                                _bgWorker1.RunWorkerAsync();
                                lblstatus.Text = "Ready to release";
                            }
                            else if (check_printing.Checked == false)
                            {
                                lblstatus.Text = "Ready to release manual";
                            }


                            con.Close();
                        }


                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message + "Please try again.");
                this.Close();
            }
            finally
            {
                // Any cleanup or closing operations can be performed here
                // This code block will be executed regardless of whether an exception occurred or not
            }


            ///printnew();
           // printpreview();
            con.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            if (cmb_lane.Text == "REGULAR LANE")
            {

                float yPos = 0; // Y-coordinate for positioning the content
                using (MySqlConnection connection = new MySqlConnection(cs.DBcon))
                {
                    connection.Open();

                    string query = "SELECT * FROM db_MTAregular WHERE Number='" + txt_mynumber.Text + "' AND Lane = '" + cmb_lane.Text + "' AND Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string date = reader.GetString("Date");
                                int number = reader.GetInt32("Number");
                                string lane = reader.GetString("Lane");
                                string category = reader.GetString("Category");
                                string tableno = reader.GetString("TableNo");



                                /////// TICKET PRINTING HARD CODING
                                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(20, 10, 260, 300));  ///        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(LEFT, UP, WIDTH, HEIGHT));
                                /*
                                string imagePath = Path.Combine(Application.StartupPath, "branding.jpg");
                                Image image = Image.FromFile(imagePath);
                                e.Graphics.DrawImage(image, new Rectangle(20, 10, 150, 40));
                                */

                                string currentDirectory = Directory.GetCurrentDirectory();
                                string imagePath = Path.Combine(currentDirectory, "branding.jpg");
                                Image image = Image.FromFile(imagePath);
                                e.Graphics.DrawImage(image, new Rectangle(20, 10, 150, 40));




                                e.Graphics.DrawString(txt_date.Text, new Font("Century Gothic", 9, FontStyle.Italic), Brushes.Black, new PointF(190, 10));
                                e.Graphics.DrawString(txt_time.Text, new Font("Century Gothic", 9, FontStyle.Italic), Brushes.Black, new PointF(190, 25));
                                e.Graphics.DrawLine(Pens.Black, new Point(280, 95), new Point(20, 95)); ///e.Graphics.DrawLine(Pens.Black, new Point(LINE WIDTH, TOP LOCATION), new Point(LEFT , RIGHT));
                                e.Graphics.DrawString("MTA", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new PointF(110, 50));
                                e.Graphics.DrawString("Lane:", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(60, 100));
                                e.Graphics.DrawString($"{lane}", new Font("Arial black", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 100));/// e.Graphics.DrawString($"{date}", new Font("Century Gothic", 12), Brushes.Black, new PointF(LEFT POSITION, TOP));
                                e.Graphics.DrawString("Category:", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(30, 130));
                                e.Graphics.DrawString($"{category}", new Font("Century Gothic", 10, FontStyle.Italic), Brushes.Black, new PointF(100, 130));
                                e.Graphics.DrawString("Please wait until your NUMBER was Called", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new PointF(35, 160));
                                e.Graphics.DrawString("YOUR NUMBER IS:", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new PointF(100, 173));
                                e.Graphics.DrawLine(Pens.Black, new Point(280, 150), new Point(20, 150)); ///e.Graphics.DrawLine(Pens.Black, new Point(LINE WIDTH, TOP LOCATION), new Point(LEFT , RIGHT));

                                //e.Graphics.DrawString($"{number}", new Font("Arial black", 50), Brushes.Black, new PointF(90, 175));





                                float textHeight = e.Graphics.MeasureString($"{number}", new Font("Arial black", 50)).Height;
                                float yPosBottom = yPos + 280 - textHeight;
                                e.Graphics.DrawString($"{number}", new Font("Arial black", 50), Brushes.Black, new PointF(100, yPosBottom));



                                e.Graphics.DrawString("WIFI Available", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 265));
                                e.Graphics.DrawString("Name: Guest Wireless", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new PointF(80, 280));
                                e.Graphics.DrawString("Password: BawatBuhayMahalaga", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new PointF(50, 295));





                                e.Graphics.DrawString("-END OF THE LINE-", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(95, 320));


                            }
                        }
                    }
                    connection.Close();
                }

            }
            else if (cmb_lane.Text == "PRIORITY LANE")
            {
                float yPos = 0; // Y-coordinate for positioning the content
                using (MySqlConnection connection = new MySqlConnection(cs.DBcon))
                {
                    connection.Open();

                    string query = "SELECT * FROM db_MTApriority WHERE Number='" + txt_mynumber.Text + "' AND Lane = '" + cmb_lane.Text + "' AND Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string date = reader.GetString("Date");
                                int number = reader.GetInt32("Number");
                                string lane = reader.GetString("Lane");
                                string category = reader.GetString("Category");
                                string tableno = reader.GetString("TableNo");



                                /////// TICKET PRINTING HARD CODING
                                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(20, 10, 260, 300));  ///        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(LEFT, UP, WIDTH, HEIGHT));
                                /*
                                string imagePath = Path.Combine(Application.StartupPath, "branding.jpg");
                                Image image = Image.FromFile(imagePath);
                                e.Graphics.DrawImage(image, new Rectangle(20, 10, 150, 40));
                                */

                                string currentDirectory = Directory.GetCurrentDirectory();
                                string imagePath = Path.Combine(currentDirectory, "branding.jpg");
                                Image image = Image.FromFile(imagePath);
                                e.Graphics.DrawImage(image, new Rectangle(20, 10, 150, 40));




                                e.Graphics.DrawString(txt_date.Text, new Font("Century Gothic", 9, FontStyle.Italic), Brushes.Black, new PointF(190, 10));
                                e.Graphics.DrawString(txt_time.Text, new Font("Century Gothic", 9, FontStyle.Italic), Brushes.Black, new PointF(190, 25));
                                e.Graphics.DrawLine(Pens.Black, new Point(280, 95), new Point(20, 95)); ///e.Graphics.DrawLine(Pens.Black, new Point(LINE WIDTH, TOP LOCATION), new Point(LEFT , RIGHT));
                                e.Graphics.DrawString("MTA", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new PointF(110, 50));
                                e.Graphics.DrawString("Lane:", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(60, 100));
                                e.Graphics.DrawString($"{lane}", new Font("Arial black", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 100));/// e.Graphics.DrawString($"{date}", new Font("Century Gothic", 12), Brushes.Black, new PointF(LEFT POSITION, TOP));
                                e.Graphics.DrawString("Category:", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(30, 130));
                                e.Graphics.DrawString($"{category}", new Font("Century Gothic", 10, FontStyle.Italic), Brushes.Black, new PointF(100, 130));
                                e.Graphics.DrawString("Please wait until your NUMBER was Called", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new PointF(35, 160));
                                e.Graphics.DrawString("YOUR NUMBER IS:", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new PointF(100, 173));
                                e.Graphics.DrawLine(Pens.Black, new Point(280, 150), new Point(20, 150)); ///e.Graphics.DrawLine(Pens.Black, new Point(LINE WIDTH, TOP LOCATION), new Point(LEFT , RIGHT));

                                //e.Graphics.DrawString($"{number}", new Font("Arial black", 50), Brushes.Black, new PointF(90, 175));





                                float textHeight = e.Graphics.MeasureString($"{number}", new Font("Arial black", 50)).Height;
                                float yPosBottom = yPos + 280 - textHeight;
                                e.Graphics.DrawString($"{number}", new Font("Arial black", 50), Brushes.Black, new PointF(100, yPosBottom));



                                e.Graphics.DrawString("WIFI Available", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 265));
                                e.Graphics.DrawString("Name: Guest Wireless", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new PointF(80, 280));
                                e.Graphics.DrawString("Password: BawatBuhayMahalaga", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new PointF(50, 295));


                                e.Graphics.DrawString("-END OF THE LINE-", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new PointF(95, 320));


                            }
                        }
                    }
                    connection.Close();
                }
            }
          

        }

        private void check_printing_CheckedChanged(object sender, EventArgs e)
        {
            if (check_printing.Checked == true)
            {
                // check_printing.Text = "Automatic Printing";
                lblstatus.Text = "Ready to release";
            }
            else if (check_printing.Checked == false)
            {
                // check_printing.Text = "Manual number releasing";
                lblstatus.Text = "Ready to release manual";
            }
        }

        private void rb_pwd_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pwd.Checked == true || rb_lactating.Checked == true || rb_pregnant.Checked == true || rb_senior.Checked == true)
            {
                cmb_lane.Text = "PRIORITY LANE"; ////// update
            }
            else
            {
                cmb_lane.Text = "REGULAR LANE";
            }
            try
            {

                con.Open();


                enable();


                if (cmb_lane.Text == "REGULAR LANE")
                {

                    //// REGULAR LANE
                    ///
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from db_MTAregular ORDER BY Number DESC";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_mynumber.Invoke((MethodInvoker)delegate
                        {
                            // Access button_add here
                            txt_mynumber.Text = dr["Number"].ToString();

                            txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_mynumber.Text) + 1);


                        });

                    }


                }
                else if (cmb_lane.Text == "PRIORITY LANE")
                {

                    //// Priority LANE
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                    da1.Fill(dt1);
                    foreach (DataRow dr in dt1.Rows)
                    {


                        txt_mynumber.Invoke((MethodInvoker)delegate
                        {
                            // Access button_add here
                            txt_mynumber.Text = dr["Number"].ToString();


                            txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_mynumber.Text) + 1);


                        });

                    }

                }

                //// REGULAR LANE
                ///
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from db_MTAregular  ORDER BY Number DESC";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach (DataRow dr in dt2.Rows)
                {


                    txt_regularlane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_regularlane.Text = dr["Number"].ToString();

                    });

                }

                //// Priority LANE
                MySqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
                da3.Fill(dt3);
                foreach (DataRow dr in dt3.Rows)
                {

                    txt_prioritylane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_prioritylane.Text = dr["Number"].ToString();

                    });


                }

                //////// IF DATE CHANGE RESET TO ZERO ANG COUNTING
                //// Priority LANE
                MySqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
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
                        cmd0.CommandText = "update db_MTAregular SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + "0" + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "None" + "',TableNo  = '" + "" + "'";
                        cmd0.ExecuteNonQuery();


                        MySqlCommand cmd4 = con.CreateCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "update db_MTApriority SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + "0" + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "None" + "',TableNo  = '" + "" + "'";
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

        private void rb_pregnant_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pwd.Checked == true || rb_lactating.Checked == true || rb_pregnant.Checked == true || rb_senior.Checked == true)
            {
                cmb_lane.Text = "PRIORITY LANE";//UPDATED
            }
            else
            {
                cmb_lane.Text = "REGULAR LANE";
            }



            try
            {

                con.Open();


                enable();


                if (cmb_lane.Text == "REGULAR LANE")
                {



                    //// REGULAR LANE
                    ///
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from db_MTAregular ORDER BY Number DESC";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_mynumber.Invoke((MethodInvoker)delegate
                        {
                            // Access button_add here
                            txt_mynumber.Text = dr["Number"].ToString();

                            txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_mynumber.Text) + 1);


                        });








                    }







                }
                else if (cmb_lane.Text == "PRIORITY LANE")
                {


                    //// Priority LANE
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                    da1.Fill(dt1);
                    foreach (DataRow dr in dt1.Rows)
                    {


                        txt_mynumber.Invoke((MethodInvoker)delegate
                        {
                            // Access button_add here
                            txt_mynumber.Text = dr["Number"].ToString();


                            txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_mynumber.Text) + 1);


                        });






                    }






                }








                //// REGULAR LANE
                ///
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from db_MTAregular  ORDER BY Number DESC";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach (DataRow dr in dt2.Rows)
                {


                    txt_regularlane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_regularlane.Text = dr["Number"].ToString();

                    });




                }



                //// Priority LANE
                MySqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
                da3.Fill(dt3);
                foreach (DataRow dr in dt3.Rows)
                {



                    txt_prioritylane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_prioritylane.Text = dr["Number"].ToString();

                    });


                }






                //////// IF DATE CHANGE RESET TO ZERO ANG COUNTING
                //// Priority LANE
                MySqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
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
                        cmd0.CommandText = "update db_MTAregular SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + "0" + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "None" + "',TableNo  = '" + "" + "'";
                        cmd0.ExecuteNonQuery();


                        MySqlCommand cmd4 = con.CreateCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "update db_MTApriority SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + "0" + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "None" + "',TableNo  = '" + "" + "'";
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

        private void rb_emergency_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pwd.Checked == true || rb_lactating.Checked == true || rb_pregnant.Checked == true || rb_senior.Checked == true || rb_emergency.Checked == true)
            {
                cmb_lane.Text = "PRIORITY LANE";//UPDATED
            }
            else
            {
                cmb_lane.Text = "REGULAR LANE";
            }



            try
            {

                con.Open();


                enable();


                if (cmb_lane.Text == "REGULAR LANE")
                {



                    //// REGULAR LANE
                    ///
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from db_MTAregular ORDER BY Number DESC";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_mynumber.Invoke((MethodInvoker)delegate
                        {
                            // Access button_add here
                            txt_mynumber.Text = dr["Number"].ToString();

                            txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_mynumber.Text) + 1);


                        });








                    }







                }
                else if (cmb_lane.Text == "PRIORITY LANE")
                {


                    //// Priority LANE
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                    da1.Fill(dt1);
                    foreach (DataRow dr in dt1.Rows)
                    {


                        txt_mynumber.Invoke((MethodInvoker)delegate
                        {
                            // Access button_add here
                            txt_mynumber.Text = dr["Number"].ToString();


                            txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_mynumber.Text) + 1);


                        });






                    }






                }








                //// REGULAR LANE
                ///
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from db_MTAregular  ORDER BY Number DESC";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach (DataRow dr in dt2.Rows)
                {


                    txt_regularlane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_regularlane.Text = dr["Number"].ToString();

                    });




                }



                //// Priority LANE
                MySqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
                da3.Fill(dt3);
                foreach (DataRow dr in dt3.Rows)
                {



                    txt_prioritylane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_prioritylane.Text = dr["Number"].ToString();

                    });


                }






                //////// IF DATE CHANGE RESET TO ZERO ANG COUNTING
                //// Priority LANE
                MySqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
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
                        cmd0.CommandText = "update db_MTAregular SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + "0" + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "None" + "',TableNo  = '" + "" + "'";
                        cmd0.ExecuteNonQuery();


                        MySqlCommand cmd4 = con.CreateCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "update db_MTApriority SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + "0" + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "None" + "',TableNo  = '" + "" + "'";
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

        private void rb_lactating_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pwd.Checked == true || rb_lactating.Checked == true || rb_pregnant.Checked == true || rb_senior.Checked == true)
            {
                cmb_lane.Text = "PRIORITY LANE"; //PRIORITY
            }
            else
            {
                cmb_lane.Text = "REGULAR LANE";
            }



            try
            {

                con.Open();


                enable();


                if (cmb_lane.Text == "REGULAR LANE")
                {



                    //// REGULAR LANE
                    ///
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from db_MTAregular ORDER BY Number DESC";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_mynumber.Invoke((MethodInvoker)delegate
                        {
                            // Access button_add here
                            txt_mynumber.Text = dr["Number"].ToString();

                            txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_mynumber.Text) + 1);


                        });








                    }







                }
                else if (cmb_lane.Text == "PRIORITY LANE")
                {


                    //// Priority LANE
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                    da1.Fill(dt1);
                    foreach (DataRow dr in dt1.Rows)
                    {


                        txt_mynumber.Invoke((MethodInvoker)delegate
                        {
                            // Access button_add here
                            txt_mynumber.Text = dr["Number"].ToString();


                            txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_mynumber.Text) + 1);


                        });






                    }






                }








                //// REGULAR LANE
                ///
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from db_MTAregular  ORDER BY Number DESC";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach (DataRow dr in dt2.Rows)
                {


                    txt_regularlane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_regularlane.Text = dr["Number"].ToString();

                    });




                }



                //// Priority LANE
                MySqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
                da3.Fill(dt3);
                foreach (DataRow dr in dt3.Rows)
                {



                    txt_prioritylane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_prioritylane.Text = dr["Number"].ToString();

                    });


                }






                //////// IF DATE CHANGE RESET TO ZERO ANG COUNTING
                //// Priority LANE
                MySqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
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
                        cmd0.CommandText = "update db_MTAregular SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + "0" + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "None" + "',TableNo  = '" + "" + "'";
                        cmd0.ExecuteNonQuery();


                        MySqlCommand cmd4 = con.CreateCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "update db_MTApriority SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + "0" + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "None" + "',TableNo  = '" + "" + "'";
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

        private void rb_senior_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pwd.Checked == true || rb_lactating.Checked == true || rb_pregnant.Checked == true || rb_senior.Checked == true)
            {
                cmb_lane.Text = "PRIORITY LANE";//UPDATED
            }
            else
            {
                cmb_lane.Text = "REGULAR LANE";
            }



            try
            {

                con.Open();


                enable();


                if (cmb_lane.Text == "REGULAR LANE")
                {



                    //// REGULAR LANE
                    ///
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from db_MTAregular ORDER BY Number DESC";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_mynumber.Invoke((MethodInvoker)delegate
                        {
                            // Access button_add here
                            txt_mynumber.Text = dr["Number"].ToString();

                            txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_mynumber.Text) + 1);


                        });








                    }







                }
                else if (cmb_lane.Text == "PRIORITY LANE")
                {


                    //// Priority LANE
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                    da1.Fill(dt1);
                    foreach (DataRow dr in dt1.Rows)
                    {


                        txt_mynumber.Invoke((MethodInvoker)delegate
                        {
                            // Access button_add here
                            txt_mynumber.Text = dr["Number"].ToString();


                            txt_mynumber.Text = Convert.ToString(Convert.ToInt32(txt_mynumber.Text) + 1);


                        });






                    }






                }








                //// REGULAR LANE
                ///
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from db_MTAregular  ORDER BY Number DESC";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach (DataRow dr in dt2.Rows)
                {


                    txt_regularlane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_regularlane.Text = dr["Number"].ToString();

                    });




                }



                //// Priority LANE
                MySqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
                da3.Fill(dt3);
                foreach (DataRow dr in dt3.Rows)
                {



                    txt_prioritylane.Invoke((MethodInvoker)delegate
                    {
                        // Access button_add here
                        txt_prioritylane.Text = dr["Number"].ToString();

                    });


                }






                //////// IF DATE CHANGE RESET TO ZERO ANG COUNTING
                //// Priority LANE
                MySqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "select * from db_MTApriority ORDER BY Number DESC";
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
                        cmd0.CommandText = "update db_MTAregular SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + "0" + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "None" + "',TableNo  = '" + "" + "'";
                        cmd0.ExecuteNonQuery();


                        MySqlCommand cmd4 = con.CreateCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "update db_MTApriority SET Date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', Number = '" + "0" + "',Lane  = '" + cmb_lane.Text + "', Category = '" + "None" + "',TableNo  = '" + "" + "'";
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
