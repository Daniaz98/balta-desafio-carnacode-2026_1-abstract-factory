namespace AbstractFactory.Interfaces;

public interface IPaymentProcessor
{
    string ProcessPayment(decimal amount, string cardNumber);
}
