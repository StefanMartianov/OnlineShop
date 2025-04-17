using OnlineShop.Services;

namespace OnlineShop.Menus;

class MenuForProducts
{
    public static void ShowProductsMenu(ProductService productService)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Enter 1 to add new product: ");
            Console.WriteLine("Enter 2 to delete the product: ");
            Console.WriteLine("Enter 3 to edit product: ");
            Console.WriteLine("Enter 4 show product list: ");
            Console.WriteLine("Enter 5 to exit: ");

            var input = Console.ReadLine();

            if (input == "1") 
            {
                productService.AddProduct();
            }
            else if (input == "2")
            {
                productService.DeleteProduct();
            }
            else if (input == "3")
            {
                productService.EditProduct();
            }
            else if (input == "4")
            {
                productService.ShowProductList();

                Console.WriteLine("press any key to continue..");
                Console.ReadKey();
            }
            else if (input == "5")
            {
                break; //MainMenu;
            }
        }
    }
}

