using OnlineShop.Domain;
using OnlineShop.Menus;
using OnlineShop.Services;

var userService = new UserService();

var productService = new ProductService();

var couponService = new CouponService();

var historyService = new HistoryService();

var orderService = new OrderService();


while (true)
{
    Console.Clear();
    Console.WriteLine("Enter 1 for registration:");
    Console.WriteLine("Enter 2 for login:");
    Console.WriteLine("Enter 3 for exit: ");

    var input = Console.ReadLine();

    if (input == "1")
    {
        userService.RegisterUser();
    }
    else if (input == "2")
    {
        var successFullYourLogin = userService.LoginIn();

        if (successFullYourLogin)
        {
            Console.WriteLine("You was successfully login");

            //here is main menu
            MainMenu.ShowMainMenu
                (
                userService, 
                productService,
                couponService,
                orderService,
                historyService
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

