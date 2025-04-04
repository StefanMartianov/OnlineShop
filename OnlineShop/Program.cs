using OnlineShop;

var userService = new UserService();
userService.Users = new List<User>();
var productService = new ProductService();
productService.Products = new List<Product>();
var couponService = new CouponService();
couponService.Coupons = new List<Coupon>();
var historyService = new HistoryService();
historyService.Histories = new List<History>();
var orderService = new OrderService();
orderService.Orders = new List<Order>();

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

