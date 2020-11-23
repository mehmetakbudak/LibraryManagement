using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data.Entities
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options) { }

        public DbSet<Books> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Publishers> Publishers { get; set; }
        public DbSet<Persons> Persons { get; set; }
        public DbSet<BookTransactions> BookTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
