namespace OnlineShop.Domain;

class Order
{
    public string OrderNumber {get; set; }
    public double OrderPrice { get; set; }

    public DateTime OrderDate { get; set; }
    public string PayMethod { get; set; }
    public User User { get; set; }

    //public List<Product> Products { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();
    public List<Coupon> Coupons { get; set; } = new List<Coupon>();

    public string DeliveryAddress { get; set; }

    public Order(User user)
    {
        User = user;
    }
}
