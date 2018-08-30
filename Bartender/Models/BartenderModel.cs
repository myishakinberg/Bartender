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

            BartenderQueue.Add(Customer1);
 
            DrinkQueue Customer2 = new DrinkQueue();
            Customer1.CustomerName = "Tyrone";
            Customer1.DrinkName = "Bourbon";
            Customer1.DrinkQuantity = 3;

            BartenderQueue.Add(Customer2);

            DrinkQueue Customer3 = new DrinkQueue();
            Customer1.CustomerName = "Jesse";
            Customer1.DrinkName = "Champange";
            Customer1.DrinkQuantity = 9;

            BartenderQueue.Add(Customer3);

            DrinkQueue Customer4 = new DrinkQueue();
            Customer1.CustomerName = "September";
            Customer1.DrinkName = "French 75";
            Customer1.DrinkQuantity = 2;
            BartenderQueue.Add(Customer4);
        }
    }
}
