
namespace OnlineShop;

class UserService
{
    public List<User> Users { get; set; }

    public User CurrentUser { get; set; }

    public bool LoginIn()
    {
        Console.WriteLine("Enter your login");
        var login = Console.ReadLine();

        Console.WriteLine("Enter your password");
        var password = Console.ReadLine();

        var success = false;

        for (int i = 0; i < Users.Count; i++)
        {
            var user = Users.ElementAt(i);

            if (user.Login == login && user.Password == password)
            {
                CurrentUser = user;
                success = true;
                break;
            }
        }

        return success;
    }

    public void RegisterUser()
    {
        Console.WriteLine("Enter the login for regitration: ");
        var login = Console.ReadLine();
        Console.WriteLine("Enter the password for the registration: ");
        var password = Console.ReadLine();
        Console.WriteLine("You was be regitratet");

        var user = new User(login, password);
        Users.Add(user);
    }

    public void ShowChangesUsersData()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Enter 1 to see - Change your Firstname: ");
            Console.WriteLine("Enter 2 to see - Change your Lastname: ");
            Console.WriteLine("Enter 3 to see - Change your Password: ");
            Console.WriteLine("Enter 4 to exit: ");

            var input = Console.ReadLine();

            if (input == "1")
            {
                CurrentUser.UserName = Console.ReadLine();
            }
            else if (input == "2")
            {
                CurrentUser.UserSurname = Console.ReadLine();
            }
            else if (input == "3")
            {
                CurrentUser.Password = Console.ReadLine();
            }
            else if (input == "4")
            {
                break; //MainMenu;
            }
        }
    }
}
