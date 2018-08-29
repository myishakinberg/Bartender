using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bartender.Models;

namespace Bartender.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            BartenderModel bartender = new BartenderModel();
            return View(bartender);
        }
        public IActionResult Menu()
        {
            DrinkMenu menu = new DrinkMenu();
            return View(menu);
        }
        public IActionResult About()
        {
            DrinkMenu menu = new DrinkMenu();
            return View(menu);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
