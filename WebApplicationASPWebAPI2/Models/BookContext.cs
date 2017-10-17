using System.Data.Entity;

namespace WebApplicationASPWebAPI2.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}