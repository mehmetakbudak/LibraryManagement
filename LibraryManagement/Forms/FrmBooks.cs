using LibraryManagement.Data.Entities;
using LibraryManagement.Data.Enums;
using LibraryManagement.Data.Repositories;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagement.Forms
{
    public partial class FrmBooks : Form
    {
        private readonly IBookRepository bookRepository;
        private readonly IServiceProvider serviceProvider;

        Book book = new Book();

        public FrmBooks(IBookRepository bookRepository, IServiceProvider serviceProvider)
        {
            this.bookRepository = bookRepository;
            this.serviceProvider = serviceProvider;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var books = bookRepository.GetAll();
            dataGridBook.DataSource = books;
            SetDefaultButtonEnable();
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
            FrmEditBook frm = new FrmEditBook(this, null);
            frm.Show();
        }

        private void dataGridBook_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridBook.ClearSelection();
        }

        private void dataGridBook_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnEdit.Enabled = true;

                DataGridViewRow row = dataGridBook.Rows[e.RowIndex];
                Int32.TryParse(row.Cells["Id"].Value.ToString(), out int Id);
                book = bookRepository.GetById(Id);
                if (book != null)
                {
                    if (book.Status == BookStatus.OnTheShelf)
                    {
                        btnLend.Enabled = true;
                    }
                    else if (book.Status == BookStatus.InUser)
                    {
                        btnReceive.Enabled = true;
                    }
                    else
                    {
                        SetDefaultButtonEnable();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditBook frm = new FrmEditBook(this, book);
            frm.Show();
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            var frm = serviceProvider.GetService<FrmLeanBooks>();
            frm.Show();
        }

        private void SetDefaultButtonEnable()
        {
            btnEdit.Enabled = false;
            btnLend.Enabled = false;
            btnReceive.Enabled = false;
        }
    }
}
