using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class FrmEditBook : Form
    {
        private readonly FrmBooks frmBooks;
        public FrmEditBook(FrmBooks frmBooks)
        {
            InitializeComponent();
            this.frmBooks = frmBooks;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBooks.RefreshGrid();
            this.Close();
        }
    }
}
