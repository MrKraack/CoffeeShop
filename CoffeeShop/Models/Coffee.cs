using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Coffee
    {
        public string CoffeeName { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        [Key]
        public int CoffeeId { get; set; }


        public Coffee()
        {

        }

        public Coffee(int coffeeId, string coffeeName, string description, string price)
        {
            CoffeeId = coffeeId;
            CoffeeName = coffeeName;
            Description = description;
            Price = price;
        }
    }
}
