using System.Data.Entity;

namespace WebAPITest1.Models
{
    public class MusicContext: DbContext
    {
        public DbSet<Music> Music { get; set; }
    }
}