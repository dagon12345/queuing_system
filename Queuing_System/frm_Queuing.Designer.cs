
namespace Queuing_System
{
    partial class frm_Queuing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Queuing));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetodaylbl = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.datetimer = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_repeat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblnext = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_extend = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.datagridtimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(154, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Queuing Tab";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date Today:";
            // 
            // datetodaylbl
            // 
            this.datetodaylbl.AutoSize = true;
            this.datetodaylbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetodaylbl.Location = new System.Drawing.Point(547, 9);
            this.datetodaylbl.Name = "datetodaylbl";
            this.datetodaylbl.Size = new System.Drawing.Size(68, 18);
            this.datetodaylbl.TabIndex = 9;
            this.datetodaylbl.Text = "----------";
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(12, 590);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(414, 82);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "NEXT";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(442, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(422, 562);
            this.dataGridView1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pending Clients";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(438, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Served/Done";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(885, 110);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(422, 526);
            this.dataGridView2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "NOW SERVING Client Number:";
            // 
            // datetimer
            // 
            this.datetimer.Tick += new System.EventHandler(this.datetimer_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "NEXT NUMBER:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ON TABLE NUMBER 1",
            "ON TABLE NUMBER 2"});
            this.comboBox1.Location = new System.Drawing.Point(16, 550);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 28);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "ON TABLE NUMBER 1";
            // 
            // btn_repeat
            // 
            this.btn_repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repeat.Location = new System.Drawing.Point(65, 417);
            this.btn_repeat.Name = "btn_repeat";
            this.btn_repeat.Size = new System.Drawing.Size(273, 29);
            this.btn_repeat.TabIndex = 21;
            this.btn_repeat.Text = "Repeat call";
            this.btn_repeat.UseVisualStyleBackColor = true;
            this.btn_repeat.Click += new System.EventHandler(this.btn_repeat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblnext);
            this.groupBox1.Controls.Add(this.btn_extend);
            this.groupBox1.Controls.Add(this.txt_number);
            this.groupBox1.Controls.Add(this.btn_repeat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(14, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 492);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // lblnext
            // 
            this.lblnext.BackColor = System.Drawing.SystemColors.Control;
            this.lblnext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnext.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblnext.Location = new System.Drawing.Point(37, 251);
            this.lblnext.Name = "lblnext";
            this.lblnext.Size = new System.Drawing.Size(331, 109);
            this.lblnext.TabIndex = 24;
            this.lblnext.Text = "0";
            this.lblnext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_number
            // 
            this.txt_number.BackColor = System.Drawing.SystemColors.Control;
            this.txt_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_number.Location = new System.Drawing.Point(37, 86);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(331, 109);
            this.txt_number.TabIndex = 23;
            this.txt_number.Text = "0";
            this.txt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Select Table Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(443, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total Number of Clients:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_total.Location = new System.Drawing.Point(629, 87);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(26, 18);
            this.lbl_total.TabIndex = 24;
            this.lbl_total.Text = "---";
            // 
            // btn_extend
            // 
            this.btn_extend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_extend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_extend.Location = new System.Drawing.Point(65, 452);
            this.btn_extend.Name = "btn_extend";
            this.btn_extend.Size = new System.Drawing.Size(273, 27);
            this.btn_extend.TabIndex = 23;
            this.btn_extend.Text = "Extend Display";
            this.btn_extend.UseVisualStyleBackColor = true;
            this.btn_extend.Click += new System.EventHandler(this.btn_extend_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(885, 642);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(156, 30);
            this.btn_clear.TabIndex = 25;
            this.btn_clear.Text = "Clear table";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // datagridtimer
            // 
            this.datagridtimer.Interval = 1000;
            this.datagridtimer.Tick += new System.EventHandler(this.datagridtimer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(442, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(865, 48);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // frm_Queuing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 684);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datetodaylbl);
            this.Controls.Add(this.btn_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1346, 723);
            this.Name = "frm_Queuing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Queuing";
            this.Load += new System.EventHandler(this.frm_Queuing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label datetodaylbl;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer datetimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_repeat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_extend;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox lblnext;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Timer datagridtimer;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}