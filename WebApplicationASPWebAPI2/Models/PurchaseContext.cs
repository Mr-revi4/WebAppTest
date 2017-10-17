using System.Data.Entity;

namespace WebApplicationASPWebAPI2.Models
{
    public class PurchaseContext: DbContext
    {
        public DbSet<Purchase> Purchases { get; set; }
    }
}