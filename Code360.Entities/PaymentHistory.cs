using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Code360.Entities
{
    public class PaymentHistory
    {
        [Key]
        public int Id { get; set; }
        public Guid StudentId { get; set; }
        [Required]
        public double AmountPaid { get; set; }
        [Required]
        public DateTime DatePaid { get; set; }
        public confirmationState Confirmation_Status { get; set; }
    }

    public enum confirmationState
    {
        pending = 1,
        awaiting_confirmation,
        confirmed
    }
}
