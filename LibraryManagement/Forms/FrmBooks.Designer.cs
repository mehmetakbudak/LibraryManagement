namespace LibraryManagement.Forms
{
    partial class FrmBooks
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEditForm = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLend = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.dataGridBook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditForm
            // 
            this.btnEditForm.Location = new System.Drawing.Point(12, 110);
            this.btnEditForm.Name = "btnEditForm";
            this.btnEditForm.Size = new System.Drawing.Size(112, 34);
            this.btnEditForm.TabIndex = 1;
            this.btnEditForm.Text = "Yeni Ekle";
            this.btnEditForm.UseVisualStyleBackColor = true;
            this.btnEditForm.Click += new System.EventHandler(this.btnEditForm_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(153, 110);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 34);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLend
            // 
            this.btnLend.Location = new System.Drawing.Point(294, 110);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(112, 34);
            this.btnLend.TabIndex = 3;
            this.btnLend.Text = "Ödünç Ver";
            this.btnLend.UseVisualStyleBackColor = true;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(435, 110);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(112, 34);
            this.btnReceive.TabIndex = 3;
            this.btnReceive.Text = "Teslim Al";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // FrmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 673);
            // 
            // dataGridBook
            // 
            this.dataGridBook.AllowUserToAddRows = false;
            this.dataGridBook.AllowUserToDeleteRows = false;
            this.dataGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBook.Location = new System.Drawing.Point(12, 159);
            this.dataGridBook.Name = "dataGridBook";
            this.dataGridBook.ReadOnly = true;
            this.dataGridBook.RowHeadersWidth = 62;
            this.dataGridBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBook.Size = new System.Drawing.Size(1623, 375);
            this.dataGridBook.TabIndex = 0;
            this.dataGridBook.Text = "dataGridView1";
            this.dataGridBook.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridBook_CellMouseClick);
            this.dataGridBook.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridBook_DataBindingComplete);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnLend);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnEditForm);
            this.Controls.Add(this.dataGridBook);
            this.Name = "FrmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBooks_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBook;
        private System.Windows.Forms.Button btnEditForm;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLend;
        private System.Windows.Forms.Button btnReceive;
    }
}

