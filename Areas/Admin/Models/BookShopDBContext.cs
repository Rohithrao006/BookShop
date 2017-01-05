using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> af3c43dd58a43589183061b72c6cce301eef254f

namespace BookShop.Areas.Admin.Models
{
    public class BookShopDBContext:DbContext
    {
<<<<<<< HEAD
        public BookShopDBContext(DbContextOptions options):base(options)
        {

        }
       // public DbSet<Customer> Customers{get;set;}
=======
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
>>>>>>> af3c43dd58a43589183061b72c6cce301eef254f
    }
}