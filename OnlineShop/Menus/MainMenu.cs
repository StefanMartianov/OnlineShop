using OnlineShop.Services;

namespace OnlineShop.Menus;

class MainMenu
{
    public static void ShowMainMenu(
        UserService userService,
        ProductService productService,
        CouponService couponService,
        OrderService orderService,
        HistoryService historyService)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Enter 1 to see the product: ");
            Console.WriteLine("Enter 2 to see the coupons: ");
            Console.WriteLine("Enter 3 to see purchase history: ");
            Console.WriteLine("Enter 4 to buy product: ");
            Console.WriteLine("Enter 5 to change users data: ");
            Console.WriteLine("Enter 6 to the LogOut: ");

            var input = Console.ReadLine();

            if (input == "1")
            {
                MenuForProducts.ShowProductsMenu(productService);
            }
            else if (input == "2")
            {
                MenuForCoupons.ShowCouponsMenu(couponService);
            }
            else if (input == "3")
            {
                MenuForHistories.ShowOrdersHistoryMenu(historyService);
            }
            else if (input == "4")
            {
                MenuForOrders.ShowOrderMenu(
                    orderService, 
                    productService,
                    couponService,
                    historyService);
            }
            else if (input == "5")
            {
                userService.ShowChangesUsersData();
            }
            else if (input == "6")
            {
                break;
            }
        }
    }
}
