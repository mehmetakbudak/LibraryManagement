using LibraryManagement.Data.Entities;
using LibraryManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Data.Repositories
{
    public interface IBookRepository
    {
        List<BookModel> GetAll();
        Book GetById(int id);
    }

    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext context;
        public BookRepository(LibraryContext context)
        {
            this.context = context;
        }

        public List<BookModel> GetAll()
        {
            return context.Books.Where(x => !x.Deleted).Select(x => new BookModel
            {
                AuthorName = x.Author.Name,
                CategoryName = x.Category.Name,
                Id = x.Id,
                IsActive = x.IsActive,
                Name = x.Name,
                PageNumber = x.PageNumber,
                Price = x.Price,
                PublisherName = x.Publisher.Name,
                Status = x.Status
            }).ToList();
        }

        public Book GetById(int id)
        {
            return context.Books.Find(id);
        }
    }
}
