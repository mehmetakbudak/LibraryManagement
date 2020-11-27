using LibraryManagement.Data.Entities;
using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Data.Repositories
{
    public interface IBookRepository
    {
        List<BookModel> GetAll();
        Book GetById(int id);
        int Put(Book book);
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
            return context.Books
                .Include(x => x.Author)
                .Include(x => x.Category)
                .Include(x => x.Publisher)
                .Where(x => !x.Deleted).Select(x => new BookModel
                {
                    AuthorName = x.Author.FullName,
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
            var book = context.Books
                .Include(x => x.BookTransaction)
                .FirstOrDefault(x => x.Id == id);
            return book;
        }

        public int Put(Book book)
        {
            context.Update(book);
            return context.SaveChanges();
        }
    }
}
