using System;
using System.Collections.Generic;
using System.Text;

namespace Code360.Services.Interface
{
    public interface IPaymentRepository
    {
        Payment AddPayment(Payment payment);
    }
}
