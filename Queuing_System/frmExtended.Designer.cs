
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.txttable.BackColor = System.Drawing.SystemColors.Control;
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
            this.txt_number.BackColor = System.Drawing.SystemColors.Control;
            this.txt_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 300F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_number.Location = new System.Drawing.Point(133, 96);
            this.txt_number.Name = "txt_number";
            this.txt_number.ReadOnly = true;
            this.txt_number.Size = new System.Drawing.Size(331, 453);
            this.txt_number.TabIndex = 1;
            this.txt_number.Text = "0";
            this.txt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_number.TextChanged += new System.EventHandler(this.txt_number_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(444, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "NOW SERVING Client Number";
            // 
            // lblfirst
            // 
            this.lblfirst.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblfirst.BackColor = System.Drawing.SystemColors.Control;
            this.lblfirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 81.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirst.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblfirst.Location = new System.Drawing.Point(171, 124);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(193, 124);
            this.lblfirst.TabIndex = 24;
            this.lblfirst.Text = "0";
            this.lblfirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(399, 39);
            this.label7.TabIndex = 18;
            this.label7.Text = "NUMBERS ON QUEUE";
            // 
            // lblsecond
            // 
            this.lblsecond.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblsecond.BackColor = System.Drawing.SystemColors.Control;
            this.lblsecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblsecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 62.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecond.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblsecond.Location = new System.Drawing.Point(171, 347);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(193, 94);
            this.lblsecond.TabIndex = 25;
            this.lblsecond.Text = "0";
            this.lblsecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblthird
            // 
            this.lblthird.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblthird.BackColor = System.Drawing.SystemColors.Control;
            this.lblthird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblthird.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthird.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblthird.Location = new System.Drawing.Point(171, 555);
            this.lblthird.Name = "lblthird";
            this.lblthird.Size = new System.Drawing.Size(193, 73);
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
            this.groupBox1.Size = new System.Drawing.Size(517, 712);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(13, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 5);
            this.panel3.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 41);
            this.label1.TabIndex = 29;
            this.label1.Text = "Next";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(13, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 5);
            this.panel2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(13, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 5);
            this.panel1.TabIndex = 27;
            // 
            // frmExtended
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 736);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}