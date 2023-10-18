
namespace Queuing_System
{
    partial class formVerifierCaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVerifierCaller));
            this.textRegular = new System.Windows.Forms.TextBox();
            this.textPriority = new System.Windows.Forms.TextBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonCall = new System.Windows.Forms.Button();
            this.labelRegular = new System.Windows.Forms.Label();
            this.buttonCallPriority = new System.Windows.Forms.Button();
            this.buttonNextPriority = new System.Windows.Forms.Button();
            this.buttonPreviousPriority = new System.Windows.Forms.Button();
            this.labelPriority = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_connection = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.pic_check = new System.Windows.Forms.PictureBox();
            this.pic_loading = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textRegular
            // 
            this.textRegular.BackColor = System.Drawing.Color.White;
            this.textRegular.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRegular.ForeColor = System.Drawing.Color.Red;
            this.textRegular.Location = new System.Drawing.Point(26, 153);
            this.textRegular.Name = "textRegular";
            this.textRegular.ReadOnly = true;
            this.textRegular.Size = new System.Drawing.Size(208, 125);
            this.textRegular.TabIndex = 0;
            this.textRegular.Text = "1";
            this.textRegular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPriority
            // 
            this.textPriority.BackColor = System.Drawing.Color.White;
            this.textPriority.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPriority.ForeColor = System.Drawing.Color.Blue;
            this.textPriority.Location = new System.Drawing.Point(346, 153);
            this.textPriority.Name = "textPriority";
            this.textPriority.ReadOnly = true;
            this.textPriority.Size = new System.Drawing.Size(208, 125);
            this.textPriority.TabIndex = 1;
            this.textPriority.Text = "1";
            this.textPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.Maroon;
            this.buttonPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.ForeColor = System.Drawing.Color.White;
            this.buttonPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrevious.Location = new System.Drawing.Point(26, 284);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(101, 34);
            this.buttonPrevious.TabIndex = 0;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Blue;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNext.Location = new System.Drawing.Point(133, 284);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(101, 34);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonCall
            // 
            this.buttonCall.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCall.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCall.ForeColor = System.Drawing.Color.White;
            this.buttonCall.Image = ((System.Drawing.Image)(resources.GetObject("buttonCall.Image")));
            this.buttonCall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCall.Location = new System.Drawing.Point(26, 324);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(208, 34);
            this.buttonCall.TabIndex = 2;
            this.buttonCall.Text = "Call";
            this.buttonCall.UseVisualStyleBackColor = false;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
            // 
            // labelRegular
            // 
            this.labelRegular.AutoSize = true;
            this.labelRegular.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegular.ForeColor = System.Drawing.Color.Red;
            this.labelRegular.Location = new System.Drawing.Point(26, 104);
            this.labelRegular.Name = "labelRegular";
            this.labelRegular.Size = new System.Drawing.Size(186, 32);
            this.labelRegular.TabIndex = 22;
            this.labelRegular.Text = "Regular Lane";
            // 
            // buttonCallPriority
            // 
            this.buttonCallPriority.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonCallPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCallPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCallPriority.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCallPriority.ForeColor = System.Drawing.Color.White;
            this.buttonCallPriority.Image = ((System.Drawing.Image)(resources.GetObject("buttonCallPriority.Image")));
            this.buttonCallPriority.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCallPriority.Location = new System.Drawing.Point(346, 324);
            this.buttonCallPriority.Name = "buttonCallPriority";
            this.buttonCallPriority.Size = new System.Drawing.Size(208, 34);
            this.buttonCallPriority.TabIndex = 5;
            this.buttonCallPriority.Text = "Call";
            this.buttonCallPriority.UseVisualStyleBackColor = false;
            this.buttonCallPriority.Click += new System.EventHandler(this.buttonCallPriority_Click);
            // 
            // buttonNextPriority
            // 
            this.buttonNextPriority.BackColor = System.Drawing.Color.Blue;
            this.buttonNextPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextPriority.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextPriority.ForeColor = System.Drawing.Color.White;
            this.buttonNextPriority.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNextPriority.Location = new System.Drawing.Point(453, 284);
            this.buttonNextPriority.Name = "buttonNextPriority";
            this.buttonNextPriority.Size = new System.Drawing.Size(101, 34);
            this.buttonNextPriority.TabIndex = 4;
            this.buttonNextPriority.Text = "Next";
            this.buttonNextPriority.UseVisualStyleBackColor = false;
            this.buttonNextPriority.Click += new System.EventHandler(this.buttonNextPriority_Click);
            // 
            // buttonPreviousPriority
            // 
            this.buttonPreviousPriority.BackColor = System.Drawing.Color.Maroon;
            this.buttonPreviousPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPreviousPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousPriority.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreviousPriority.ForeColor = System.Drawing.Color.White;
            this.buttonPreviousPriority.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPreviousPriority.Location = new System.Drawing.Point(346, 284);
            this.buttonPreviousPriority.Name = "buttonPreviousPriority";
            this.buttonPreviousPriority.Size = new System.Drawing.Size(101, 34);
            this.buttonPreviousPriority.TabIndex = 3;
            this.buttonPreviousPriority.Text = "Previous";
            this.buttonPreviousPriority.UseVisualStyleBackColor = false;
            this.buttonPreviousPriority.Click += new System.EventHandler(this.buttonPreviousPriority_Click);
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriority.ForeColor = System.Drawing.Color.Blue;
            this.labelPriority.Location = new System.Drawing.Point(346, 104);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(172, 32);
            this.labelPriority.TabIndex = 26;
            this.labelPriority.Text = "Priority Lane";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(17, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 5);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(291, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 280);
            this.panel2.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(63, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Verifier Number Calling";
            // 
            // lbl_connection
            // 
            this.lbl_connection.AutoSize = true;
            this.lbl_connection.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connection.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_connection.Location = new System.Drawing.Point(146, 384);
            this.lbl_connection.Name = "lbl_connection";
            this.lbl_connection.Size = new System.Drawing.Size(47, 15);
            this.lbl_connection.TabIndex = 74;
            this.lbl_connection.Text = "--------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 73;
            this.label6.Text = "Conection Status:";
            // 
            // dateTimer
            // 
            this.dateTimer.Tick += new System.EventHandler(this.dateTimer_Tick);
            // 
            // pic_check
            // 
            this.pic_check.Image = global::Queuing_System.Properties.Resources.icons8_check_96;
            this.pic_check.Location = new System.Drawing.Point(120, 383);
            this.pic_check.Name = "pic_check";
            this.pic_check.Size = new System.Drawing.Size(19, 19);
            this.pic_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_check.TabIndex = 76;
            this.pic_check.TabStop = false;
            // 
            // pic_loading
            // 
            this.pic_loading.Image = global::Queuing_System.Properties.Resources.loading;
            this.pic_loading.Location = new System.Drawing.Point(120, 383);
            this.pic_loading.Name = "pic_loading";
            this.pic_loading.Size = new System.Drawing.Size(19, 19);
            this.pic_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_loading.TabIndex = 75;
            this.pic_loading.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Queuing_System.Properties.Resources.icons8_extend_20;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(424, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 26);
            this.button1.TabIndex = 30;
            this.button1.Text = "Extend Display";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pic_check);
            this.groupBox1.Controls.Add(this.textRegular);
            this.groupBox1.Controls.Add(this.pic_loading);
            this.groupBox1.Controls.Add(this.textPriority);
            this.groupBox1.Controls.Add(this.lbl_connection);
            this.groupBox1.Controls.Add(this.buttonPrevious);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonNext);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonCall);
            this.groupBox1.Controls.Add(this.labelRegular);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.buttonPreviousPriority);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.buttonNextPriority);
            this.groupBox1.Controls.Add(this.labelPriority);
            this.groupBox1.Controls.Add(this.buttonCallPriority);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 441);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Queuing_System.Properties.Resources.icons8_verify_50;
            this.pictureBox2.Location = new System.Drawing.Point(17, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 98;
            this.pictureBox2.TabStop = false;
            // 
            // formVerifierCaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 482);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(638, 521);
            this.MinimumSize = new System.Drawing.Size(638, 521);
            this.Name = "formVerifierCaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verifier Caller";
            this.Load += new System.EventHandler(this.formVerifierCaller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textRegular;
        private System.Windows.Forms.TextBox textPriority;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.Label labelRegular;
        private System.Windows.Forms.Button buttonCallPriority;
        private System.Windows.Forms.Button buttonNextPriority;
        private System.Windows.Forms.Button buttonPreviousPriority;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic_check;
        private System.Windows.Forms.PictureBox pic_loading;
        private System.Windows.Forms.Label lbl_connection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer dateTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}