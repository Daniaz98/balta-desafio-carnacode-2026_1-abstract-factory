using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Services.Stripe;

internal class StripeFactory : IPaymentFactory
{
    public IPaymentLogger CreatePaymentLogger()
    {
        return new StripeLogger();
    }

    public IPaymentProcessor CreatePaymentProcessor()
    {
        return new StripeProcessor();
    }

    public IPaymentValidator CreatePaymentValidator()
    {
        return new StripeValidator();
    }
}
