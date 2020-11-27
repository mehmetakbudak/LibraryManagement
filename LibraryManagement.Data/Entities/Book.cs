using LibraryManagement.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Data.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public int PublisherId { get; set; }

        public virtual Publisher Publisher { get; set; }

        [ForeignKey("BookTransaction")]
        public int? LastTransactionId { get; set; }

        public virtual BookTransaction BookTransaction { get; set; }

        public int PageNumber { get; set; }

        public decimal Price { get; set; }
        
        public BookStatus Status { get; set; }

        public bool IsActive { get; set; }

        public bool Deleted { get; set; }
    }
}
