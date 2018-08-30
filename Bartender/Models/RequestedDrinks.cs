using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender.Models
{
    public class RequestedDrinks
    {
        public string CustomerName { get; set; }
        public string DrinkName { get; set; }
        public int DrinkQuantity { get; set; }

    }
}
