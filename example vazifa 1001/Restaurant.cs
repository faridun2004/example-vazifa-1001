using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_vazifa_1001
{
    public class Restaurant
    {
        public List<Dish> Menu { get; set;}

        public Restaurant()
        {
            
            Menu = new List<Dish>
        {
            new Dish("pizza", 12.99,"1 ps"),
            new Dish("Steak", 18.99,"100 kg"),
            new Dish("Salad", 7.99,"100 gr"),
            new Dish("Pilov", 15.50, "1 ps"),
            new Dish("shashlik", 20.00, "1 ps"),
            new Dish("French fries",18.99, "1 ps"),
            new Dish("French fries",18.99, "1 ps")
        };
        }


        public void DisplayMenu()
        {
            Console.WriteLine("Restaurant menu:");
            int count = 0;
            foreach (var dish in Menu)
            {       
                count++;
                    Console.WriteLine($"{count} - {dish.Name} - ${dish.Price} - {dish.Amount}");
                
            }
        }
        public Order PlaceOrder()
        {
            Order order = new Order();
            Console.WriteLine("Enter the numbers of the dishes you want to order (or '0' to complete):");

            DisplayMenu();

            int choice;
            do
            {
                Console.Write("Dish number: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out choice) && choice >= 0 && choice <= Menu.Count)
                {
                    if (choice == 0)
                    {
                        break;
                    }
                    else
                    {
                        Dish selectedDish = Menu[choice - 1];
                        order.AddDish(selectedDish);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }

            } while (true);

            Console.WriteLine("The order has been placed!");
            return order;
        }
    }
}
