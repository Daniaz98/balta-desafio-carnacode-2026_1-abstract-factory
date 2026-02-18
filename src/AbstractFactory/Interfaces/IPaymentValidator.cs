namespace AbstractFactory.Interfaces;

public interface IPaymentValidator
{
    bool ValidatePayment(string cardNumber);
}
