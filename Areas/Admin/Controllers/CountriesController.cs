using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CountriesController : Controller
    {
        public IActionResult Index(int? id)
        {
            //ViewBag.Id=id;
            return View();
        }
    }
}