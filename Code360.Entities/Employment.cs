using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Code360.Entities
{
    public class Employment
    {
        [Key]
        public int Id { get; set; }
        public Guid studentId { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }
}
