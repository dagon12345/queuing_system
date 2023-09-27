
namespace Queuing_System
{
    partial class frmOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOption));
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_qt = new System.Windows.Forms.Button();
            this.btn_rc = new System.Windows.Forms.Button();
            this.buttonExtend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(31, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Select Function below";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 171);
            this.panel1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 56);
            this.label7.TabIndex = 21;
            this.label7.Text = "CIS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Queuing_System.Properties.Resources.dswdlogo;
            this.pictureBox1.Location = new System.Drawing.Point(68, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Queuing System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 28);
            this.panel2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(136, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Select Option";
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generate.FlatAppearance.BorderSize = 0;
            this.btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generate.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.ForeColor = System.Drawing.Color.White;
            this.btn_generate.Image = global::Queuing_System.Properties.Resources.icons8_train_ticket_50;
            this.btn_generate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generate.Location = new System.Drawing.Point(35, 275);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(319, 48);
            this.btn_generate.TabIndex = 1;
            this.btn_generate.Text = "Generating Tab";
            this.btn_generate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_generate.UseVisualStyleBackColor = false;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_qt
            // 
            this.btn_qt.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_qt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_qt.FlatAppearance.BorderSize = 0;
            this.btn_qt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qt.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qt.ForeColor = System.Drawing.Color.White;
            this.btn_qt.Image = global::Queuing_System.Properties.Resources.icons8_joining_queue_50;
            this.btn_qt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qt.Location = new System.Drawing.Point(35, 383);
            this.btn_qt.Name = "btn_qt";
            this.btn_qt.Size = new System.Drawing.Size(319, 47);
            this.btn_qt.TabIndex = 3;
            this.btn_qt.Text = "Queuing Tab";
            this.btn_qt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_qt.UseVisualStyleBackColor = false;
            this.btn_qt.Click += new System.EventHandler(this.btn_qt_Click);
            // 
            // btn_rc
            // 
            this.btn_rc.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_rc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rc.FlatAppearance.BorderSize = 0;
            this.btn_rc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rc.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rc.ForeColor = System.Drawing.Color.White;
            this.btn_rc.Image = global::Queuing_System.Properties.Resources.icons8_verify_50;
            this.btn_rc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rc.Location = new System.Drawing.Point(35, 329);
            this.btn_rc.Name = "btn_rc";
            this.btn_rc.Size = new System.Drawing.Size(319, 48);
            this.btn_rc.TabIndex = 2;
            this.btn_rc.Text = "Verifying Tab";
            this.btn_rc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_rc.UseVisualStyleBackColor = false;
            this.btn_rc.Click += new System.EventHandler(this.btn_rc_Click);
            // 
            // buttonExtend
            // 
            this.buttonExtend.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonExtend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExtend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExtend.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtend.ForeColor = System.Drawing.Color.White;
            this.buttonExtend.Image = ((System.Drawing.Image)(resources.GetObject("buttonExtend.Image")));
            this.buttonExtend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExtend.Location = new System.Drawing.Point(35, 217);
            this.buttonExtend.Name = "buttonExtend";
            this.buttonExtend.Size = new System.Drawing.Size(319, 52);
            this.buttonExtend.TabIndex = 0;
            this.buttonExtend.Text = "Extend Display";
            this.buttonExtend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExtend.UseVisualStyleBackColor = false;
            this.buttonExtend.Click += new System.EventHandler(this.buttonExtend_Click);
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 442);
            this.Controls.Add(this.buttonExtend);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_qt);
            this.Controls.Add(this.btn_rc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(407, 481);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(407, 481);
            this.Name = "frmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIS Queuing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOption_FormClosed);
            this.Load += new System.EventHandler(this.Option_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_rc;
        private System.Windows.Forms.Button btn_qt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExtend;
    }
}