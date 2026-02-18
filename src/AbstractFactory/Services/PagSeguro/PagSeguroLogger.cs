using AbstractFactory.Interfaces;

namespace AbstractFactory.Services.PagSeguro;

internal class PagSeguroLogger : IPaymentLogger
{
    public void LogPayment(string message)
    {
        Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");
    }
}
