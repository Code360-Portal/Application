using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code360.Web.Areas.Student.ViewModels
{
    public class EmploymentViewModel
    {
        public int Id { get; set; }
        public Guid studentId { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Contact Person")]
        public String ContactPerson { get; set; }

        [Required]
        public double Salary { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
