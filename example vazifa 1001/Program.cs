using example_vazifa_1001;

internal class Program
{
    public static void Main(string[] args)
    {
        Restaurant restaurant = new Restaurant();

        Console.WriteLine("Welcome to the restaurant!");

        while (true)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. View menu");
            Console.WriteLine("2. Place an order");
            Console.WriteLine("3. Exit");

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
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }
    }
}



