
namespace Queuing_System
{
    partial class frmSelectSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectSection));
            this.cmb_section = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_section
            // 
            this.cmb_section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_section.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_section.FormattingEnabled = true;
            this.cmb_section.Items.AddRange(new object[] {
            "CIS",
            "MTA"});
            this.cmb_section.Location = new System.Drawing.Point(83, 148);
            this.cmb_section.Name = "cmb_section";
            this.cmb_section.Size = new System.Drawing.Size(134, 27);
            this.cmb_section.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(50, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Queuing System";
            // 
            // btn_proceed
            // 
            this.btn_proceed.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proceed.FlatAppearance.BorderSize = 0;
            this.btn_proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proceed.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proceed.ForeColor = System.Drawing.Color.White;
            this.btn_proceed.Image = global::Queuing_System.Properties.Resources.icons8_enter_30;
            this.btn_proceed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proceed.Location = new System.Drawing.Point(83, 191);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(134, 34);
            this.btn_proceed.TabIndex = 23;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_proceed.UseVisualStyleBackColor = false;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Queuing_System.Properties.Resources.dswdlogo;
            this.pictureBox1.Location = new System.Drawing.Point(43, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmSelectSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 259);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_section);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelectSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Section";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSelectSection_FormClosed);
            this.Load += new System.EventHandler(this.frmSelectSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_section;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_proceed;
    }
}