using Microsoft.EntityFrameworkCore;

namespace BookShop.Areas.Admin.Models
{
    public class BookShopDBContext:DbContext
    {
        public BookShopDBContext(DbContextOptions options):base(options)
        {

        }
       // public DbSet<Customer> Customers{get;set;}
    }
}