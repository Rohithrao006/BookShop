using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD

namespace BookShop.Areas.Admin.Models
{
    public class BookShopDBContext:DbContext
    {
        public BookShopDBContext()
        {

        }
        public DbSet<Countries> Countries{get;set;}
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Areas.Admin.Models
{
    public class BookShopDBContext:DbContext
    {
        public BookShopDBContext()
        {
            
        }
        public DbSet<CityState> CitySates{get; set;}
>>>>>>> 716bee1b11c87c6e1042a51c4ffd00076d567679
    }
}