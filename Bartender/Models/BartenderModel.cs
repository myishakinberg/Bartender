using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender.Models
{
    public class BartenderModel
    {
        public string Username {get; set;}
        public string Password {get; set;}
        public List<DrinkQueue> BartenderQueue = new List<DrinkQueue>();

        public BartenderModel()
        {
            DrinkQueue Customer1 = new DrinkQueue();
            Customer1.CustomerName = "Jane";
            Customer1.DrinkName = "French 75";
            Customer1.DrinkQuantity = 1;
 
            DrinkQueue Customer2 = new DrinkQueue();
            Customer2.CustomerName = "Tyrone";
            Customer2.DrinkName = "Bourbon Whiskey";
            Customer2.DrinkQuantity = 3;

            DrinkQueue Customer3 = new DrinkQueue();
            Customer3.CustomerName = "Jesse";
            Customer3.DrinkName = "Champange Cocktail";
            Customer3.DrinkQuantity = 9;


            DrinkQueue Customer4 = new DrinkQueue();
            Customer4.CustomerName = "September";
            Customer4.DrinkName = "French 75";
            Customer4.DrinkQuantity = 2;

            BartenderQueue.Insert(0, Customer1);
            BartenderQueue.Insert(1, Customer2);
            BartenderQueue.Insert(2, Customer3);
            BartenderQueue.Insert(3, Customer4);
        }
    }
}
