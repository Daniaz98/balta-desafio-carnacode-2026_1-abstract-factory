using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces;

public interface IPaymentFactory
{
    IPaymentProcessor CreatePaymentProcessor();
    IPaymentValidator CreatePaymentValidator();
    IPaymentLogger CreatePaymentLogger();
}
