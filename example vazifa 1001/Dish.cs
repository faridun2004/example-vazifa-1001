using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_vazifa_1001
{
    public class Dish
    {
       //public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Amount {  get; set; }
        public Dish(string name, double price, string amount)
        {
            //Id = id;
            Name = name;
            Price = price;
            Amount = amount;
        }
    }
}
