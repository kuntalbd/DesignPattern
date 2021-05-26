namespace StrategyPattern
{
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