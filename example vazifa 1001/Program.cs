using example_vazifa_1001;

internal class Program
{
    public static void Main(string[] args)
    {
        Restaurant restaurant = new Restaurant();

        Console.WriteLine("Добро пожаловать в ресторан!");

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Посмотреть меню");
            Console.WriteLine("2. Разместить заказ");
            Console.WriteLine("3. Выход");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        restaurant.DisplayMenu();
                        break;
                    case 2:
                        Order order = restaurant.PlaceOrder();
                        order.DisplayOrder();
                        break;
                    case 3:
                        Console.WriteLine("До свидания!");
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }
        }
    }
}



