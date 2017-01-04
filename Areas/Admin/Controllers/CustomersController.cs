using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}