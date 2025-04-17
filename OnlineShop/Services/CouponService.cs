using OnlineShop.Domain;

namespace OnlineShop.Services;

class CouponService
{
    public List<Coupon> Coupons { get; set; }

    public CouponService()
    {
        Coupons = new List<Coupon>();

        var testCoupon = new Coupon("Sales", 100);
        Coupons.Add(testCoupon);
    }

    public Coupon GetCoupon() 
    {
        var coupontText = Console.ReadLine();
        var couponNumber = 0;
        if (int.TryParse(coupontText, out couponNumber))
        {
            if (couponNumber > 0 &&
                Coupons.Count >= couponNumber)
            {
                var coupon = Coupons.ElementAt(couponNumber - 1);

                return coupon;
            }
        }

        return null;
    }

    public void AddCoupons()
    {
        Console.Clear();
        Console.WriteLine("Enter to add coupons: ");
        var item = Console.ReadLine();
        Console.WriteLine("Enter the price of this coupons: ");
        var priceString = Console.ReadLine();
        var price = double.Parse(priceString);

        var coupon = new Coupon(item, price);
        Coupons.Add(coupon);
    }

    public void EditCoupons()
    {
        ShowCouponList();

        Console.WriteLine("Choose your product to edit: ");
        var edit = Console.ReadLine();

        var couponEdit = 0;
        if (int.TryParse(edit, out couponEdit))
        {
            if (couponEdit > 0 &&
                Coupons.Count >= couponEdit)
            {
                var coupon = Coupons.ElementAt(couponEdit - 1);

                Console.WriteLine("Enter a new coupon name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Enter a new coupon price: ");
                var priceString = Console.ReadLine();
                var price = double.Parse(priceString);

                coupon.CouponsName = name;
                coupon.CouponsPrice = price;

                Console.WriteLine($"Your edited coupon is {name}, and the edited price is {price}");
            }
        }
    }

    public void DeleteCoupons()
    {
        ShowCouponList();

        Console.WriteLine("Enter to delete coupons: ");
        var delete = Console.ReadLine();

        var couponNumber = 0;
        if (int.TryParse(delete, out couponNumber))
        {
            if (couponNumber > 0 &&
                Coupons.Count >= couponNumber)
            {
                Coupons.RemoveAt(couponNumber - 1);
            }
        }
    }

    public void ShowCouponList()
    {
        for (int i = 0; i < Coupons.Count; i++)
        {
            var product = Coupons.ElementAt(i);

            Console.WriteLine($"{i + 1}. {product.CouponsName}");
        }
    }
}
