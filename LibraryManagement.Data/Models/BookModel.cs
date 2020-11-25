using LibraryManagement.Data.Entities;
using LibraryManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Data.Models
{
    public class BookModel : BaseEntity
    {
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public int PageNumber { get; set; }
        public decimal Price { get; set; }
        public BookStatus Status { get; set; }
        public string StatusName
        {
            get
            {
                string name = string.Empty;
                switch (Status)
                {
                    case BookStatus.OnTheShelf:
                        name = "Rafta";
                        break;
                    case BookStatus.InUser:
                        name = "Üyede";
                        break;
                    case BookStatus.Unavailable:
                        name = "Uygun Değil";
                        break;
                    default:
                        break;
                }
                return name;
            }
        }
        public bool IsActive { get; set; }

    }
}
