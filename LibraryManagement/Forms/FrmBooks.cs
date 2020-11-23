using LibraryManagement.Data.Repositories;
using System;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class FrmBooks : Form
    {
        private readonly IBookRepository bookRepository;
        public FrmBooks(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var books = bookRepository.GetAll();
            dataGridBook.DataSource = books;
        }

        private void FrmBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }     

        public void RefreshGrid()
        {

        }

        private void btnEditForm_Click(object sender, EventArgs e)
        {
            FrmEditBook frm = new FrmEditBook(this);
            frm.Show();
        }
    }
}
