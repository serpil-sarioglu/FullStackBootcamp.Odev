using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"{amount} TL kredi kartı ile ödeme işlemi gerçekleşiyor");
        }
    }

    public class CashPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"{amount} TL nakit ödeme işlemi gerçekleşiyor");
        }
    }
    public class MobilePaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"{amount} TL mobil ödeme işlemi gerçekleşiyor");
        }
    }

    public class PaymentService(IPaymentProcessor paymentProcessor)
    {
        public void ProcessPayment(decimal amount)
        {
            paymentProcessor.ProcessPayment(amount);
        }
    }
}
