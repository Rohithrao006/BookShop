using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Areas.Admin.Customers.Controllers
{
    [Area("Customers")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}