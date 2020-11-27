using LibraryManagement.Data.Entities;
using LibraryManagement.Data.Enums;
using LibraryManagement.Data.Models;
using LibraryManagement.Data.Repositories;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class FrmLeanBooks : Form
    {
        private readonly IPersonRepository personRepository;
        private readonly IBookTransactionRepository bookTransactionRepository;
        private readonly IBookRepository bookRepository;

        public FrmLeanBooks(IPersonRepository personRepository,
            IBookTransactionRepository bookTransactionRepository,
            IBookRepository bookRepository)
        {
            InitializeComponent();
            this.personRepository = personRepository;
            this.bookTransactionRepository = bookTransactionRepository;
            this.bookRepository = bookRepository;
        }

        private void FrmLeanBooks_Load(object sender, EventArgs e)
        {
            var persons = personRepository.GetAll();
            cmbPerson.DataSource = persons;

            if (BookTransactionData.BookStatus == BookStatus.OnTheShelf)
            {
                dateTimeStartDate.Value = DateTime.Now.Date;
                dateTimeEndDate.Value = DateTime.Now.AddDays(15).Date;
                dateTimeReturnDate.Value = DateTime.Now.AddDays(15).Date;
                dateTimeReturnDate.Enabled = false;
                cmbPerson.Enabled = true;
                this.Text = "Ödünç Ver";
                btnLean.Text = "Ödünç Ver";
                txtAmount.Text = string.Empty;
            }
            else if (BookTransactionData.BookStatus == BookStatus.InUser)
            {
                var book = bookRepository.GetById(BookTransactionData.BookId);
                if (book != null)
                {
                    dateTimeStartDate.Value = book.BookTransaction.StartDate;
                    dateTimeEndDate.Value = book.BookTransaction.EndDate;
                    dateTimeReturnDate.Value = DateTime.Now;
                    cmbPerson.SelectedValue = book.BookTransaction.PersonId;
                    cmbPerson.Enabled = false;
                    txtAmount.Text = CalculatePenalty().ToString("C", CultureInfo.GetCultureInfo("tr-TR"));
                }
                this.Text = "Teslim Al";
                btnLean.Text = "Teslim Al";
            }
        }

        private void btnLean_Click(object sender, EventArgs e)
        {
            var book = bookRepository.GetById(BookTransactionData.BookId);

            if (BookTransactionData.BookStatus == BookStatus.OnTheShelf)
            {
                BookTransaction bookTransaction = new BookTransaction
                {
                    BookId = BookTransactionData.BookId,
                    PersonId = Int32.Parse(cmbPerson.SelectedValue.ToString()),
                    StartDate = dateTimeStartDate.Value,
                    EndDate = dateTimeEndDate.Value
                };
                var bookTransactionId = bookTransactionRepository.Post(bookTransaction);
                if (book != null)
                {
                    book.LastTransactionId = bookTransactionId;
                    book.Status = BookStatus.InUser;
                    bookRepository.Put(book);
                }
            }
            else if (BookTransactionData.BookStatus == BookStatus.InUser)
            {
                if (book.LastTransactionId != null)
                {
                    var bookTransaction = book.BookTransaction;
                    bookTransaction.ReturnDate = dateTimeReturnDate.Value;
                    bookTransaction.Amount = CalculatePenalty();
                    bookTransactionRepository.Put(bookTransaction);
                }

                if (book != null)
                {
                    book.LastTransactionId = null;
                    book.Status = BookStatus.OnTheShelf;
                    bookRepository.Put(book);
                }
            }
            FrmBooks.frmBook.LoadGridData();
            this.Close();
        }

        private decimal CalculatePenalty()
        {
            decimal amount = 0;
            if (dateTimeReturnDate.Value > dateTimeEndDate.Value)
            {
                var differenceDay = (dateTimeReturnDate.Value.Date - dateTimeEndDate.Value.Date).Days;
                amount = (decimal)differenceDay * 0.5M;
            }
            return amount;
        }

        private void FrmLeanBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
