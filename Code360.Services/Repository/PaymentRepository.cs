﻿using Code360.Data;
using Code360.Entities;
using Code360.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Code360.Services.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly Code360DBContext _db;

        public PaymentRepository(Code360DBContext code360DBContext)
        {
            _db = code360DBContext;
        }
        public async Task<PaymentHistory> AddPayment(PaymentHistory payment)
        {
            _db.paymentHistories.Add(payment);
            await _db.SaveChangesAsync();
            return payment;
        }

        public Payment ViewBalance(int? id)
        {
            return _db.payments.Find(id);
        }

        public IEnumerable<PaymentHistory> ViewHistory()
        {
            return _db.paymentHistories;
        }
    }
}
