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

        public int Strength { get; set; }

        public bool Sugar { get; set; }
        public bool Milk { get; set; }
        public bool Cream { get; set; }
        public bool Syrup { get; set; }

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

        public Coffee(int coffeeId, string coffeeName, string description, string price, int strength, bool sugar, bool milk, bool cream, bool syrup)
        {
            CoffeeId = coffeeId;
            CoffeeName = coffeeName;
            Description = description;
            Price = price;
            Strength = strength;
            Sugar = sugar;
            Milk = milk;
            Cream = cream;
            Syrup = syrup;
        }
    }
}
