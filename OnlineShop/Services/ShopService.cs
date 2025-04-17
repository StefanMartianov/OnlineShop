using OnlineShop.Menus;

namespace OnlineShop.Services;

class ShopService
{
    public CouponService CouponService { get; set; }
    public ProductService ProductService { get; set; }
    public UserService UserService { get; set; }
    public HistoryService HistoryService { get; set; }
    public OrderService OrderService { get; set; }

    public ShopService()
    {
        CouponService = new CouponService();
        ProductService = new ProductService();
        UserService = new UserService();
        HistoryService = new HistoryService();
        OrderService = new OrderService();
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
