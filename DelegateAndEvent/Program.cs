// See https://aka.ms/new-console-template for more information
using DelegateAndEvent.Senaryo1;
using DelegateAndEvent.Senaryo2;



#region Senaryo 2 Oyun Geliştirme 
var character = new Character("A", 100);

character.HealthDecreased += Character_HealthDecreased;

character.TakeDamage(50);
character.TakeDamage(40);
character.TakeDamage(5);


void Character_HealthDecreased(int currentHealth)
{
	Console.WriteLine($"Karakterin canı kritik seviyede!\nKarakter Canı: {currentHealth}");
}
#endregion


#region Senaryo1 E Ticaret
// Sipariş oluşturma
Order order = new Order
{
    OrderId = 1,
    CustomerName = "John Doe",
    OrderDate = DateTime.Now,
    Items = new List<string> { "Laptop", "Mouse", "Keyboard" }
};

// Departmanlar
CustomerService customerService = new CustomerService();
WarehouseManagement warehouseManagement = new WarehouseManagement();
Accounting accounting = new Accounting();

// Event Abonelikleri
order.OrderCompleted += customerService.OnOrderCompleted;
order.OrderCompleted += warehouseManagement.OnOrderCompleted;
order.OrderCompleted += accounting.OnOrderCompleted;

// Siparişi Tamamlama
order.CompleteOrder();
#endregion

#region Senaryo 3 Finansal Uygulama
     
#endregion
