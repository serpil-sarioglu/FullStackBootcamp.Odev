using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.Senaryo1
{
    // Delegate Tanımlaması
    public delegate void OrderCompletedHandler(string message);

    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public List<string> Items { get; set; }

        // Event Tanımlaması
        public event OrderCompletedHandler OrderCompleted;

        public void CompleteOrder()
        {
            // Event Tetikleme
            OrderCompleted?.Invoke($"Order Completed: {OrderId} for {CustomerName} on {OrderDate}");
        }
    }
    public class CustomerService
    {
        public void OnOrderCompleted(string message)
        {
            Console.WriteLine($"Customer Service Notification: {message}");
            // Müşteriye e-posta gönderme kodu burada olabilir.
        }
    }
    public class WarehouseManagement
    {
        public void OnOrderCompleted(string message)
        {
            Console.WriteLine($"Warehouse Management Notification: {message}");
            // Stok güncelleme kodu burada olabilir.
        }
    }
    public class Accounting
    {
        public void OnOrderCompleted(string message)
        {
            Console.WriteLine($"Accounting Notification: {message}");
            // Fatura oluşturma kodu burada olabilir.
        }
    }

}
