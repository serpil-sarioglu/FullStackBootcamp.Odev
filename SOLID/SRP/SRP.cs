using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    // User kullanıcı bilgileri sınıfı
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }

    //User veritabanı işlemlerini yöneten sınıf
    public class UserRepository
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }
    }

    // Kullanıcıya e-posta gönderen sınıf
    public class EmailService
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Email: {email}  Mesaj: {message}");
        }
    }

    // Kullanıcı kaydını yöneten sınıf
    public class UserRegistration
    {
        private readonly UserRepository _userRepository;
        private readonly EmailService _emailService;

        public UserRegistration(UserRepository userRepository, EmailService emailService)
        {
            _userRepository = userRepository;
            _emailService = emailService;
        }

        public void RegisterUser(string name, string email)
        {
            User user = new User(name, email);
            _userRepository.AddUser(user);
            _emailService.SendEmail(email, "Hoşgeldiniz, kaydınız gerçekleşti!");
        }
    }
}
