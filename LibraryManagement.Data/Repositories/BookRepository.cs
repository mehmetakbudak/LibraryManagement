using LibraryManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Data.Repositories
{
    public interface IBookRepository
    {
        List<Books> GetAll();
    }

    public class BookRepository : IBookRepository
    {
        private LibraryContext context;
        public BookRepository(LibraryContext context)
        {
            this.context = context;
        }

        public List<Books> GetAll()
        {
            try
            {
                return context.Books.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
