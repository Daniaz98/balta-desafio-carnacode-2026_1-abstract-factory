using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Services.PagSeguro;

internal class PagSeguroFactory : IPaymentFactory
{
    public IPaymentLogger CreatePaymentLogger()
    {
        return new PagSeguroLogger();
    }

    public IPaymentProcessor CreatePaymentProcessor()
    {
        return new PagSeguroProcessor();
    }

    public IPaymentValidator CreatePaymentValidator()
    {
        return new PagSeguroValidator();
    }
}
