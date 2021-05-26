using System;

namespace StrategyPattern
{
    public class CashPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Paid " + amount + " by cash");
        }
    }
}