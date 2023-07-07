
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtended));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txttable = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblfirst = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblsecond = new System.Windows.Forms.TextBox();
            this.lblthird = new System.Windows.Forms.TextBox();
            this.numbertimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdone3 = new System.Windows.Forms.TextBox();
            this.txtdone1 = new System.Windows.Forms.TextBox();
            this.txtdone2 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.txttable);
            this.groupBox2.Controls.Add(this.txt_number);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 712);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Queuing_System.Properties.Resources.dswdlogo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 696);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(424, 10);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.Visible = false;
            // 
            // txttable
            // 
            this.txttable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txttable.BackColor = System.Drawing.Color.White;
            this.txttable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttable.ForeColor = System.Drawing.Color.DarkCyan;
            this.txttable.Location = new System.Drawing.Point(101, 637);
            this.txttable.Name = "txttable";
            this.txttable.Size = new System.Drawing.Size(404, 24);
            this.txttable.TabIndex = 0;
            this.txttable.Text = "TABLE NUMBER HERE";
            this.txttable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_number
            // 
            this.txt_number.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_number.BackColor = System.Drawing.Color.White;
            this.txt_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 300F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_number.Location = new System.Drawing.Point(6, 141);
            this.txt_number.Name = "txt_number";
            this.txt_number.ReadOnly = true;
            this.txt_number.Size = new System.Drawing.Size(590, 453);
            this.txt_number.TabIndex = 1;
            this.txt_number.Text = "0";
            this.txt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_number.TextChanged += new System.EventHandler(this.txt_number_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(639, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "NOW SERVING Client Number Regular Lane";
            // 
            // lblfirst
            // 
            this.lblfirst.BackColor = System.Drawing.Color.White;
            this.lblfirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 81.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirst.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblfirst.Location = new System.Drawing.Point(40, 152);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(251, 124);
            this.lblfirst.TabIndex = 24;
            this.lblfirst.Text = "0";
            this.lblfirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "NUMBERS ON QUEUE Regular Lane";
            // 
            // lblsecond
            // 
            this.lblsecond.BackColor = System.Drawing.Color.White;
            this.lblsecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblsecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 62.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecond.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblsecond.Location = new System.Drawing.Point(40, 366);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(251, 94);
            this.lblsecond.TabIndex = 25;
            this.lblsecond.Text = "0";
            this.lblsecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblthird
            // 
            this.lblthird.BackColor = System.Drawing.Color.White;
            this.lblthird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblthird.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthird.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblthird.Location = new System.Drawing.Point(40, 588);
            this.lblthird.Name = "lblthird";
            this.lblthird.Size = new System.Drawing.Size(251, 73);
            this.lblthird.TabIndex = 26;
            this.lblthird.Text = "0";
            this.lblthird.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numbertimer
            // 
            this.numbertimer.Interval = 1000;
            this.numbertimer.Tick += new System.EventHandler(this.numbertimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblthird);
            this.groupBox1.Controls.Add(this.lblfirst);
            this.groupBox1.Controls.Add(this.lblsecond);
            this.groupBox1.Location = new System.Drawing.Point(668, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 712);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Location = new System.Drawing.Point(13, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 5);
            this.panel3.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(106, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 41);
            this.label1.TabIndex = 29;
            this.label1.Text = "Next";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(13, 534);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 5);
            this.panel2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(13, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 5);
            this.panel1.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtdone3);
            this.groupBox3.Controls.Add(this.txtdone1);
            this.groupBox3.Controls.Add(this.txtdone2);
            this.groupBox3.Location = new System.Drawing.Point(1016, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 712);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 696);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(124, 10);
            this.dataGridView2.TabIndex = 30;
            this.dataGridView2.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Location = new System.Drawing.Point(13, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 5);
            this.panel4.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 41);
            this.label2.TabIndex = 29;
            this.label2.Text = "DONE SERVED";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaGreen;
            this.panel5.Location = new System.Drawing.Point(13, 534);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 5);
            this.panel5.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaGreen;
            this.panel6.Location = new System.Drawing.Point(13, 309);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 5);
            this.panel6.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "NUMBERS FINISHED";
            // 
            // txtdone3
            // 
            this.txtdone3.BackColor = System.Drawing.Color.White;
            this.txtdone3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdone3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdone3.ForeColor = System.Drawing.Color.Maroon;
            this.txtdone3.Location = new System.Drawing.Point(40, 588);
            this.txtdone3.Name = "txtdone3";
            this.txtdone3.Size = new System.Drawing.Size(251, 73);
            this.txtdone3.TabIndex = 26;
            this.txtdone3.Text = "0";
            this.txtdone3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdone1
            // 
            this.txtdone1.BackColor = System.Drawing.Color.White;
            this.txtdone1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 81.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdone1.ForeColor = System.Drawing.Color.Maroon;
            this.txtdone1.Location = new System.Drawing.Point(40, 152);
            this.txtdone1.Name = "txtdone1";
            this.txtdone1.Size = new System.Drawing.Size(251, 124);
            this.txtdone1.TabIndex = 24;
            this.txtdone1.Text = "0";
            this.txtdone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdone2
            // 
            this.txtdone2.BackColor = System.Drawing.Color.White;
            this.txtdone2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 62.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdone2.ForeColor = System.Drawing.Color.Maroon;
            this.txtdone2.Location = new System.Drawing.Point(40, 366);
            this.txtdone2.Name = "txtdone2";
            this.txtdone2.Size = new System.Drawing.Size(251, 94);
            this.txtdone2.TabIndex = 25;
            this.txtdone2.Text = "0";
            this.txtdone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmExtended
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1394, 736);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExtended";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmExtended";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExtended_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttable;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblfirst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lblsecond;
        private System.Windows.Forms.TextBox lblthird;
        private System.Windows.Forms.Timer numbertimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdone3;
        private System.Windows.Forms.TextBox txtdone1;
        private System.Windows.Forms.TextBox txtdone2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}