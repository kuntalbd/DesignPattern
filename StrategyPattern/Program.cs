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
}
