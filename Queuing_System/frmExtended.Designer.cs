
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
            this.label65 = new System.Windows.Forms.Label();
            this.lblcaller = new System.Windows.Forms.Label();
            this.lbltblnumber = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lbllane = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textCounter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datagridConfirmedData = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textNowServing1 = new System.Windows.Forms.TextBox();
            this.lblTableNumberOne = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPriorityTable1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textPriority1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressbartimer = new System.Windows.Forms.Timer(this.components);
            this.callerdata = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_loading = new System.Windows.Forms.PictureBox();
            this.pic_check = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridConfirmedData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_check)).BeginInit();
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
            this.lblconstatus.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconstatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblconstatus.Location = new System.Drawing.Point(413, 12);
            this.lblconstatus.Name = "lblconstatus";
            this.lblconstatus.Size = new System.Drawing.Size(105, 16);
            this.lblconstatus.TabIndex = 62;
            this.lblconstatus.Text = "Connection Secured.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(321, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "Connection Status:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SeaGreen;
            this.label12.Location = new System.Drawing.Point(132, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 19);
            this.label12.TabIndex = 33;
            this.label12.Text = "CIS Queuing System";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(544, 13);
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
            this.lblcaller.Location = new System.Drawing.Point(611, 13);
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
            this.lbltblnumber.Location = new System.Drawing.Point(967, 13);
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
            this.lblnumber.Location = new System.Drawing.Point(928, 13);
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
            this.lbllane.Location = new System.Drawing.Point(1006, 13);
            this.lbllane.Name = "lbllane";
            this.lbllane.Size = new System.Drawing.Size(22, 15);
            this.lbllane.TabIndex = 151;
            this.lbllane.Text = "-----";
            this.lbllane.Visible = false;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel12.BackColor = System.Drawing.Color.Teal;
            this.panel12.Location = new System.Drawing.Point(520, 34);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(5, 685);
            this.panel12.TabIndex = 160;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.pictureBox9);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Controls.Add(this.textCounter);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.datagridConfirmedData);
            this.groupBox3.Location = new System.Drawing.Point(1050, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 688);
            this.groupBox3.TabIndex = 155;
            this.groupBox3.TabStop = false;
            // 
            // textCounter
            // 
            this.textCounter.BackColor = System.Drawing.Color.White;
            this.textCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCounter.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCounter.ForeColor = System.Drawing.Color.Crimson;
            this.textCounter.Location = new System.Drawing.Point(103, 199);
            this.textCounter.Name = "textCounter";
            this.textCounter.ReadOnly = true;
            this.textCounter.Size = new System.Drawing.Size(151, 59);
            this.textCounter.TabIndex = 37;
            this.textCounter.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(37, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Total persons served";
            // 
            // datagridConfirmedData
            // 
            this.datagridConfirmedData.AllowUserToAddRows = false;
            this.datagridConfirmedData.AllowUserToDeleteRows = false;
            this.datagridConfirmedData.BackgroundColor = System.Drawing.Color.White;
            this.datagridConfirmedData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridConfirmedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridConfirmedData.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridConfirmedData.DefaultCellStyle = dataGridViewCellStyle1;
            this.datagridConfirmedData.GridColor = System.Drawing.Color.White;
            this.datagridConfirmedData.Location = new System.Drawing.Point(6, 264);
            this.datagridConfirmedData.Name = "datagridConfirmedData";
            this.datagridConfirmedData.ReadOnly = true;
            this.datagridConfirmedData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridConfirmedData.RowHeadersVisible = false;
            this.datagridConfirmedData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridConfirmedData.Size = new System.Drawing.Size(276, 418);
            this.datagridConfirmedData.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.textNowServing1);
            this.groupBox2.Controls.Add(this.lblTableNumberOne);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(9, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 692);
            this.groupBox2.TabIndex = 153;
            this.groupBox2.TabStop = false;
            // 
            // textNowServing1
            // 
            this.textNowServing1.BackColor = System.Drawing.Color.White;
            this.textNowServing1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNowServing1.Font = new System.Drawing.Font("Century Gothic", 219.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNowServing1.ForeColor = System.Drawing.Color.Crimson;
            this.textNowServing1.Location = new System.Drawing.Point(8, 164);
            this.textNowServing1.Name = "textNowServing1";
            this.textNowServing1.ReadOnly = true;
            this.textNowServing1.Size = new System.Drawing.Size(499, 360);
            this.textNowServing1.TabIndex = 36;
            this.textNowServing1.Text = "0";
            this.textNowServing1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTableNumberOne
            // 
            this.lblTableNumberOne.AutoSize = true;
            this.lblTableNumberOne.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumberOne.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTableNumberOne.Location = new System.Drawing.Point(40, 527);
            this.lblTableNumberOne.Name = "lblTableNumberOne";
            this.lblTableNumberOne.Size = new System.Drawing.Size(441, 112);
            this.lblTableNumberOne.TabIndex = 34;
            this.lblTableNumberOne.Text = "TABLE 00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(75, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 56);
            this.label7.TabIndex = 29;
            this.label7.Text = "REGULAR LANE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SeaGreen;
            this.label9.Location = new System.Drawing.Point(67, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 38);
            this.label9.TabIndex = 12;
            this.label9.Text = "Now Serving";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.labelPriorityTable1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textPriority1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(525, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 692);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            // 
            // labelPriorityTable1
            // 
            this.labelPriorityTable1.AutoSize = true;
            this.labelPriorityTable1.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriorityTable1.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelPriorityTable1.Location = new System.Drawing.Point(44, 527);
            this.labelPriorityTable1.Name = "labelPriorityTable1";
            this.labelPriorityTable1.Size = new System.Drawing.Size(441, 112);
            this.labelPriorityTable1.TabIndex = 34;
            this.labelPriorityTable1.Text = "TABLE 00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(77, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(354, 56);
            this.label11.TabIndex = 29;
            this.label11.Text = "PRIORITY LANE";
            // 
            // textPriority1
            // 
            this.textPriority1.BackColor = System.Drawing.Color.White;
            this.textPriority1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPriority1.Font = new System.Drawing.Font("Century Gothic", 219.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPriority1.ForeColor = System.Drawing.Color.Blue;
            this.textPriority1.Location = new System.Drawing.Point(5, 164);
            this.textPriority1.Name = "textPriority1";
            this.textPriority1.ReadOnly = true;
            this.textPriority1.Size = new System.Drawing.Size(499, 360);
            this.textPriority1.TabIndex = 1;
            this.textPriority1.Text = "0";
            this.textPriority1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SeaGreen;
            this.label13.Location = new System.Drawing.Point(68, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 38);
            this.label13.TabIndex = 12;
            this.label13.Text = "Now Serving";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(1039, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 685);
            this.panel2.TabIndex = 160;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(674, 17);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(231, 10);
            this.progressBar1.TabIndex = 37;
            // 
            // progressbartimer
            // 
            this.progressbartimer.Interval = 50;
            this.progressbartimer.Tick += new System.EventHandler(this.progressbartimer_Tick);
            // 
            // callerdata
            // 
            this.callerdata.Tick += new System.EventHandler(this.callerdata_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(976, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 162;
            this.label2.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.Color.Black;
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelTime.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Red;
            this.labelTime.Location = new System.Drawing.Point(7, 17);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(270, 57);
            this.labelTime.TabIndex = 40;
            this.labelTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(59, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 41;
            this.label1.Text = "TIME TODAY";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelTime);
            this.groupBox4.Location = new System.Drawing.Point(3, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 89);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Queuing_System.Properties.Resources.dswdlogo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 161;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Queuing_System.Properties.Resources.leftarrow;
            this.pictureBox8.Location = new System.Drawing.Point(283, 128);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(108, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 40;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Queuing_System.Properties.Resources.icons8_express_20;
            this.pictureBox5.Location = new System.Drawing.Point(31, 19);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Queuing_System.Properties.Resources.icons8_verify_50;
            this.pictureBox3.Location = new System.Drawing.Point(22, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Queuing_System.Properties.Resources.icons8_clock_96;
            this.pictureBox9.Location = new System.Drawing.Point(10, 15);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(43, 39);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 43;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Queuing_System.Properties.Resources.Increase_gif;
            this.pictureBox6.Location = new System.Drawing.Point(44, 199);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(53, 59);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 39;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Queuing_System.Properties.Resources.leftarrow;
            this.pictureBox7.Location = new System.Drawing.Point(282, 128);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(108, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 39;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Queuing_System.Properties.Resources.icons8_journey_20;
            this.pictureBox4.Location = new System.Drawing.Point(38, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Queuing_System.Properties.Resources.icons8_verify_50;
            this.pictureBox2.Location = new System.Drawing.Point(21, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pic_loading
            // 
            this.pic_loading.Image = global::Queuing_System.Properties.Resources.loading;
            this.pic_loading.Location = new System.Drawing.Point(300, 13);
            this.pic_loading.Name = "pic_loading";
            this.pic_loading.Size = new System.Drawing.Size(15, 15);
            this.pic_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_loading.TabIndex = 64;
            this.pic_loading.TabStop = false;
            // 
            // pic_check
            // 
            this.pic_check.Image = global::Queuing_System.Properties.Resources.icons8_check_96;
            this.pic_check.Location = new System.Drawing.Point(300, 13);
            this.pic_check.Name = "pic_check";
            this.pic_check.Size = new System.Drawing.Size(15, 15);
            this.pic_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_check.TabIndex = 63;
            this.pic_check.TabStop = false;
            // 
            // frmExtended
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridConfirmedData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_check)).EndInit();
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
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label lblcaller;
        private System.Windows.Forms.Label lbltblnumber;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lbllane;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTableNumberOne;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textNowServing1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPriorityTable1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textPriority1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView datagridConfirmedData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer progressbartimer;
        private System.Windows.Forms.Timer callerdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCounter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labelTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}