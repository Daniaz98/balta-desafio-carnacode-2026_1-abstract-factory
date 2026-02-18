using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Services;

public class PaymentService(IPaymentFactory paymentFactory)
{
    private readonly IPaymentFactory _paymentFactory = paymentFactory;

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        var paymentProcessor = _paymentFactory.CreatePaymentProcessor();
        var validator = _paymentFactory.CreatePaymentValidator();
        var logger = _paymentFactory.CreatePaymentLogger();

        if (!validator.ValidatePayment(cardNumber))
        {
            logger.LogPayment("Cartão inválido");
            return;
        }

        var processor = paymentProcessor.ProcessPayment(amount, cardNumber);
        logger.LogPayment($"Transação processada: {processor}");
    }
}
