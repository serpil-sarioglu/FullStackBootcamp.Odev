namespace SOLID.ISP;
public interface IUser
{
    void Login();
    void Logout();
}

public interface IAdminUser : IUser
{
    void AccessLevel();
}

class AdminUser : IAdminUser
{
    public void AccessLevel()
    {
        Console.WriteLine("Admin kullanıcının erişim seviyesi: Yüksek");
    }
    public void Login()
    {
        Console.WriteLine("Admin Login");
    }
    public void Logout()
    {
        Console.WriteLine("Admin Logout");
    }
}


class RegularUser : IUser
{
    public void Login()
    {
        Console.WriteLine("Kullanıcı Login");
    }
    public void Logout()
    {
        Console.WriteLine("Kullanıcı Logout");
    }
}

class AUser(IUser user)
{
    public void Login()
    {
        user.Login();
    }
    public void Logout()
    {
        user.Logout();
    }
}


