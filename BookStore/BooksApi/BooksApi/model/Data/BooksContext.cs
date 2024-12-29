using Microsoft.EntityFrameworkCore;
using BooksApi.model;

namespace BooksApi.Data
{
    public class BooksContext : DbContext
    {
        // Use null-forgiving operator (!) to suppress the warning
        public DbSet<Book> Books { get; init; } = null!;

        public BooksContext(DbContextOptions<BooksContext> options) : base(options) { }
    }
}
