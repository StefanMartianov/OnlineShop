using OnlineShop.Services;

namespace OnlineShop.Menus;

class MenuForHistories
{
    public static void ShowOrdersHistoryMenu(HistoryService historyService)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Enter 1 to see - Your Orders-history: ");
            Console.WriteLine("Enter 2 to exit: ");

            var input = Console.ReadLine();

            if (input == "1")
            {
                historyService.ShowHistory(historyService);
            }
            else if (input == "2")
            {
                break; //MainMenu;
            }


        }

    }
}
