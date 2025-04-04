namespace OnlineShop;

class MenuForHistories
{
    public static void ShowOrdersHistoryMenu(HistoryService historyService)
    {
        while (true)
        {
            var input = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Enter 1 to see - Your Orders-history: ");
            Console.WriteLine("Enter 2 to exit: ");

            if (input == "1")
            {
                Console.WriteLine("Your Orders-history: ");
            }
            else if (input == "2")
            {
                break; //MainMenu;
            }


        }

    }
}
