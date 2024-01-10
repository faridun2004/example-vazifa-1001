using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_vazifa_1001
{
    public class Dish
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Dish(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
