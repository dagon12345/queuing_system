﻿
namespace Queuing_System
{
    partial class Main_menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_menu));
            this.btn_add = new System.Windows.Forms.Button();
            this.datetodaylbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.check_onhold = new System.Windows.Forms.CheckBox();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.lblreason = new System.Windows.Forms.Label();
            this.txttable = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtlane = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtstaon = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtholdtableno = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtholdcategory = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtholdlane = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtholdnumber = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtholddate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.timer_confirmed = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(134, 189);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(99, 32);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Confirm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // datetodaylbl
            // 
            this.datetodaylbl.AutoSize = true;
            this.datetodaylbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetodaylbl.Location = new System.Drawing.Point(101, 66);
            this.datetodaylbl.Name = "datetodaylbl";
            this.datetodaylbl.Size = new System.Drawing.Size(58, 16);
            this.datetodaylbl.TabIndex = 1;
            this.datetodaylbl.Text = "----------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Today:";
            // 
            // datetimer
            // 
            this.datetimer.Interval = 1000;
            this.datetimer.Tick += new System.EventHandler(this.datetimer_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(423, 274);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            this.dataGridView1.MouseHover += new System.EventHandler(this.dataGridView1_MouseHover);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(385, 99);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(54, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Reset";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(191, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Verifying Form";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(463, 124);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(425, 276);
            this.dataGridView2.TabIndex = 31;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.MouseLeave += new System.EventHandler(this.dataGridView2_MouseLeave);
            this.dataGridView2.MouseHover += new System.EventHandler(this.dataGridView2_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(8, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Waiting for verification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(462, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Numbers On-Hold";
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert.FlatAppearance.BorderSize = 0;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.Location = new System.Drawing.Point(131, 170);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(103, 32);
            this.btn_insert.TabIndex = 34;
            this.btn_insert.Text = "Complied";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(88, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Date";
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.White;
            this.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtdate.Location = new System.Drawing.Point(134, 19);
            this.txtdate.Multiline = true;
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(273, 20);
            this.txtdate.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Location = new System.Drawing.Point(907, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 549);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(7, 289);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(286, 249);
            this.dataGridView4.TabIndex = 41;
            this.dataGridView4.MouseLeave += new System.EventHandler(this.dataGridView4_MouseLeave);
            this.dataGridView4.MouseHover += new System.EventHandler(this.dataGridView4_MouseHover);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(6, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 15);
            this.label10.TabIndex = 42;
            this.label10.Text = "Queued Numbers (Express Lane)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SeaGreen;
            this.label9.Location = new System.Drawing.Point(4, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "Queued Numbers (Regular Lane)";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(7, 28);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(287, 240);
            this.dataGridView3.TabIndex = 40;
            this.dataGridView3.MouseLeave += new System.EventHandler(this.dataGridView3_MouseLeave);
            this.dataGridView3.MouseHover += new System.EventHandler(this.dataGridView3_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Queuing_System.Properties.Resources.dswdlogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check_onhold);
            this.groupBox3.Controls.Add(this.txt_reason);
            this.groupBox3.Controls.Add(this.lblreason);
            this.groupBox3.Controls.Add(this.txttable);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtcategory);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtlane);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtnumber);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtdate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Location = new System.Drawing.Point(16, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 231);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            // 
            // check_onhold
            // 
            this.check_onhold.AutoSize = true;
            this.check_onhold.Location = new System.Drawing.Point(133, 167);
            this.check_onhold.Name = "check_onhold";
            this.check_onhold.Size = new System.Drawing.Size(84, 17);
            this.check_onhold.TabIndex = 42;
            this.check_onhold.Text = "Put On-Hold";
            this.check_onhold.UseVisualStyleBackColor = true;
            this.check_onhold.Visible = false;
            this.check_onhold.CheckedChanged += new System.EventHandler(this.check_onhold_CheckedChanged);
            // 
            // txt_reason
            // 
            this.txt_reason.BackColor = System.Drawing.Color.White;
            this.txt_reason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_reason.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reason.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_reason.Location = new System.Drawing.Point(133, 141);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(274, 20);
            this.txt_reason.TabIndex = 40;
            this.txt_reason.Visible = false;
            // 
            // lblreason
            // 
            this.lblreason.AutoSize = true;
            this.lblreason.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreason.ForeColor = System.Drawing.Color.Crimson;
            this.lblreason.Location = new System.Drawing.Point(72, 142);
            this.lblreason.Name = "lblreason";
            this.lblreason.Size = new System.Drawing.Size(51, 16);
            this.lblreason.TabIndex = 41;
            this.lblreason.Text = "Reason";
            this.lblreason.Visible = false;
            // 
            // txttable
            // 
            this.txttable.BackColor = System.Drawing.Color.White;
            this.txttable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttable.ForeColor = System.Drawing.Color.SeaGreen;
            this.txttable.Location = new System.Drawing.Point(134, 115);
            this.txttable.Multiline = true;
            this.txttable.Name = "txttable";
            this.txttable.ReadOnly = true;
            this.txttable.Size = new System.Drawing.Size(273, 20);
            this.txttable.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(32, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "Table Number";
            // 
            // txtcategory
            // 
            this.txtcategory.BackColor = System.Drawing.Color.White;
            this.txtcategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategory.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtcategory.Location = new System.Drawing.Point(134, 91);
            this.txtcategory.Multiline = true;
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.ReadOnly = true;
            this.txtcategory.Size = new System.Drawing.Size(273, 20);
            this.txtcategory.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(60, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "Category";
            // 
            // txtlane
            // 
            this.txtlane.BackColor = System.Drawing.Color.White;
            this.txtlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlane.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlane.ForeColor = System.Drawing.Color.Crimson;
            this.txtlane.Location = new System.Drawing.Point(134, 67);
            this.txtlane.Multiline = true;
            this.txtlane.Name = "txtlane";
            this.txtlane.ReadOnly = true;
            this.txtlane.Size = new System.Drawing.Size(273, 20);
            this.txtlane.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(87, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Lane";
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.Color.White;
            this.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumber.ForeColor = System.Drawing.Color.Crimson;
            this.txtnumber.Location = new System.Drawing.Point(134, 43);
            this.txtnumber.Multiline = true;
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.ReadOnly = true;
            this.txtnumber.Size = new System.Drawing.Size(273, 20);
            this.txtnumber.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "Selected Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SeaGreen;
            this.label15.Location = new System.Drawing.Point(12, 413);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 19);
            this.label15.TabIndex = 42;
            this.label15.Text = "Selected details";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(341, 406);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(98, 26);
            this.btn_refresh.TabIndex = 43;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(790, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 26);
            this.button1.TabIndex = 46;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(463, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "Selected details";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtstaon);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtholdtableno);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtholdcategory);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtholdlane);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtholdnumber);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtholddate);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.btn_insert);
            this.groupBox4.Location = new System.Drawing.Point(463, 430);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 231);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            // 
            // txtstaon
            // 
            this.txtstaon.BackColor = System.Drawing.Color.White;
            this.txtstaon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstaon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstaon.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtstaon.Location = new System.Drawing.Point(131, 143);
            this.txtstaon.Multiline = true;
            this.txtstaon.Name = "txtstaon";
            this.txtstaon.ReadOnly = true;
            this.txtstaon.Size = new System.Drawing.Size(288, 20);
            this.txtstaon.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(85, 145);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 16);
            this.label21.TabIndex = 39;
            this.label21.Text = "Status";
            // 
            // txtholdtableno
            // 
            this.txtholdtableno.BackColor = System.Drawing.Color.White;
            this.txtholdtableno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtholdtableno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtholdtableno.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtholdtableno.Location = new System.Drawing.Point(131, 118);
            this.txtholdtableno.Multiline = true;
            this.txtholdtableno.Name = "txtholdtableno";
            this.txtholdtableno.ReadOnly = true;
            this.txtholdtableno.Size = new System.Drawing.Size(288, 20);
            this.txtholdtableno.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(34, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 16);
            this.label16.TabIndex = 37;
            this.label16.Text = "Table Number";
            // 
            // txtholdcategory
            // 
            this.txtholdcategory.BackColor = System.Drawing.Color.White;
            this.txtholdcategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtholdcategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtholdcategory.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtholdcategory.Location = new System.Drawing.Point(131, 93);
            this.txtholdcategory.Multiline = true;
            this.txtholdcategory.Name = "txtholdcategory";
            this.txtholdcategory.ReadOnly = true;
            this.txtholdcategory.Size = new System.Drawing.Size(288, 20);
            this.txtholdcategory.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(62, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 16);
            this.label17.TabIndex = 37;
            this.label17.Text = "Category";
            // 
            // txtholdlane
            // 
            this.txtholdlane.BackColor = System.Drawing.Color.White;
            this.txtholdlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtholdlane.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtholdlane.ForeColor = System.Drawing.Color.Crimson;
            this.txtholdlane.Location = new System.Drawing.Point(131, 68);
            this.txtholdlane.Multiline = true;
            this.txtholdlane.Name = "txtholdlane";
            this.txtholdlane.ReadOnly = true;
            this.txtholdlane.Size = new System.Drawing.Size(288, 20);
            this.txtholdlane.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(89, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 16);
            this.label18.TabIndex = 37;
            this.label18.Text = "Lane";
            // 
            // txtholdnumber
            // 
            this.txtholdnumber.BackColor = System.Drawing.Color.White;
            this.txtholdnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtholdnumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtholdnumber.ForeColor = System.Drawing.Color.Crimson;
            this.txtholdnumber.Location = new System.Drawing.Point(131, 43);
            this.txtholdnumber.Multiline = true;
            this.txtholdnumber.Name = "txtholdnumber";
            this.txtholdnumber.ReadOnly = true;
            this.txtholdnumber.Size = new System.Drawing.Size(288, 20);
            this.txtholdnumber.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(15, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 16);
            this.label19.TabIndex = 37;
            this.label19.Text = "Selected Number";
            // 
            // txtholddate
            // 
            this.txtholddate.BackColor = System.Drawing.Color.White;
            this.txtholddate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtholddate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtholddate.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtholddate.Location = new System.Drawing.Point(131, 18);
            this.txtholddate.Multiline = true;
            this.txtholddate.Name = "txtholddate";
            this.txtholddate.ReadOnly = true;
            this.txtholddate.Size = new System.Drawing.Size(288, 20);
            this.txtholddate.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(90, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 16);
            this.label20.TabIndex = 37;
            this.label20.Text = "Date";
            // 
            // timer_confirmed
            // 
            this.timer_confirmed.Tick += new System.EventHandler(this.timer_confirmed_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(256, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Location = new System.Drawing.Point(256, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 48;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(283, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 16);
            this.label22.TabIndex = 49;
            this.label22.Text = "Regular Lane";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(283, 101);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 16);
            this.label23.TabIndex = 50;
            this.label23.Text = "Express Lane";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(449, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 596);
            this.panel3.TabIndex = 51;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(10, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1183, 5);
            this.panel4.TabIndex = 52;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.Location = new System.Drawing.Point(896, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 596);
            this.panel5.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(902, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Confirmed Numbers";
            // 
            // Main_menu
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 668);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datetodaylbl);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_delete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Numbers";
            this.Load += new System.EventHandler(this.Main_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label datetodaylbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer datetimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txttable;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtlane;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtholdtableno;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtholdcategory;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtholdlane;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtholdnumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtholddate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtstaon;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Timer timer_confirmed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label lblreason;
        private System.Windows.Forms.CheckBox check_onhold;
    }
}

