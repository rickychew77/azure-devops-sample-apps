using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using asp_dotnetcore.Models;

namespace asp_dotnetcore.Controllers
{
    public class HomeController : Controller
    {
        
        public HomeController()
        {
        }


        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        public IActionResult About()
        {
            return View("About");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
