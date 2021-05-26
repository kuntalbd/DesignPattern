using System;

namespace StrategyPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            PaymentContext ctx = new PaymentContext();
            Console.WriteLine("Enter Amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter PayType: ");
            string payType = Console.ReadLine();

            if (payType == "card")
            {
                ctx.SetPayType(new CardPayment());
            }
            else if (payType == "cash")
            {
                ctx.SetPayType(new CashPayment());
            }
            ctx.Pay(amount);

        }
    }
    public interface IPayment
    {
        void Pay(decimal amount);
    }

    public class CardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Paid " + amount + " by card");
        }
    }
    public class CashPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Paid " + amount + " by cash");
        }
    }

    public class PaymentContext
    {
        private IPayment _payment;

        public void SetPayType(IPayment payment)
        {
            _payment = payment;
        }
        public void Pay(decimal amount)
        {
            _payment.Pay(amount);
        }
    }
}
