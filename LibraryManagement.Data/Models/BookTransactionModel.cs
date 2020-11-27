using LibraryManagement.Data.Enums;

namespace LibraryManagement.Data.Models
{
    public static class BookTransactionData
    {
        public static int BookId { get; set; }
        public static BookStatus BookStatus { get; set; }
    }

    public class BookTransactionModel
    {
    }
}
