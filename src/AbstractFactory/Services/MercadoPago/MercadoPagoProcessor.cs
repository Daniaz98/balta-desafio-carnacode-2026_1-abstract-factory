

using AbstractFactory.Interfaces;

namespace AbstractFactory.Services.MercadoPago;

internal class MercadoPagoProcessor : IPaymentProcessor
{
    public string ProcessPayment(decimal amount, string cardNumber)
    {
        Console.WriteLine($"Mercado Pago: Processando pagamento R$ {amount}");
        return $"MP-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}
