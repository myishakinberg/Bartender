using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender.Models
{
    public class DrinkQueue
    {
        public List<RequestedDrinks> Queue = new List<RequestedDrinks>();

        public DrinkQueue()
        {
            RequestedDrinks Customer1 = new RequestedDrinks();
            Customer1.CustomerName = "Jane";
            Customer1.DrinkName = "French 75";
            Customer1.DrinkQuantity = 1;
        }
    }
}
