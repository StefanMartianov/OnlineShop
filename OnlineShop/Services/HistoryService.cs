using OnlineShop.Domain;
namespace OnlineShop.Services;

class HistoryService
{
    public List<Order> Histories { get; set; }

    public HistoryService()
    {
        Histories = new List<Order>();
    }

    public void ShowHistory(HistoryService historyService)
    {
        for (int i = 0; i < Histories.Count; i++)
        {
            var history = Histories.ElementAt(i);

            Console.WriteLine($"{i + 1}. Order date: {history.OrderDate}. Paymethod: {history.PayMethod}.Price: {history.OrderPrice}. Delivery address: {history.DeliveryAddress}.");

            var products = history.Products;
            var coupons = history.Coupons;

            for (int j = 0; j < products.Count; j++)
            {
                var product = products.ElementAt(j);

                Console.WriteLine($"{j + 1}. Product: {product.ProductName}.{product.Price:C2}.");
                
            }

            for (int j = 0; j < coupons.Count; j++) 
            { 
                var coupon = coupons.ElementAt(j);

                Console.WriteLine($"{j + 1}. Coupon: {coupon.CouponsName}.{coupon.CouponsPrice:C2}.");
            }
        }

        Console.WriteLine("Click any key to continued");
        Console.ReadKey();
    }

    public void AddOrderHistory(Order order)
    { 
        Histories.Add(order);
    }
}
