using SOLID.SRP;
using SOLID.OCP;
using SOLID.LSP;
using SOLID.ISP;
using SOLID.DIP;

namespace SOLID;

internal class Program
{
    static void Main(string[] args)
    {
        #region Single Responsibility Principle
        //Bu prensip, bir sınıfın yalnızca tek bir değişiklik nedeni olması gerektiği anlamına gelir. 
        //Bir sınıf, başka bir sınıfın değişikliklerinden etkilenmemelidir.

        UserRepository userRepository = new UserRepository();
        EmailService emailService = new EmailService();
        UserRegistration userRegistration = new UserRegistration(userRepository, emailService);

        userRegistration.RegisterUser("Ali Veli", "ali.veli@hotmail.com");

        List<User> users = userRepository.GetAllUsers();
        foreach (var user in users)
        {
            Console.WriteLine($"Kullanıcı: {user.Name}, Email: {user.Email}");
        }
        #endregion
        #region Open/Closed Principle 
        //Bu prensip, yeni işlevsellik eklerken mevcut kodun değiştirilmemesi, bunun yerine genişletilmesi gerektiğini savunur.

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle(5));
        shapes.Add(new Rectangle(3, 6));         

        AreaCalculator areaCalculator = new AreaCalculator();

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Şekil: {shape.GetType().Name}, Alan:{areaCalculator.CalculateArea(shape)}");
        }

        #endregion

        #region Liskov Substitution Principle 
        //Bu prensip, bir temel sınıfın yer aldığı herhangi bir yerde, onun alt sınıfının da kullanılabilmesi gerektiğini belirtir. Yani, bir sınıfın alt sınıfları, türedikleri sınıfın yerine kullanılabilmeli ve programın doğru çalışmasını sürdürmelidir.
        //LSP'ye göre, bir alt sınıf, temel sınıfın tüm davranışlarını miras almalı ve temel sınıfın beklediği sözleşmelere uymalıdır. Eğer alt sınıf, temel sınıfın beklediği davranışları bozuyorsa, bu durumda Liskov Yerdeğiştirme Prensibi ihlal edilmiş olur.


        //Bird baseBird;        

        //baseBird = new Ostrich();        

        //baseBird.Eat();
        //baseBird.Move();

        //if (baseBird is IFlyable bird)
        //{
        //   bird.Fly();
        //}

        Sparrow sparrow = new Sparrow();
        Ostrich ostrich = new Ostrich();
        BirdService birdService = new BirdService();

        sparrow.Eat();
        sparrow.Move();
     
        ostrich.Eat();
        ostrich.Move();

        birdService.MakeBirdFly(sparrow);
        //birdService.MakeBirdFly(ostrich);

        #endregion

        #region Interface Segregation Principle 
        //Bu prensip, genellikle bir arayüzün birçok farklı işlevi kapsaması yerine, daha küçük ve özgün arayüzlerin oluşturulması gerektiğini belirtir.
        //Böylece, bir sınıf yalnızca kendi ihtiyaç duyduğu arayüzleri uygular ve gereksiz metotları içermez.
        
        var admin = new AdminUser();
        admin.Login();
        admin.Logout();
        admin.AccessLevel();

        var aUser = new AUser(new RegularUser());
        aUser.Login();

        #endregion

        #region Dependency Inversion Principle 
        //Yüksek seviye modüller, düşük seviye modüllere bağlı olmamalıdır. Her ikisi de soyutlamalara (abstraction) bağlı olmalıdır.

        var crediCartPaymentService = new PaymentService(new CreditCardPaymentProcessor());
        crediCartPaymentService.ProcessPayment(200.00m);

        #endregion
    }
}

