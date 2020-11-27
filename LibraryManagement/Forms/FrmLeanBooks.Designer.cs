namespace LibraryManagement.Forms
{
    partial class FrmLeanBooks
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
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.dateTimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPerson
            // 
            this.cmbPerson.DisplayMember = "FullName";
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Location = new System.Drawing.Point(158, 40);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(300, 33);
            this.cmbPerson.TabIndex = 0;
            this.cmbPerson.ValueMember = "Id";
            // 
            // dateTimeStartDate
            // 
            this.dateTimeStartDate.Enabled = false;
            this.dateTimeStartDate.Location = new System.Drawing.Point(158, 101);
            this.dateTimeStartDate.Name = "dateTimeStartDate";
            this.dateTimeStartDate.Size = new System.Drawing.Size(300, 31);
            this.dateTimeStartDate.TabIndex = 1;
            // 
            // dateTimeEndDate
            // 
            this.dateTimeEndDate.Enabled = false;
            this.dateTimeEndDate.Location = new System.Drawing.Point(158, 160);
            this.dateTimeEndDate.Name = "dateTimeEndDate";
            this.dateTimeEndDate.Size = new System.Drawing.Size(300, 31);
            this.dateTimeEndDate.TabIndex = 2;
            // 
            // dateTimeReturnDate
            // 
            this.dateTimeReturnDate.Enabled = false;
            this.dateTimeReturnDate.Location = new System.Drawing.Point(158, 219);
            this.dateTimeReturnDate.Name = "dateTimeReturnDate";
            this.dateTimeReturnDate.Size = new System.Drawing.Size(300, 31);
            this.dateTimeReturnDate.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(158, 278);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(300, 31);
            this.txtAmount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Üye Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teslim Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ceza Tutarı";
            // 
            // btnLean
            // 
            this.btnLean.Location = new System.Drawing.Point(345, 324);
            this.btnLean.Name = "btnLean";
            this.btnLean.Size = new System.Drawing.Size(113, 33);
            this.btnLean.TabIndex = 10;
            this.btnLean.Text = "Ödünç Ver";
            this.btnLean.UseVisualStyleBackColor = true;
            this.btnLean.Click += new System.EventHandler(this.btnLean_Click);
            // 
            // FrmLeanBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 379);
            this.Controls.Add(this.btnLean);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dateTimeReturnDate);
            this.Controls.Add(this.dateTimeEndDate);
            this.Controls.Add(this.dateTimeStartDate);
            this.Controls.Add(this.cmbPerson);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLeanBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Ver";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLeanBooks_FormClosing);
            this.Load += new System.EventHandler(this.FrmLeanBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPerson;
        private System.Windows.Forms.DateTimePicker dateTimeStartDate;
        private System.Windows.Forms.DateTimePicker dateTimeEndDate;
        private System.Windows.Forms.DateTimePicker dateTimeReturnDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLean;
    }
}