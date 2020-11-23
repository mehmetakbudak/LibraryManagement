using System;

namespace LibraryManagement.Data.Entities
{
    public class BookTransactions : BaseEntity
    {
        public int BookId { get; set; }
        public Books Books{ get; set; }
        public int PersonId { get; set; }
        public Persons Persons{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal? Amount { get; set; }
    }
}
