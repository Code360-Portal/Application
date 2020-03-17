using Code360.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code360.Services.Interface
{
    public interface IPaymentRepository
    {
        PaymentHistory AddPayment(PaymentHistory payment);
        IEnumerable<PaymentHistory> ViewHistory();
        Payment ViewBalance();
    }
}
