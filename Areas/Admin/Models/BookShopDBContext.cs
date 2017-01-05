using Microsoft.EntityFrameworkCore;

namespace BookShop.Areas.Admin.Models
{
    public class BookShopDbContext:DbContext
    {
        public BookShopDbContext()
        {

        }
        public DbSet<Countries> Countries{get;set;}
    }
}