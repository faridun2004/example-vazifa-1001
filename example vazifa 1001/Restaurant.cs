using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_vazifa_1001
{
    public class Restaurant
    {
        public List<Dish> Menu { get; set; }

        public Restaurant()
        {
            Menu = new List<Dish>
        {
            new Dish("Паста", 12.99),
            new Dish("Стейк", 18.99),
            new Dish("Салат", 7.99)
        };
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Меню ресторана:");
            foreach (var dish in Menu)
            {
                Console.WriteLine($"{dish.Name} - ${dish.Price}");
            }
        }

        public Order PlaceOrder()
        {
            Order order = new Order();
            Console.WriteLine("Введите номера блюд, которые вы хотите заказать (или '0' для завершения):");

            DisplayMenu();

            int choice;
            do
            {
                Console.Write("Номер блюда: ");
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
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                }

            } while (true);

            Console.WriteLine("Заказ размещен!");
            return order;
        }
    }
}
