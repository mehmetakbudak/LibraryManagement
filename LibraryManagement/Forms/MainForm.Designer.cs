namespace LibraryManagement.Forms
{
    partial class MainForm
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
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.menuItemDefinition = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPublisher = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDefinition});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.topMenu.Size = new System.Drawing.Size(954, 31);
            this.topMenu.TabIndex = 1;
            this.topMenu.Text = "Tanımlar";
            // 
            // menuItemDefinition
            // 
            this.menuItemDefinition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAuthor,
            this.menuItemPublisher,
            this.menuItemBooks});
            this.menuItemDefinition.Name = "menuItemDefinition";
            this.menuItemDefinition.Size = new System.Drawing.Size(88, 27);
            this.menuItemDefinition.Text = "Tanımlar";
            // 
            // menuItemAuthor
            // 
            this.menuItemAuthor.Name = "menuItemAuthor";
            this.menuItemAuthor.Size = new System.Drawing.Size(224, 28);
            this.menuItemAuthor.Text = "Yazarlar";
            this.menuItemAuthor.Click += new System.EventHandler(this.menuItemAuthor_Click);
            // 
            // menuItemPublisher
            // 
            this.menuItemPublisher.Name = "menuItemPublisher";
            this.menuItemPublisher.Size = new System.Drawing.Size(224, 28);
            this.menuItemPublisher.Text = "Yayınevleri";
            this.menuItemPublisher.Click += new System.EventHandler(this.menuItemPublisher_Click);
            // 
            // menuItemBooks
            // 
            this.menuItemBooks.Name = "menuItemBooks";
            this.menuItemBooks.Size = new System.Drawing.Size(224, 28);
            this.menuItemBooks.Text = "Kitaplar";
            this.menuItemBooks.Click += new System.EventHandler(this.menuItemBooks_Click);
            // 
            // sqliteCommand1
            // 
            this.sqliteCommand1.CommandTimeout = 30;
            this.sqliteCommand1.Connection = null;
            this.sqliteCommand1.Transaction = null;
            this.sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 490);
            this.Controls.Add(this.topMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.topMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Kütüphane Otomasyonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemDefinition;
        private System.Windows.Forms.ToolStripMenuItem menuItemAuthor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem menuItemPublisher;
        private System.Windows.Forms.ToolStripMenuItem menuItemBooks;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
    }
}