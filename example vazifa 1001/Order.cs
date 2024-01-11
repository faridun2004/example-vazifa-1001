using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_vazifa_1001
{
    public class Order
    {
        public List<Dish> Items { get; set; }
        public double TotalPrice { get; private set; }

        public Order()
        {
            Items = new List<Dish>();
            TotalPrice = 0;
        }

        public void AddDish(Dish dish)
        {
            Items.Add(dish);
            TotalPrice += dish.Price;
        }

        public void DisplayOrder()
        {
            Console.WriteLine("Order:");
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Name} - ${item.Price} - {item.Amount}");
            }
            Console.WriteLine();
            Console.WriteLine($"Total: ${TotalPrice}");
        }
    }
}
