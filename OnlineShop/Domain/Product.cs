namespace OnlineShop.Domain;

class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    public string ProductProvider { get; set; }

    public string Description { get; set; }

    public Product(string productName, double price, string productProvider)
    {
        ProductName = productName;
        Price = price;
        ProductProvider = productProvider;
    }
}
