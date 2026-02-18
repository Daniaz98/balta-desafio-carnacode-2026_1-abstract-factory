using AbstractFactory.Interfaces;

namespace AbstractFactory.Services.MercadoPago;

internal class MercadoPagoFactory : IPaymentFactory
{
    public IPaymentLogger CreatePaymentLogger()
    {
        return new MercadoPagoLoggger();
    }

    public IPaymentProcessor CreatePaymentProcessor()
    {
        return new MercadoPagoProcessor();
    }

    public IPaymentValidator CreatePaymentValidator()
    {
        return new MercadoPagoValidator();
    }
}
