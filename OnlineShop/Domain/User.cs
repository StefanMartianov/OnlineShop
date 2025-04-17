namespace OnlineShop.Domain;

public class User
{
    public string Login { get; set; }
    public string Password { get; set; }

    public string UserName { get; set; }
    public string UserSurname { get; set; }

    public User(string login, string password)
    {
        Login = login;
        Password = password;
    }
}


