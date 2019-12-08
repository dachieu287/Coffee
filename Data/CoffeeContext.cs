using Microsoft.EntityFrameworkCore;
using Coffee.Models;

namespace Coffee.Data
{
    public class CoffeeContext : DbContext
    {
        public CoffeeContext(DbContextOptions<CoffeeContext> options)
            : base(options) 
        { 
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<BookATable> BookATable { get; set; } 
    }
}
