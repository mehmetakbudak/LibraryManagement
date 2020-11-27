using System;

namespace LibraryManagement.Data.Entities
{
    public class BookTransaction : BaseEntity
    {
        public int BookId { get; set; }
        public virtual Book Book{ get; set; }
        public int PersonId { get; set; }
        public virtual Person Person{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal? Amount { get; set; }
    }
}
