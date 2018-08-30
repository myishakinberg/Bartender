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
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Menu()
        {
            DrinkMenu menu = new DrinkMenu();
            return View(menu);
        }

        public IActionResult BartenderView()
        {
            BartenderModel bartender = new BartenderModel();
            return View(bartender);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AjaxCallForDrinkRequest(string customerName, string drinkName, string drinkQuantity)
        {
            DrinkQueue newOrder = new DrinkQueue();
            newOrder.CustomerName = customerName;
            newOrder.DrinkName = drinkName;
            newOrder.DrinkQuantity = Int32.Parse(drinkQuantity);

            BartenderModel drinkQueue = new BartenderModel();
            drinkQueue.BartenderQueue.Add(newOrder);
            return RedirectToAction("BartenderView", drinkQueue);
        }
    }
}
