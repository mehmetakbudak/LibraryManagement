using LibraryManagement.Data.Entities;
using LibraryManagement.Data.Enums;
using LibraryManagement.Data.Repositories;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using LibraryManagement.Data.Models;

namespace LibraryManagement.Forms
{
    public partial class FrmBooks : Form
    {
        private readonly IBookRepository bookRepository;
        private readonly IServiceProvider serviceProvider;

        internal static FrmBooks frmBook;
        Book book = new Book();

        public FrmBooks(IBookRepository bookRepository, IServiceProvider serviceProvider)
        {
            this.bookRepository = bookRepository;
            this.serviceProvider = serviceProvider;
            frmBook = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGridData();
            SetDefaultButtonEnable();
        }

        public void LoadGridData()
        {
            var books = bookRepository.GetAll();
            dataGridBook.DataSource = books;
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
                        btnReceive.Enabled = false;
                    }
                    else if (book.Status == BookStatus.InUser)
                    {
                        btnReceive.Enabled = true;
                        btnLend.Enabled = false;
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
            frm.ShowDialog(this);
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            var frm = serviceProvider.GetService<FrmLeanBooks>();
            BookTransactionData.BookId = book.Id;
            BookTransactionData.BookStatus = book.Status;
            frm.ShowDialog(this);
        }

        private void SetDefaultButtonEnable()
        {
            btnEdit.Enabled = false;
            btnLend.Enabled = false;
            btnReceive.Enabled = false;
        }

        private void FrmBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
