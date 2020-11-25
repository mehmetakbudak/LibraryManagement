using LibraryManagement.Data.Entities;
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
        private readonly Book book;
        public FrmEditBook(FrmBooks frmBooks, Book book)
        {
            InitializeComponent();
            this.frmBooks = frmBooks;
            this.book = book;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBooks.RefreshGrid();
            this.Close();
        }

        private void FrmEditBook_Load(object sender, EventArgs e)
        {
            if (book == null)
            {
                this.Text = "Yeni Kitap Ekle";
            }
            else
            {
                this.Text = "Kitap Düzenle";

            }
        }
    }
}
