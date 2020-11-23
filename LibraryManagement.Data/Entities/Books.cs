using LibraryManagement.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Data.Entities
{
    public class Books : BaseEntity
    {
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public Categories Categories { get; set; }

        public int AuthorId { get; set; }

        public Authors Authors { get; set; }

        public int PublisherId { get; set; }

        public Publishers Publishers { get; set; }

        [ForeignKey("BookTransactions")]
        public int LastTransactionId { get; set; }

        public BookTransactions BookTransactions { get; set; }

        public int PageNumber { get; set; }

        public decimal Price { get; set; }
        
        public BookStatus Status { get; set; }

        public bool IsActive { get; set; }

        public bool Deleted { get; set; }
    }
}
