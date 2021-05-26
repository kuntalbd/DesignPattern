using System;

namespace StrategyPattern
{
    public class CardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Paid " + amount + " by card");
        }
    }
}