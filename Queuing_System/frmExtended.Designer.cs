
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
            this.pic_loading = new System.Windows.Forms.PictureBox();
            this.pic_check = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datagridConfirmedData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_check)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridConfirmedData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.lblconstatus.Location = new System.Drawing.Point(495, 10);
            this.lblconstatus.Name = "lblconstatus";
            this.lblconstatus.Size = new System.Drawing.Size(103, 15);
            this.lblconstatus.TabIndex = 62;
            this.lblconstatus.Text = "Connection Secured.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(385, 10);
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
            this.label65.Location = new System.Drawing.Point(642, 10);
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
            this.lblcaller.Location = new System.Drawing.Point(713, 10);
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
            this.lbltblnumber.Location = new System.Drawing.Point(815, 10);
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
            this.lblnumber.Location = new System.Drawing.Point(776, 10);
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
            this.lbllane.Location = new System.Drawing.Point(854, 10);
            this.lbllane.Name = "lbllane";
            this.lbllane.Size = new System.Drawing.Size(22, 15);
            this.lbllane.TabIndex = 151;
            this.lbllane.Text = "-----";
            this.lbllane.Visible = false;
            // 
            // pic_loading
            // 
            this.pic_loading.Image = global::Queuing_System.Properties.Resources.loading;
            this.pic_loading.Location = new System.Drawing.Point(480, 15);
            this.pic_loading.Name = "pic_loading";
            this.pic_loading.Size = new System.Drawing.Size(10, 10);
            this.pic_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_loading.TabIndex = 64;
            this.pic_loading.TabStop = false;
            // 
            // pic_check
            // 
            this.pic_check.Image = global::Queuing_System.Properties.Resources.icons8_check_96;
            this.pic_check.Location = new System.Drawing.Point(480, 15);
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
            this.panel12.Location = new System.Drawing.Point(520, 34);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(5, 685);
            this.panel12.TabIndex = 160;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.datagridConfirmedData);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(1050, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 688);
            this.groupBox3.TabIndex = 155;
            this.groupBox3.TabStop = false;
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
            this.datagridConfirmedData.Location = new System.Drawing.Point(6, 62);
            this.datagridConfirmedData.Name = "datagridConfirmedData";
            this.datagridConfirmedData.ReadOnly = true;
            this.datagridConfirmedData.RowHeadersVisible = false;
            this.datagridConfirmedData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridConfirmedData.Size = new System.Drawing.Size(276, 620);
            this.datagridConfirmedData.TabIndex = 0;
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
            this.lblTableNumberOne.Font = new System.Drawing.Font("Century Gothic", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumberOne.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTableNumberOne.Location = new System.Drawing.Point(4, 596);
            this.lblTableNumberOne.Name = "lblTableNumberOne";
            this.lblTableNumberOne.Size = new System.Drawing.Size(137, 53);
            this.lblTableNumberOne.TabIndex = 34;
            this.lblTableNumberOne.Text = "------";
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
            this.label9.Location = new System.Drawing.Point(11, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 38);
            this.label9.TabIndex = 12;
            this.label9.Text = "Now Serving";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.labelPriorityTable1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textPriority1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(523, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 692);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            // 
            // labelPriorityTable1
            // 
            this.labelPriorityTable1.AutoSize = true;
            this.labelPriorityTable1.Font = new System.Drawing.Font("Century Gothic", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriorityTable1.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelPriorityTable1.Location = new System.Drawing.Point(1, 596);
            this.labelPriorityTable1.Name = "labelPriorityTable1";
            this.labelPriorityTable1.Size = new System.Drawing.Size(137, 53);
            this.labelPriorityTable1.TabIndex = 34;
            this.labelPriorityTable1.Text = "------";
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
            this.label13.Location = new System.Drawing.Point(11, 114);
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
            // frmExtended
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_check)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridConfirmedData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
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
    }
}