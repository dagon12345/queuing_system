
namespace Queuing_System
{
    partial class frmExtended
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtended));
            this.numbertimer = new System.Windows.Forms.Timer(this.components);
            this.lblconstatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.lblcaller = new System.Windows.Forms.Label();
            this.lbltblnumber = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lbllane = new System.Windows.Forms.Label();
            this.pic_loading = new System.Windows.Forms.PictureBox();
            this.pic_check = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTableNumberTwo = new System.Windows.Forms.Label();
            this.lblTableNumberOne = new System.Windows.Forms.Label();
            this.labelNowServing2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textNowServing2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPriorityTable2 = new System.Windows.Forms.Label();
            this.labelPriorityTable1 = new System.Windows.Forms.Label();
            this.lblNowservingPriority2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textPriority1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textPriority2 = new System.Windows.Forms.TextBox();
            this.textNowServing1 = new System.Windows.Forms.TextBox();
            this.labelTableThird = new System.Windows.Forms.Label();
            this.labelNowServing3 = new System.Windows.Forms.Label();
            this.textNowServing3 = new System.Windows.Forms.TextBox();
            this.textPriority3 = new System.Windows.Forms.TextBox();
            this.lblNowservingPriority3 = new System.Windows.Forms.Label();
            this.lblPriorityTable3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagridConfirmedData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_check)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridConfirmedData)).BeginInit();
            this.SuspendLayout();
            // 
            // numbertimer
            // 
            this.numbertimer.Interval = 500;
            this.numbertimer.Tick += new System.EventHandler(this.numbertimer_Tick);
            // 
            // lblconstatus
            // 
            this.lblconstatus.AutoSize = true;
            this.lblconstatus.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconstatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblconstatus.Location = new System.Drawing.Point(501, 8);
            this.lblconstatus.Name = "lblconstatus";
            this.lblconstatus.Size = new System.Drawing.Size(103, 15);
            this.lblconstatus.TabIndex = 62;
            this.lblconstatus.Text = "Connection Secured.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(391, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 61;
            this.label8.Text = "Connection Status:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SeaGreen;
            this.label12.Location = new System.Drawing.Point(5, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 19);
            this.label12.TabIndex = 33;
            this.label12.Text = "CIS Queuing System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(180, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 19);
            this.label2.TabIndex = 67;
            this.label2.Text = "Lister per table numbers.";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(648, 8);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(68, 15);
            this.label65.TabIndex = 149;
            this.label65.Text = "Caller Status:";
            // 
            // lblcaller
            // 
            this.lblcaller.AutoSize = true;
            this.lblcaller.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaller.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblcaller.Location = new System.Drawing.Point(719, 8);
            this.lblcaller.Name = "lblcaller";
            this.lblcaller.Size = new System.Drawing.Size(22, 15);
            this.lblcaller.TabIndex = 150;
            this.lblcaller.Text = "-----";
            // 
            // lbltblnumber
            // 
            this.lbltblnumber.AutoSize = true;
            this.lbltblnumber.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltblnumber.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbltblnumber.Location = new System.Drawing.Point(821, 8);
            this.lbltblnumber.Name = "lbltblnumber";
            this.lbltblnumber.Size = new System.Drawing.Size(22, 15);
            this.lbltblnumber.TabIndex = 151;
            this.lbltblnumber.Text = "-----";
            this.lbltblnumber.Visible = false;
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumber.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblnumber.Location = new System.Drawing.Point(782, 9);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(12, 15);
            this.lblnumber.TabIndex = 151;
            this.lblnumber.Text = "0";
            this.lblnumber.Visible = false;
            // 
            // lbllane
            // 
            this.lbllane.AutoSize = true;
            this.lbllane.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllane.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbllane.Location = new System.Drawing.Point(860, 9);
            this.lbllane.Name = "lbllane";
            this.lbllane.Size = new System.Drawing.Size(22, 15);
            this.lbllane.TabIndex = 151;
            this.lbllane.Text = "-----";
            this.lbllane.Visible = false;
            // 
            // pic_loading
            // 
            this.pic_loading.Image = global::Queuing_System.Properties.Resources.loading;
            this.pic_loading.Location = new System.Drawing.Point(486, 12);
            this.pic_loading.Name = "pic_loading";
            this.pic_loading.Size = new System.Drawing.Size(10, 10);
            this.pic_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_loading.TabIndex = 64;
            this.pic_loading.TabStop = false;
            // 
            // pic_check
            // 
            this.pic_check.Image = global::Queuing_System.Properties.Resources.icons8_check_96;
            this.pic_check.Location = new System.Drawing.Point(486, 12);
            this.pic_check.Name = "pic_check";
            this.pic_check.Size = new System.Drawing.Size(10, 10);
            this.pic_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_check.TabIndex = 63;
            this.pic_check.TabStop = false;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel12.BackColor = System.Drawing.Color.Teal;
            this.panel12.Location = new System.Drawing.Point(446, 29);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(5, 693);
            this.panel12.TabIndex = 160;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.datagridConfirmedData);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(893, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 688);
            this.groupBox3.TabIndex = 155;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "DONE SERVED";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.labelTableThird);
            this.groupBox2.Controls.Add(this.labelNowServing3);
            this.groupBox2.Controls.Add(this.textNowServing3);
            this.groupBox2.Controls.Add(this.textNowServing1);
            this.groupBox2.Controls.Add(this.lblTableNumberTwo);
            this.groupBox2.Controls.Add(this.lblTableNumberOne);
            this.groupBox2.Controls.Add(this.labelNowServing2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textNowServing2);
            this.groupBox2.Location = new System.Drawing.Point(9, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 692);
            this.groupBox2.TabIndex = 153;
            this.groupBox2.TabStop = false;
            // 
            // lblTableNumberTwo
            // 
            this.lblTableNumberTwo.AutoSize = true;
            this.lblTableNumberTwo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumberTwo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTableNumberTwo.Location = new System.Drawing.Point(183, 331);
            this.lblTableNumberTwo.Name = "lblTableNumberTwo";
            this.lblTableNumberTwo.Size = new System.Drawing.Size(58, 16);
            this.lblTableNumberTwo.TabIndex = 35;
            this.lblTableNumberTwo.Text = "----------";
            // 
            // lblTableNumberOne
            // 
            this.lblTableNumberOne.AutoSize = true;
            this.lblTableNumberOne.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumberOne.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTableNumberOne.Location = new System.Drawing.Point(183, 50);
            this.lblTableNumberOne.Name = "lblTableNumberOne";
            this.lblTableNumberOne.Size = new System.Drawing.Size(58, 16);
            this.lblTableNumberOne.TabIndex = 34;
            this.lblTableNumberOne.Text = "----------";
            // 
            // labelNowServing2
            // 
            this.labelNowServing2.AutoSize = true;
            this.labelNowServing2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNowServing2.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelNowServing2.Location = new System.Drawing.Point(9, 331);
            this.labelNowServing2.Name = "labelNowServing2";
            this.labelNowServing2.Size = new System.Drawing.Size(51, 19);
            this.labelNowServing2.TabIndex = 30;
            this.labelNowServing2.Text = "------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 28);
            this.label7.TabIndex = 29;
            this.label7.Text = "REGULAR LANE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SeaGreen;
            this.label9.Location = new System.Drawing.Point(9, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Now Serving";
            // 
            // textNowServing2
            // 
            this.textNowServing2.BackColor = System.Drawing.Color.White;
            this.textNowServing2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNowServing2.Font = new System.Drawing.Font("Century Gothic", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNowServing2.ForeColor = System.Drawing.Color.Crimson;
            this.textNowServing2.Location = new System.Drawing.Point(13, 353);
            this.textNowServing2.Name = "textNowServing2";
            this.textNowServing2.ReadOnly = true;
            this.textNowServing2.Size = new System.Drawing.Size(407, 164);
            this.textNowServing2.TabIndex = 26;
            this.textNowServing2.Text = "0";
            this.textNowServing2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblPriorityTable3);
            this.groupBox1.Controls.Add(this.lblPriorityTable2);
            this.groupBox1.Controls.Add(this.lblNowservingPriority3);
            this.groupBox1.Controls.Add(this.labelPriorityTable1);
            this.groupBox1.Controls.Add(this.textPriority3);
            this.groupBox1.Controls.Add(this.lblNowservingPriority2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textPriority1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textPriority2);
            this.groupBox1.Location = new System.Drawing.Point(452, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 692);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            // 
            // lblPriorityTable2
            // 
            this.lblPriorityTable2.AutoSize = true;
            this.lblPriorityTable2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityTable2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPriorityTable2.Location = new System.Drawing.Point(192, 336);
            this.lblPriorityTable2.Name = "lblPriorityTable2";
            this.lblPriorityTable2.Size = new System.Drawing.Size(58, 16);
            this.lblPriorityTable2.TabIndex = 35;
            this.lblPriorityTable2.Text = "----------";
            // 
            // labelPriorityTable1
            // 
            this.labelPriorityTable1.AutoSize = true;
            this.labelPriorityTable1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriorityTable1.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelPriorityTable1.Location = new System.Drawing.Point(192, 55);
            this.labelPriorityTable1.Name = "labelPriorityTable1";
            this.labelPriorityTable1.Size = new System.Drawing.Size(58, 16);
            this.labelPriorityTable1.TabIndex = 34;
            this.labelPriorityTable1.Text = "----------";
            // 
            // lblNowservingPriority2
            // 
            this.lblNowservingPriority2.AutoSize = true;
            this.lblNowservingPriority2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowservingPriority2.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblNowservingPriority2.Location = new System.Drawing.Point(18, 336);
            this.lblNowservingPriority2.Name = "lblNowservingPriority2";
            this.lblNowservingPriority2.Size = new System.Drawing.Size(51, 19);
            this.lblNowservingPriority2.TabIndex = 30;
            this.lblNowservingPriority2.Text = "------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 28);
            this.label11.TabIndex = 29;
            this.label11.Text = "PRIORITY LANE";
            // 
            // textPriority1
            // 
            this.textPriority1.BackColor = System.Drawing.Color.White;
            this.textPriority1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPriority1.Font = new System.Drawing.Font("Century Gothic", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPriority1.ForeColor = System.Drawing.Color.Crimson;
            this.textPriority1.Location = new System.Drawing.Point(13, 77);
            this.textPriority1.Name = "textPriority1";
            this.textPriority1.ReadOnly = true;
            this.textPriority1.Size = new System.Drawing.Size(407, 246);
            this.textPriority1.TabIndex = 1;
            this.textPriority1.Text = "0";
            this.textPriority1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SeaGreen;
            this.label13.Location = new System.Drawing.Point(18, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "Now Serving";
            // 
            // textPriority2
            // 
            this.textPriority2.BackColor = System.Drawing.Color.White;
            this.textPriority2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPriority2.Font = new System.Drawing.Font("Century Gothic", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPriority2.ForeColor = System.Drawing.Color.Crimson;
            this.textPriority2.Location = new System.Drawing.Point(13, 355);
            this.textPriority2.Name = "textPriority2";
            this.textPriority2.ReadOnly = true;
            this.textPriority2.Size = new System.Drawing.Size(407, 164);
            this.textPriority2.TabIndex = 26;
            this.textPriority2.Text = "0";
            this.textPriority2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNowServing1
            // 
            this.textNowServing1.BackColor = System.Drawing.Color.White;
            this.textNowServing1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNowServing1.Font = new System.Drawing.Font("Century Gothic", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNowServing1.ForeColor = System.Drawing.Color.Crimson;
            this.textNowServing1.Location = new System.Drawing.Point(13, 69);
            this.textNowServing1.Name = "textNowServing1";
            this.textNowServing1.ReadOnly = true;
            this.textNowServing1.Size = new System.Drawing.Size(407, 246);
            this.textNowServing1.TabIndex = 36;
            this.textNowServing1.Text = "0";
            this.textNowServing1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTableThird
            // 
            this.labelTableThird.AutoSize = true;
            this.labelTableThird.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableThird.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelTableThird.Location = new System.Drawing.Point(183, 520);
            this.labelTableThird.Name = "labelTableThird";
            this.labelTableThird.Size = new System.Drawing.Size(58, 16);
            this.labelTableThird.TabIndex = 39;
            this.labelTableThird.Text = "----------";
            // 
            // labelNowServing3
            // 
            this.labelNowServing3.AutoSize = true;
            this.labelNowServing3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNowServing3.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelNowServing3.Location = new System.Drawing.Point(9, 520);
            this.labelNowServing3.Name = "labelNowServing3";
            this.labelNowServing3.Size = new System.Drawing.Size(51, 19);
            this.labelNowServing3.TabIndex = 38;
            this.labelNowServing3.Text = "------";
            // 
            // textNowServing3
            // 
            this.textNowServing3.BackColor = System.Drawing.Color.White;
            this.textNowServing3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNowServing3.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNowServing3.ForeColor = System.Drawing.Color.Crimson;
            this.textNowServing3.Location = new System.Drawing.Point(13, 557);
            this.textNowServing3.Name = "textNowServing3";
            this.textNowServing3.ReadOnly = true;
            this.textNowServing3.Size = new System.Drawing.Size(407, 118);
            this.textNowServing3.TabIndex = 37;
            this.textNowServing3.Text = "0";
            this.textNowServing3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPriority3
            // 
            this.textPriority3.BackColor = System.Drawing.Color.White;
            this.textPriority3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPriority3.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPriority3.ForeColor = System.Drawing.Color.Crimson;
            this.textPriority3.Location = new System.Drawing.Point(13, 557);
            this.textPriority3.Name = "textPriority3";
            this.textPriority3.ReadOnly = true;
            this.textPriority3.Size = new System.Drawing.Size(416, 118);
            this.textPriority3.TabIndex = 37;
            this.textPriority3.Text = "0";
            this.textPriority3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNowservingPriority3
            // 
            this.lblNowservingPriority3.AutoSize = true;
            this.lblNowservingPriority3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowservingPriority3.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblNowservingPriority3.Location = new System.Drawing.Point(18, 535);
            this.lblNowservingPriority3.Name = "lblNowservingPriority3";
            this.lblNowservingPriority3.Size = new System.Drawing.Size(51, 19);
            this.lblNowservingPriority3.TabIndex = 38;
            this.lblNowservingPriority3.Text = "------";
            // 
            // lblPriorityTable3
            // 
            this.lblPriorityTable3.AutoSize = true;
            this.lblPriorityTable3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityTable3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPriorityTable3.Location = new System.Drawing.Point(192, 535);
            this.lblPriorityTable3.Name = "lblPriorityTable3";
            this.lblPriorityTable3.Size = new System.Drawing.Size(58, 16);
            this.lblPriorityTable3.TabIndex = 39;
            this.lblPriorityTable3.Text = "----------";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(888, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 693);
            this.panel2.TabIndex = 160;
            // 
            // datagridConfirmedData
            // 
            this.datagridConfirmedData.AllowUserToAddRows = false;
            this.datagridConfirmedData.AllowUserToDeleteRows = false;
            this.datagridConfirmedData.BackgroundColor = System.Drawing.Color.White;
            this.datagridConfirmedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridConfirmedData.DefaultCellStyle = dataGridViewCellStyle1;
            this.datagridConfirmedData.Location = new System.Drawing.Point(6, 55);
            this.datagridConfirmedData.Name = "datagridConfirmedData";
            this.datagridConfirmedData.ReadOnly = true;
            this.datagridConfirmedData.RowHeadersVisible = false;
            this.datagridConfirmedData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridConfirmedData.Size = new System.Drawing.Size(312, 620);
            this.datagridConfirmedData.TabIndex = 0;
            // 
            // frmExtended
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbllane);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.lbltblnumber);
            this.Controls.Add(this.lblcaller);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pic_loading);
            this.Controls.Add(this.pic_check);
            this.Controls.Add(this.lblconstatus);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExtended";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Extended";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExtended_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_check)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridConfirmedData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer numbertimer;
        private System.Windows.Forms.PictureBox pic_loading;
        private System.Windows.Forms.PictureBox pic_check;
        private System.Windows.Forms.Label lblconstatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label lblcaller;
        private System.Windows.Forms.Label lbltblnumber;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lbllane;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTableNumberTwo;
        private System.Windows.Forms.Label lblTableNumberOne;
        private System.Windows.Forms.Label labelNowServing2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textNowServing2;
        private System.Windows.Forms.Label labelTableThird;
        private System.Windows.Forms.Label labelNowServing3;
        private System.Windows.Forms.TextBox textNowServing3;
        private System.Windows.Forms.TextBox textNowServing1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPriorityTable3;
        private System.Windows.Forms.Label lblPriorityTable2;
        private System.Windows.Forms.Label lblNowservingPriority3;
        private System.Windows.Forms.Label labelPriorityTable1;
        private System.Windows.Forms.TextBox textPriority3;
        private System.Windows.Forms.Label lblNowservingPriority2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textPriority1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textPriority2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView datagridConfirmedData;
    }
}