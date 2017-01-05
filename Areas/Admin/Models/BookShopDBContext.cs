using Microsoft.EntityFrameworkCore;
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
    }
}