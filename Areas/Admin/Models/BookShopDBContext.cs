using Microsoft.EntityFrameworkCore;
namespace BookShop.Areas.Admin.Models
{
    public partial class BookShopDBContext:DbContext
    {
        public BookShopDBContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Customer> Customers{get;set;}
        public DbSet<Countries> Countries{get;set;}
        public DbSet<CityState> CitySates{get; set;}
    }
}