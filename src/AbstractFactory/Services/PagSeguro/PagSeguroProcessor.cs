using AbstractFactory.Interfaces;

namespace AbstractFactory.Services.PagSeguro;

internal class PagSeguroProcessor : IPaymentProcessor
{
    public string ProcessPayment(decimal amount, string cardNumber)
    {
        Console.WriteLine($"PagSeguro: Processando R$ {amount}...");
        return $"PAGSEG-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}
