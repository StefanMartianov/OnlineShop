using OnlineShop.Menus;

namespace OnlineShop.Services;

class ShopService
{
    private CouponService CouponService { get; init; }
    private ProductService ProductService { get; init; }
    private UserService UserService { get; init; }
    private HistoryService HistoryService { get; init; }
    private OrderService OrderService { get; init; }

    public ShopService()
    {
        CouponService = new CouponService();
        ProductService = new ProductService();
        UserService = new UserService();
        HistoryService = new HistoryService();
        OrderService = new OrderService(UserService);
    }

    public void ShowStartMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Enter 1 for registration:");
            Console.WriteLine("Enter 2 for login:");
            Console.WriteLine("Enter 3 for exit: ");

            var input = Console.ReadLine();

            if (input == "1")
            {
                UserService.RegisterUser();
            }
            else if (input == "2")
            {
                var successFullYourLogin = UserService.LoginIn();

                if (successFullYourLogin)
                {
                    Console.WriteLine("You was successfully login");

                    //here is main menu
                    MainMenu.ShowMainMenu
                        (
                        UserService,
                        ProductService,
                        CouponService,
                        OrderService,
                        HistoryService
                        );
                }
                else
                {
                    Console.WriteLine("login failed");
                }
            }
            else
            {
                break;
            }
        }
    }
}
