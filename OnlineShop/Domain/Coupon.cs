namespace OnlineShop.Domain;

class Coupon
{

    public string CouponsName { get; set; }
    public double CouponsPrice { get; set; }
    

    public Coupon(string couponsName, double couponsPrice)
    {
        CouponsName = couponsName;
        CouponsPrice = couponsPrice;
    }
}
