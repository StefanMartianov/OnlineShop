namespace OnlineShop;

class History
{
    public string ProductName { get; set; }
    public DateTime DeliveryTime { get; set; }
    public string DeliveryAdress{ get; set; }

    public History(string productName, DateTime deliveryTime, string productProvider)
    {
        ProductName = productName;
        DeliveryTime = deliveryTime;
        DeliveryAdress = productProvider;
    }
}
