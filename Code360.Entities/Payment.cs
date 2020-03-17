using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Code360.Entities
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public Guid studentID { get; set; }

        [Required]
        public double Total { get; set; }
    }
}
