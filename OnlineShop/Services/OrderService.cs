using OnlineShop.Domain;
namespace OnlineShop.Services;

class OrderService
{
    private Order Order { get; set; }

    public OrderService(UserService userService)
    {
        Order = new Order(userService.CurrentUser);
    }

    public void ChooseProduct(ProductService productService)
    {
        productService.ShowProductList();

        Console.WriteLine("Choose your products: ");

        var product = productService.GetProduct();

        if (product != null)
        {
            Order.Products.Add(product);
        }
    }

    public void AddCoupon(CouponService couponService)
    {
        couponService.ShowCouponList();

        Console.WriteLine("Choose your coupons: ");

        var coupon = couponService.GetCoupon();

        if (coupon != null)
        {
            Order.Coupons.Add(coupon);
        }
    }

    public void ShowOrder()
    {
        ShowProductsFromOrder();

        ShowCouponsFromOrder();

        Console.WriteLine($"Your address is: {Order.DeliveryAddress}");

        Console.WriteLine("click any key");
        Console.ReadKey();
    }

    private void ShowProductsFromOrder()
    {
        for (int i = 0; i < Order.Products.Count; i++)
        {
            var product = Order.Products.ElementAt(i);

            Console.WriteLine
                ($"{i + 1}. " +
                $"{product.ProductName}. " +
                $"{product.Price}. " +
                $"{product.ProductProvider}.");
        }
    }
    private void ShowCouponsFromOrder()
    {
        for (int i = 0; i < Order.Coupons.Count; i++)
        {
            var coupon = Order.Coupons.ElementAt(i);

            Console.WriteLine
                ($"{i + 1}. " +
                $"{coupon.CouponsName}. " +
                $"{coupon.CouponsPrice}. ");
        }
    }

    public void ChangeDeliveryAdress()
    {
        Console.WriteLine("Enter delivery address: ");

        var adress = Console.ReadLine();
        Order.DeliveryAddress = adress;

        Console.WriteLine($"Your delivery address now is {adress}");
    }

    public void DeleteProduct(ProductService productService)
    {
        ShowProductsFromOrder();

        Console.WriteLine("Enter to delete products: ");
        var delete = Console.ReadLine();
        var ProductNumber = 0;
        if (int.TryParse(delete, out ProductNumber))
        {
            if (ProductNumber > 0 &&
                Order.Products.Count >= ProductNumber)
            {
                Order.Products.RemoveAt(ProductNumber - 1);
            }
        }
    }
    public void DeleteCoupons(CouponService couponService)
    {
        ShowCouponsFromOrder();

        Console.WriteLine("Enter to delete coupons: ");
        var delete = Console.ReadLine();
        var couponNumber = 0;
        if (int.TryParse(delete, out couponNumber))
        {
            if (couponNumber > 0 &&
                Order.Coupons.Count >= couponNumber)
            {
                Order.Coupons.RemoveAt(couponNumber - 1);
            }
        }
    }

    public void PayOrder(HistoryService historyService, User user)
    {
        ShowProductsFromOrder();
        ShowCouponsFromOrder();

        Console.WriteLine("Enter to the pay order");
        var payOrder = Console.ReadLine();

        Order.OrderDate = DateTime.Now;
        Order.PayMethod = payOrder;
        double orderSum = 0;
        
        for (int i = 0; i < Order.Products.Count; i++)
        {
            var product = Order.Products.ElementAt(i);
            orderSum += product.Price;
        }

        for (int i = 0; i < Order.Coupons.Count; i++) 
        {
            var coupon = Order.Coupons.ElementAt(i);
            orderSum -= coupon.CouponsPrice;
        }
        

        Order.OrderPrice = orderSum;

        historyService.AddOrderHistory(Order);

        Order = new Order(user);

        Console.WriteLine($"Your order was payted.The price is {orderSum}");
    }
}
