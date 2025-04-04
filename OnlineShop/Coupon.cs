namespace OnlineShop;

class Coupon
{

    public string CouponsName { get; set; }
    public double CouponsPrice { get; set; }
    

    public Coupon(string couponsName, double couponsPrice)
    {
        CouponsName = couponsName;
        CouponsPrice = couponsPrice;
    }

    public string CouponInfo()
    {
        return $"Your choose coupon is {CouponsName}, the price with your coupon is {CouponsPrice} : ";
    }
}
