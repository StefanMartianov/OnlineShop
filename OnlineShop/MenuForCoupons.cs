namespace OnlineShop;

class MenuForCoupons
{
    public static void ShowCouponsMenu(CouponService couponService) 
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Enter 1 to add new coupon: ");
            Console.WriteLine("Enter 2 to delete coupon: ");
            Console.WriteLine("Enter 3 to show coupons: ");
            Console.WriteLine("Enter 4 to edit coupon: ");
            Console.WriteLine("Enter 5 to exit: ");

            var input = Console.ReadLine();

            if (input == "1")
            {
                couponService.AddCoupons();
            }
            else if (input == "2")
            {
                couponService.DeleteCoupons();
            }
            else if (input == "3")
            {
                couponService.ShowCouponList();

                Console.WriteLine("press any key to continue..");
                Console.ReadKey();
            }
            else if (input == "4") 
            {
                couponService.EditCoupons();
            }
            else if (input == "5")
            {
                break; //MainMenu;
            }
        }
    }

}

