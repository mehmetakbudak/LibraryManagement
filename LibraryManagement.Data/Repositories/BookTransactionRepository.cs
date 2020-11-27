using LibraryManagement.Data.Entities;

namespace LibraryManagement.Data.Repositories
{
    public interface IBookTransactionRepository
    {
        int Post(BookTransaction bookTransaction);
        int Put(BookTransaction bookTransaction);
    }

    public class BookTransactionRepository : IBookTransactionRepository
    {
        private readonly LibraryContext context;
        public BookTransactionRepository(LibraryContext context)
        {
            this.context = context;
        }
        
        public int Post(BookTransaction bookTransaction)
        {
            context.BookTransactions.Add(bookTransaction);
            context.SaveChanges();
            return bookTransaction.Id;
        }

        public int Put(BookTransaction bookTransaction)
        {
            context.Update(bookTransaction);
            return context.SaveChanges();
        }
    }
}
