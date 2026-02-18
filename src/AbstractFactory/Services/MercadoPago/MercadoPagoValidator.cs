using AbstractFactory.Interfaces;

namespace AbstractFactory.Services.MercadoPago;

internal class MercadoPagoValidator : IPaymentValidator
{
    public bool ValidatePayment(string cardNumber)
    {
        Console.WriteLine("MercadoPago: Validando cartão...");
        return cardNumber.Length == 16 && cardNumber.StartsWith("5");
    }
}