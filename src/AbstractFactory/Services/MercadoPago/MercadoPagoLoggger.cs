using AbstractFactory.Interfaces;

namespace AbstractFactory.Services.MercadoPago;

internal class MercadoPagoLoggger : IPaymentLogger
{
    public void LogPayment(string message)
    {
        Console.WriteLine($"[MercadoPagoLog] {DateTime.Now}: {message}");
    }
}
