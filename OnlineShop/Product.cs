namespace OnlineShop;

class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    public string ProductProvider { get; set; }

    public Product(string productName, double price, string productProvider)
    {
        ProductName = productName;
        Price = price;
        ProductProvider = productProvider;
    }
}
