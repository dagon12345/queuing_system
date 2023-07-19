
namespace Queuing_System
{
    partial class frm_GenerateNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GenerateNumbers));
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_category = new System.Windows.Forms.GroupBox();
            this.rb_senior = new System.Windows.Forms.RadioButton();
            this.rb_lactating = new System.Windows.Forms.RadioButton();
            this.rb_pregnant = new System.Windows.Forms.RadioButton();
            this.rb_pwd = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pic_check = new System.Windows.Forms.PictureBox();
            this.pic_loading = new System.Windows.Forms.PictureBox();
            this.lblstatus = new System.Windows.Forms.TextBox();
            this.datagridonholdexpress = new System.Windows.Forms.DataGridView();
            this.txtonholdpriority = new System.Windows.Forms.TextBox();
            this.txtonholdregular = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_connection = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagridexpress = new System.Windows.Forms.DataGridView();
            this.datagridonholdregular = new System.Windows.Forms.DataGridView();
            this.txt_prioritylane = new System.Windows.Forms.TextBox();
            this.datagridregularlane = new System.Windows.Forms.DataGridView();
            this.txt_regularlane = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mynumber = new System.Windows.Forms.TextBox();
            this.date_timer = new System.Windows.Forms.Timer(this.components);
            this.txt_date = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_lane = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.grp_category.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridonholdexpress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridexpress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridonholdregular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridregularlane)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SeaGreen;
            this.label10.Location = new System.Drawing.Point(178, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 25);
            this.label10.TabIndex = 42;
            this.label10.Text = "Lane";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(20, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Category(for express lane only)";
            // 
            // grp_category
            // 
            this.grp_category.Controls.Add(this.rb_senior);
            this.grp_category.Controls.Add(this.rb_lactating);
            this.grp_category.Controls.Add(this.rb_pregnant);
            this.grp_category.Controls.Add(this.rb_pwd);
            this.grp_category.Location = new System.Drawing.Point(18, 165);
            this.grp_category.Name = "grp_category";
            this.grp_category.Size = new System.Drawing.Size(399, 93);
            this.grp_category.TabIndex = 2;
            this.grp_category.TabStop = false;
            // 
            // rb_senior
            // 
            this.rb_senior.AutoSize = true;
            this.rb_senior.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_senior.Location = new System.Drawing.Point(253, 55);
            this.rb_senior.Name = "rb_senior";
            this.rb_senior.Size = new System.Drawing.Size(72, 22);
            this.rb_senior.TabIndex = 47;
            this.rb_senior.TabStop = true;
            this.rb_senior.Text = "Senior";
            this.rb_senior.UseVisualStyleBackColor = true;
            this.rb_senior.CheckedChanged += new System.EventHandler(this.rb_senior_CheckedChanged_1);
            // 
            // rb_lactating
            // 
            this.rb_lactating.AutoSize = true;
            this.rb_lactating.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_lactating.Location = new System.Drawing.Point(253, 19);
            this.rb_lactating.Name = "rb_lactating";
            this.rb_lactating.Size = new System.Drawing.Size(94, 22);
            this.rb_lactating.TabIndex = 46;
            this.rb_lactating.TabStop = true;
            this.rb_lactating.Text = "Lactating";
            this.rb_lactating.UseVisualStyleBackColor = true;
            this.rb_lactating.CheckedChanged += new System.EventHandler(this.rb_lactating_CheckedChanged);
            // 
            // rb_pregnant
            // 
            this.rb_pregnant.AutoSize = true;
            this.rb_pregnant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_pregnant.Location = new System.Drawing.Point(6, 55);
            this.rb_pregnant.Name = "rb_pregnant";
            this.rb_pregnant.Size = new System.Drawing.Size(91, 22);
            this.rb_pregnant.TabIndex = 46;
            this.rb_pregnant.TabStop = true;
            this.rb_pregnant.Text = "Pregnant";
            this.rb_pregnant.UseVisualStyleBackColor = true;
            this.rb_pregnant.CheckedChanged += new System.EventHandler(this.rb_pregnant_CheckedChanged);
            // 
            // rb_pwd
            // 
            this.rb_pwd.AutoSize = true;
            this.rb_pwd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_pwd.Location = new System.Drawing.Point(6, 19);
            this.rb_pwd.Name = "rb_pwd";
            this.rb_pwd.Size = new System.Drawing.Size(221, 22);
            this.rb_pwd.TabIndex = 46;
            this.rb_pwd.TabStop = true;
            this.rb_pwd.Text = "Person with disability(PWD)";
            this.rb_pwd.UseVisualStyleBackColor = true;
            this.rb_pwd.CheckedChanged += new System.EventHandler(this.rb_pwd_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pic_check);
            this.groupBox2.Controls.Add(this.pic_loading);
            this.groupBox2.Controls.Add(this.lblstatus);
            this.groupBox2.Controls.Add(this.datagridonholdexpress);
            this.groupBox2.Controls.Add(this.txtonholdpriority);
            this.groupBox2.Controls.Add(this.txtonholdregular);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbl_connection);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.datagridexpress);
            this.groupBox2.Controls.Add(this.datagridonholdregular);
            this.groupBox2.Controls.Add(this.txt_prioritylane);
            this.groupBox2.Controls.Add(this.datagridregularlane);
            this.groupBox2.Controls.Add(this.txt_regularlane);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(429, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 397);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pic_check
            // 
            this.pic_check.Image = global::Queuing_System.Properties.Resources.icons8_check_96;
            this.pic_check.Location = new System.Drawing.Point(115, 372);
            this.pic_check.Name = "pic_check";
            this.pic_check.Size = new System.Drawing.Size(19, 19);
            this.pic_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_check.TabIndex = 72;
            this.pic_check.TabStop = false;
            // 
            // pic_loading
            // 
            this.pic_loading.Image = global::Queuing_System.Properties.Resources.loading;
            this.pic_loading.Location = new System.Drawing.Point(115, 372);
            this.pic_loading.Name = "pic_loading";
            this.pic_loading.Size = new System.Drawing.Size(19, 19);
            this.pic_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_loading.TabIndex = 65;
            this.pic_loading.TabStop = false;
            // 
            // lblstatus
            // 
            this.lblstatus.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblstatus.Location = new System.Drawing.Point(54, 264);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(305, 43);
            this.lblstatus.TabIndex = 71;
            this.lblstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // datagridonholdexpress
            // 
            this.datagridonholdexpress.AllowUserToAddRows = false;
            this.datagridonholdexpress.AllowUserToDeleteRows = false;
            this.datagridonholdexpress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridonholdexpress.Location = new System.Drawing.Point(212, 129);
            this.datagridonholdexpress.Name = "datagridonholdexpress";
            this.datagridonholdexpress.ReadOnly = true;
            this.datagridonholdexpress.Size = new System.Drawing.Size(90, 10);
            this.datagridonholdexpress.TabIndex = 70;
            this.datagridonholdexpress.Visible = false;
            // 
            // txtonholdpriority
            // 
            this.txtonholdpriority.BackColor = System.Drawing.Color.White;
            this.txtonholdpriority.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtonholdpriority.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtonholdpriority.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtonholdpriority.Location = new System.Drawing.Point(212, 168);
            this.txtonholdpriority.Name = "txtonholdpriority";
            this.txtonholdpriority.ReadOnly = true;
            this.txtonholdpriority.Size = new System.Drawing.Size(147, 24);
            this.txtonholdpriority.TabIndex = 69;
            this.txtonholdpriority.Text = "0";
            // 
            // txtonholdregular
            // 
            this.txtonholdregular.BackColor = System.Drawing.Color.White;
            this.txtonholdregular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtonholdregular.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtonholdregular.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtonholdregular.Location = new System.Drawing.Point(9, 171);
            this.txtonholdregular.Name = "txtonholdregular";
            this.txtonholdregular.ReadOnly = true;
            this.txtonholdregular.Size = new System.Drawing.Size(139, 24);
            this.txtonholdregular.TabIndex = 68;
            this.txtonholdregular.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SeaGreen;
            this.label11.Location = new System.Drawing.Point(209, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 67;
            this.label11.Text = "Priority Lane";
            // 
            // lbl_connection
            // 
            this.lbl_connection.AutoSize = true;
            this.lbl_connection.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connection.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_connection.Location = new System.Drawing.Point(141, 373);
            this.lbl_connection.Name = "lbl_connection";
            this.lbl_connection.Size = new System.Drawing.Size(47, 15);
            this.lbl_connection.TabIndex = 57;
            this.lbl_connection.Text = "--------";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SeaGreen;
            this.label12.Location = new System.Drawing.Point(9, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 66;
            this.label12.Text = "Regular Lane";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.Location = new System.Drawing.Point(5, 202);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(387, 5);
            this.panel5.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 53;
            this.label6.Text = "Conection Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 56;
            this.label8.Text = "Printing Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(9, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 65;
            this.label9.Text = "On Hold Numbers:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Location = new System.Drawing.Point(6, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 5);
            this.panel4.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Location = new System.Drawing.Point(5, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 5);
            this.panel3.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(9, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "Confirmed Numbers:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(6, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 5);
            this.panel2.TabIndex = 61;
            // 
            // datagridexpress
            // 
            this.datagridexpress.AllowUserToAddRows = false;
            this.datagridexpress.AllowUserToDeleteRows = false;
            this.datagridexpress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridexpress.Location = new System.Drawing.Point(212, 33);
            this.datagridexpress.Name = "datagridexpress";
            this.datagridexpress.ReadOnly = true;
            this.datagridexpress.Size = new System.Drawing.Size(90, 10);
            this.datagridexpress.TabIndex = 62;
            this.datagridexpress.Visible = false;
            // 
            // datagridonholdregular
            // 
            this.datagridonholdregular.AllowUserToAddRows = false;
            this.datagridonholdregular.AllowUserToDeleteRows = false;
            this.datagridonholdregular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridonholdregular.Location = new System.Drawing.Point(9, 129);
            this.datagridonholdregular.Name = "datagridonholdregular";
            this.datagridonholdregular.ReadOnly = true;
            this.datagridonholdregular.Size = new System.Drawing.Size(90, 10);
            this.datagridonholdregular.TabIndex = 63;
            this.datagridonholdregular.Visible = false;
            // 
            // txt_prioritylane
            // 
            this.txt_prioritylane.BackColor = System.Drawing.Color.White;
            this.txt_prioritylane.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_prioritylane.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prioritylane.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_prioritylane.Location = new System.Drawing.Point(212, 69);
            this.txt_prioritylane.Name = "txt_prioritylane";
            this.txt_prioritylane.ReadOnly = true;
            this.txt_prioritylane.Size = new System.Drawing.Size(147, 24);
            this.txt_prioritylane.TabIndex = 51;
            this.txt_prioritylane.Text = "0";
            // 
            // datagridregularlane
            // 
            this.datagridregularlane.AllowUserToAddRows = false;
            this.datagridregularlane.AllowUserToDeleteRows = false;
            this.datagridregularlane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridregularlane.Location = new System.Drawing.Point(5, 33);
            this.datagridregularlane.Name = "datagridregularlane";
            this.datagridregularlane.ReadOnly = true;
            this.datagridregularlane.Size = new System.Drawing.Size(90, 10);
            this.datagridregularlane.TabIndex = 61;
            this.datagridregularlane.Visible = false;
            // 
            // txt_regularlane
            // 
            this.txt_regularlane.BackColor = System.Drawing.Color.White;
            this.txt_regularlane.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_regularlane.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regularlane.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_regularlane.Location = new System.Drawing.Point(9, 72);
            this.txt_regularlane.Name = "txt_regularlane";
            this.txt_regularlane.ReadOnly = true;
            this.txt_regularlane.Size = new System.Drawing.Size(139, 24);
            this.txt_regularlane.TabIndex = 50;
            this.txt_regularlane.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(209, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Priority Lane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Regular Lane";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(429, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Numbers on queue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(126, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Your Number";
            // 
            // txt_mynumber
            // 
            this.txt_mynumber.BackColor = System.Drawing.Color.White;
            this.txt_mynumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mynumber.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mynumber.ForeColor = System.Drawing.Color.Crimson;
            this.txt_mynumber.Location = new System.Drawing.Point(127, 53);
            this.txt_mynumber.Name = "txt_mynumber";
            this.txt_mynumber.ReadOnly = true;
            this.txt_mynumber.Size = new System.Drawing.Size(146, 34);
            this.txt_mynumber.TabIndex = 52;
            this.txt_mynumber.Text = "------";
            this.txt_mynumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date_timer
            // 
            this.date_timer.Enabled = true;
            this.date_timer.Tick += new System.EventHandler(this.date_timer_Tick);
            // 
            // txt_date
            // 
            this.txt_date.BackColor = System.Drawing.Color.White;
            this.txt_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_date.Enabled = false;
            this.txt_date.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_date.Location = new System.Drawing.Point(715, 42);
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(118, 14);
            this.txt_date.TabIndex = 55;
            this.txt_date.Text = "------";
            this.txt_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_mynumber);
            this.groupBox1.Location = new System.Drawing.Point(19, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 5);
            this.panel1.TabIndex = 60;
            // 
            // cmb_lane
            // 
            this.cmb_lane.BackColor = System.Drawing.Color.White;
            this.cmb_lane.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmb_lane.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_lane.ForeColor = System.Drawing.Color.Crimson;
            this.cmb_lane.Location = new System.Drawing.Point(19, 98);
            this.cmb_lane.Name = "cmb_lane";
            this.cmb_lane.ReadOnly = true;
            this.cmb_lane.Size = new System.Drawing.Size(398, 34);
            this.cmb_lane.TabIndex = 3;
            this.cmb_lane.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(19, 264);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(398, 36);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Queuing_System.Properties.Resources.dswdlogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generate.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.ForeColor = System.Drawing.Color.White;
            this.btn_generate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generate.Location = new System.Drawing.Point(24, 409);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(394, 82);
            this.btn_generate.TabIndex = 1;
            this.btn_generate.Text = "Generate my Ticket";
            this.btn_generate.UseVisualStyleBackColor = false;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SeaGreen;
            this.label13.Location = new System.Drawing.Point(264, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(400, 41);
            this.label13.TabIndex = 61;
            this.label13.Text = "GENERATING NUMBERS";
            // 
            // txt_time
            // 
            this.txt_time.BackColor = System.Drawing.Color.White;
            this.txt_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_time.Enabled = false;
            this.txt_time.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_time.Location = new System.Drawing.Point(715, 22);
            this.txt_time.Name = "txt_time";
            this.txt_time.ReadOnly = true;
            this.txt_time.Size = new System.Drawing.Size(118, 14);
            this.txt_time.TabIndex = 62;
            this.txt_time.Text = "------";
            this.txt_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_GenerateNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 519);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cmb_lane);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_category);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_GenerateNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Numbers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_GenerateNumbers_FormClosed);
            this.Load += new System.EventHandler(this.frm_GenerateNumbers_Load);
            this.grp_category.ResumeLayout(false);
            this.grp_category.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridonholdexpress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridexpress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridonholdregular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridregularlane)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_category;
        private System.Windows.Forms.RadioButton rb_lactating;
        private System.Windows.Forms.RadioButton rb_pregnant;
        private System.Windows.Forms.RadioButton rb_pwd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_prioritylane;
        private System.Windows.Forms.TextBox txt_regularlane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mynumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label lbl_connection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagridregularlane;
        public System.Windows.Forms.Timer date_timer;
        private System.Windows.Forms.DataGridView datagridexpress;
        private System.Windows.Forms.DataGridView datagridonholdregular;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtonholdpriority;
        private System.Windows.Forms.TextBox txtonholdregular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView datagridonholdexpress;
        private System.Windows.Forms.TextBox cmb_lane;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RadioButton rb_senior;
        private System.Windows.Forms.TextBox lblstatus;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pic_loading;
        private System.Windows.Forms.PictureBox pic_check;
        private System.Windows.Forms.TextBox txt_time;
    }
}