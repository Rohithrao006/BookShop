using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Areas.Admin.Countries.Controllers
{
    [Area("Countries")]
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {
            //ViewBag.Id=id;
            return View();
        }
    }
}