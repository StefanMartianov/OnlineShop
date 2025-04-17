using OnlineShop.Domain;

namespace OnlineShop.Services;

class ProductService
{
    public List<Product> Products { get; set; }

    public ProductService()
    {
        Products = new List<Product>();

        var appleWatch = new Product("Watch", 100.50, "Apple");
        Products.Add(appleWatch);

        var appleIPhone = new Product("IPhone", 2000, "Apple");
        Products.Add(appleIPhone);
    }

    public Product GetProduct() 
    {
        var productText = Console.ReadLine();
        var productNumber = 0;
        if (int.TryParse(productText, out productNumber))
        {
            if (productNumber > 0 &&
                Products.Count >= productNumber)
            {
                var product = Products.ElementAt(productNumber - 1);

                return product;
            }
        }

        return null;
    }

    public void AddProduct()
    {
        Console.WriteLine("Enter to add product: ");
        var item = Console.ReadLine();
        Console.WriteLine("Enter the price: ");
        var priceString = Console.ReadLine();
        var price = double.Parse(priceString);
        Console.WriteLine("choose your provider: ");
        var provider = Console.ReadLine();

        var product = new Product(item, price, provider);
        Products.Add(product);
    }

    public void EditProduct()
    {
        ShowProductList();

        Console.WriteLine("Choose your product to edit: ");
        var edit = Console.ReadLine();

        var productEdit = 0;
        if (int.TryParse(edit, out productEdit) &&
            productEdit > 0 &&
            Products.Count >= productEdit)
        {
            var product = Products.ElementAt(productEdit - 1);

            Console.WriteLine("Enter a new product name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter a new product price: ");
            var priceString = Console.ReadLine();
            var price = double.Parse(priceString);

            product.ProductName = name;
            product.Price = price;

            Console.WriteLine($"Your edited product is {name}, and the price edited is {price}");
        }

        //if (int.TryParse(edit, out productEdit))
        //{
        //    for (int i = 0; i < Products.Count; i++)
        //    {
        //        var product = Products.ElementAt(i);

        //        if (i == productEdit - 1)
        //        {
        //            Products.ElementAt(i);
        //            break;
        //        }

        //    }
        //}
    }

    public void DeleteProduct()
    {
        ShowProductList();
        
        Console.WriteLine("Enter to delete product: ");
        var delete = Console.ReadLine();

        var productNumber = 0;
        if (int.TryParse(delete, out productNumber))
        {
            if (productNumber > 0 &&
                Products.Count >= productNumber)
            {
                Products.RemoveAt(productNumber - 1);
            }
        }

        //if (int.TryParse(delete, out productNumber) &&
        //    productNumber > 0 &&
        //    Products.Count >= productNumber)
        //{
        //    Products.RemoveAt(productNumber - 1);
        //}

        //for (int i = 0; i < Products.Count; i++)
        //{
        //    var product = Products.ElementAt(i);

        //    if (i == productNumber - 1)
        //    {
        //        Products.RemoveAt(i);
        //        break;
        //    }
        //}
    }

    public void ShowProductList()
    {
        for(int i = 0; i < Products.Count; i++)
        {
            var product = Products.ElementAt(i);

            Console.WriteLine($"{i+1}. {product.ProductName}. {product.Price:C2}");
        }
    }
}