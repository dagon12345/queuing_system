
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
            this.textCounter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datagridConfirmedData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPriorityTable1 = new System.Windows.Forms.TextBox();
            this.richTextBoxDisplayPriority = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textPriority1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressbartimer = new System.Windows.Forms.Timer(this.components);
            this.callerdata = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.labelVoiceNumber = new System.Windows.Forms.Label();
            this.labelNameOfClient = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textNowServing1 = new System.Windows.Forms.TextBox();
            this.richTextBoxDisplayRegular = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTableNumberOne = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pic_loading = new System.Windows.Forms.PictureBox();
            this.pic_check = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridConfirmedData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // numbertimer
            // 
            this.numbertimer.Interval = 300;
            this.numbertimer.Tick += new System.EventHandler(this.numbertimer_Tick);
            // 
            // lblconstatus
            // 
            this.lblconstatus.AutoSize = true;
            this.lblconstatus.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconstatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblconstatus.Location = new System.Drawing.Point(413, 9);
            this.lblconstatus.Name = "lblconstatus";
            this.lblconstatus.Size = new System.Drawing.Size(105, 16);
            this.lblconstatus.TabIndex = 62;
            this.lblconstatus.Text = "Connection Secured.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(321, 9);
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
            this.label12.Location = new System.Drawing.Point(132, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 19);
            this.label12.TabIndex = 33;
            this.label12.Text = "CIS Queuing System";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(544, 8);
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
            this.lblcaller.Location = new System.Drawing.Point(611, 8);
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
            this.lbltblnumber.Location = new System.Drawing.Point(954, 0);
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
            this.lbllane.Location = new System.Drawing.Point(954, 14);
            this.lbllane.Name = "lbllane";
            this.lbllane.Size = new System.Drawing.Size(22, 15);
            this.lbllane.TabIndex = 151;
            this.lbllane.Text = "-----";
            this.lbllane.Visible = false;
            // 
            // textCounter
            // 
            this.textCounter.BackColor = System.Drawing.Color.White;
            this.textCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCounter.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCounter.ForeColor = System.Drawing.Color.Crimson;
            this.textCounter.Location = new System.Drawing.Point(1184, 33);
            this.textCounter.Name = "textCounter";
            this.textCounter.ReadOnly = true;
            this.textCounter.Size = new System.Drawing.Size(113, 46);
            this.textCounter.TabIndex = 37;
            this.textCounter.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(1142, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Clients Served";
            // 
            // datagridConfirmedData
            // 
            this.datagridConfirmedData.AllowUserToAddRows = false;
            this.datagridConfirmedData.AllowUserToDeleteRows = false;
            this.datagridConfirmedData.BackgroundColor = System.Drawing.Color.White;
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
            this.datagridConfirmedData.Location = new System.Drawing.Point(1060, 18);
            this.datagridConfirmedData.Name = "datagridConfirmedData";
            this.datagridConfirmedData.ReadOnly = true;
            this.datagridConfirmedData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridConfirmedData.RowHeadersVisible = false;
            this.datagridConfirmedData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridConfirmedData.Size = new System.Drawing.Size(64, 62);
            this.datagridConfirmedData.TabIndex = 0;
            this.datagridConfirmedData.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.labelPriorityTable1);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.richTextBoxDisplayPriority);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(9, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1340, 351);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            // 
            // labelPriorityTable1
            // 
            this.labelPriorityTable1.BackColor = System.Drawing.Color.White;
            this.labelPriorityTable1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelPriorityTable1.Font = new System.Drawing.Font("Century Gothic", 84.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriorityTable1.ForeColor = System.Drawing.Color.Blue;
            this.labelPriorityTable1.Location = new System.Drawing.Point(327, 231);
            this.labelPriorityTable1.Multiline = true;
            this.labelPriorityTable1.Name = "labelPriorityTable1";
            this.labelPriorityTable1.Size = new System.Drawing.Size(713, 114);
            this.labelPriorityTable1.TabIndex = 163;
            this.labelPriorityTable1.Text = "TABLE 00";
            this.labelPriorityTable1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBoxDisplayPriority
            // 
            this.richTextBoxDisplayPriority.BackColor = System.Drawing.Color.White;
            this.richTextBoxDisplayPriority.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDisplayPriority.Font = new System.Drawing.Font("Century Gothic", 65.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDisplayPriority.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxDisplayPriority.Location = new System.Drawing.Point(3, 109);
            this.richTextBoxDisplayPriority.Name = "richTextBoxDisplayPriority";
            this.richTextBoxDisplayPriority.ReadOnly = true;
            this.richTextBoxDisplayPriority.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxDisplayPriority.Size = new System.Drawing.Size(1332, 146);
            this.richTextBoxDisplayPriority.TabIndex = 41;
            this.richTextBoxDisplayPriority.Text = "Welcome to DSWD";
            this.richTextBoxDisplayPriority.TextChanged += new System.EventHandler(this.richTextBoxDisplayPriority_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Arial", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(22, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(709, 102);
            this.label11.TabIndex = 29;
            this.label11.Text = "PRIORITY LANE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SeaGreen;
            this.label13.Location = new System.Drawing.Point(779, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 36);
            this.label13.TabIndex = 12;
            this.label13.Text = "Now Serving";
            // 
            // textPriority1
            // 
            this.textPriority1.BackColor = System.Drawing.Color.White;
            this.textPriority1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPriority1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPriority1.ForeColor = System.Drawing.Color.Blue;
            this.textPriority1.Location = new System.Drawing.Point(816, -2);
            this.textPriority1.Name = "textPriority1";
            this.textPriority1.ReadOnly = true;
            this.textPriority1.Size = new System.Drawing.Size(62, 20);
            this.textPriority1.TabIndex = 1;
            this.textPriority1.Text = "0";
            this.textPriority1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPriority1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(673, 17);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(231, 10);
            this.progressBar1.TabIndex = 37;
            this.progressBar1.Visible = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(1050, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 164;
            this.label4.Text = "Voice Output:";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(1214, 12);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(53, 18);
            this.radioButtonMale.TabIndex = 165;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Checked = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(1129, 11);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(67, 18);
            this.radioButtonFemale.TabIndex = 166;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // labelVoiceNumber
            // 
            this.labelVoiceNumber.AutoSize = true;
            this.labelVoiceNumber.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoiceNumber.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelVoiceNumber.Location = new System.Drawing.Point(1280, 14);
            this.labelVoiceNumber.Name = "labelVoiceNumber";
            this.labelVoiceNumber.Size = new System.Drawing.Size(12, 15);
            this.labelVoiceNumber.TabIndex = 167;
            this.labelVoiceNumber.Text = "1";
            this.labelVoiceNumber.Visible = false;
            // 
            // labelNameOfClient
            // 
            this.labelNameOfClient.AutoSize = true;
            this.labelNameOfClient.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameOfClient.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelNameOfClient.Location = new System.Drawing.Point(991, 9);
            this.labelNameOfClient.Name = "labelNameOfClient";
            this.labelNameOfClient.Size = new System.Drawing.Size(22, 15);
            this.labelNameOfClient.TabIndex = 168;
            this.labelNameOfClient.Text = "-----";
            this.labelNameOfClient.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Arial", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(728, 102);
            this.label7.TabIndex = 29;
            this.label7.Text = "REGULAR LANE";
            // 
            // textNowServing1
            // 
            this.textNowServing1.BackColor = System.Drawing.Color.White;
            this.textNowServing1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNowServing1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNowServing1.ForeColor = System.Drawing.Color.Crimson;
            this.textNowServing1.Location = new System.Drawing.Point(773, -1);
            this.textNowServing1.Name = "textNowServing1";
            this.textNowServing1.ReadOnly = true;
            this.textNowServing1.Size = new System.Drawing.Size(62, 20);
            this.textNowServing1.TabIndex = 36;
            this.textNowServing1.Text = "0";
            this.textNowServing1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNowServing1.Visible = false;
            // 
            // richTextBoxDisplayRegular
            // 
            this.richTextBoxDisplayRegular.BackColor = System.Drawing.Color.White;
            this.richTextBoxDisplayRegular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDisplayRegular.Font = new System.Drawing.Font("Century Gothic", 65.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDisplayRegular.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxDisplayRegular.Location = new System.Drawing.Point(3, 122);
            this.richTextBoxDisplayRegular.Name = "richTextBoxDisplayRegular";
            this.richTextBoxDisplayRegular.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxDisplayRegular.Size = new System.Drawing.Size(1332, 131);
            this.richTextBoxDisplayRegular.TabIndex = 40;
            this.richTextBoxDisplayRegular.Text = "Welcome to DSWD";
            this.richTextBoxDisplayRegular.TextChanged += new System.EventHandler(this.richTextBoxDisplayRegular_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(9, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 5);
            this.panel1.TabIndex = 161;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.datagridConfirmedData);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.textCounter);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTableNumberOne);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.richTextBoxDisplayRegular);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Location = new System.Drawing.Point(9, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1340, 351);
            this.groupBox2.TabIndex = 153;
            this.groupBox2.TabStop = false;
            // 
            // lblTableNumberOne
            // 
            this.lblTableNumberOne.BackColor = System.Drawing.Color.White;
            this.lblTableNumberOne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTableNumberOne.Font = new System.Drawing.Font("Century Gothic", 84.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumberOne.ForeColor = System.Drawing.Color.Red;
            this.lblTableNumberOne.Location = new System.Drawing.Point(327, 234);
            this.lblTableNumberOne.Multiline = true;
            this.lblTableNumberOne.Name = "lblTableNumberOne";
            this.lblTableNumberOne.Size = new System.Drawing.Size(713, 117);
            this.lblTableNumberOne.TabIndex = 162;
            this.lblTableNumberOne.Text = "TABLE 00";
            this.lblTableNumberOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Location = new System.Drawing.Point(12, 377);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1331, 5);
            this.panel4.TabIndex = 163;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(779, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 36);
            this.label1.TabIndex = 163;
            this.label1.Text = "Now Serving";
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
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Queuing_System.Properties.Resources.icons8_verify_50;
            this.pictureBox4.Location = new System.Drawing.Point(735, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 164;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Queuing_System.Properties.Resources.arrow_3517_256;
            this.pictureBox5.Location = new System.Drawing.Point(291, 256);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(144, 91);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 163;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Queuing_System.Properties.Resources.Increase_gif;
            this.pictureBox6.Location = new System.Drawing.Point(1130, 34);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 46);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 39;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Queuing_System.Properties.Resources.leftarrow;
            this.pictureBox8.Location = new System.Drawing.Point(970, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(84, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 40;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Queuing_System.Properties.Resources.icons8_verify_50;
            this.pictureBox3.Location = new System.Drawing.Point(735, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pic_loading
            // 
            this.pic_loading.Image = global::Queuing_System.Properties.Resources.loading;
            this.pic_loading.Location = new System.Drawing.Point(300, 10);
            this.pic_loading.Name = "pic_loading";
            this.pic_loading.Size = new System.Drawing.Size(15, 15);
            this.pic_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_loading.TabIndex = 64;
            this.pic_loading.TabStop = false;
            // 
            // pic_check
            // 
            this.pic_check.Image = global::Queuing_System.Properties.Resources.icons8_check_96;
            this.pic_check.Location = new System.Drawing.Point(300, 10);
            this.pic_check.Name = "pic_check";
            this.pic_check.Size = new System.Drawing.Size(15, 15);
            this.pic_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_check.TabIndex = 63;
            this.pic_check.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Queuing_System.Properties.Resources.arrow_3517_256;
            this.pictureBox7.Location = new System.Drawing.Point(291, 256);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(144, 91);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 163;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Queuing_System.Properties.Resources.leftarrow;
            this.pictureBox2.Location = new System.Drawing.Point(970, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 164;
            this.pictureBox2.TabStop = false;
            // 
            // frmExtended
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelNameOfClient);
            this.Controls.Add(this.labelVoiceNumber);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textNowServing1);
            this.Controls.Add(this.lbllane);
            this.Controls.Add(this.textPriority1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.datagridConfirmedData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textPriority1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView datagridConfirmedData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer progressbartimer;
        private System.Windows.Forms.Timer callerdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCounter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label labelVoiceNumber;
        private System.Windows.Forms.Label labelNameOfClient;
        private System.Windows.Forms.RichTextBox richTextBoxDisplayPriority;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNowServing1;
        private System.Windows.Forms.RichTextBox richTextBoxDisplayRegular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox labelPriorityTable1;
        private System.Windows.Forms.TextBox lblTableNumberOne;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}