using OnlineShop.Services;

namespace OnlineShop.Menus;

class MenuForOrders
{
    public static void ShowOrderMenu(
        OrderService orderService,
        ProductService productService,
        CouponService couponService,
        HistoryService historyService)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Enter 1 to choose products: ");
            Console.WriteLine("Enter 2 to enter Delivery address: ");
            Console.WriteLine("Enter 3 to enter your coupons: ");
            //Console.WriteLine("Enter 4 to choose the pay method: ");
            Console.WriteLine("Enter 4 to pay your orders: ");
            Console.WriteLine("Enter 5 to delete the products: ");
            Console.WriteLine("Enter 6 to show your order: ");
            Console.WriteLine("Enter 7 to exit: ");

            var input = Console.ReadLine();

            if (input == "1")
            {
                orderService.ChooseProduct(productService);
            }
            else if (input == "2")
            {
                orderService.ChangeDeliveryAdress();
            }
            else if (input == "3")
            {
                orderService.AddCoupon(couponService);
            }
            else if (input == "4")
            {
                orderService.PayOrder(historyService);
                Console.WriteLine("press any key to continue..");
                Console.ReadKey();
            }
            else if (input == "5")
            {
                orderService.DeleteProduct(productService);
            }
            else if (input == "6")
            {
                orderService.ShowOrder();
            }
            else if (input == "7")
            {
                break;
            }
        }
    }
}
