namespace OnlineShop;

class MenuForOrders
{
    public static void ShowOrderMenu(OrderService orderService)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Enter 1 to buy products: ");
            Console.WriteLine("Enter 2 to enter Delivery address: ");
            Console.WriteLine("Enter 3 to enter promo-code: ");
            Console.WriteLine("Enter 4 to pay your orders: ");
            Console.WriteLine("Enter 5 to cancel the current order: ");
            Console.WriteLine("Enter 6 to exit: ");

            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Your order in basket: ");

            }
            else if (input == "2")
            {
                Console.WriteLine("Enter delivery address: ");
            }
            else if (input == "3")
            {
                Console.WriteLine("Pay your orders: ");
            }
            else if (input == "4")
            {
                Console.WriteLine("cancel the current order: ");
            }
            else if (input == "5")
            {
                break;
            }
        }
    }
}
