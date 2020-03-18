using Code360.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Code360.Services.Interface
{
    public interface IPaymentRepository
    {
        Task<PaymentHistory> AddPayment(PaymentHistory payment);
        IEnumerable<PaymentHistory> GetAllPayment();
        Payment GetProgramCost(int? id);
    }
}