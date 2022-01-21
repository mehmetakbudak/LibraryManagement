using LibraryManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options) {}

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<BookTransaction> BookTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
