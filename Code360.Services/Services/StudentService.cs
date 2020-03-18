using Code360.Data;
using Code360.Entities;
using Code360.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code360.Services.Services
{
    class StudentService
    {
        private readonly IPaymentRepository _paymentRepo;

        public StudentService(IPaymentRepository paymentRepository)
        {
            _paymentRepo = paymentRepository;
        }
        public double GetBalance()
        {
            //first get the sum of all payments for the particular student
            var pay = _paymentRepo.GetAllPayment();
                return 8.8;
        }
    }
}
