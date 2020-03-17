using Code360.Web.Areas.Student.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code360.Web.Areas.Student.ViewModels
{
    public class StudentViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; }

        [Display(Name = "Other Name")]
        public string OtherNames { get; set; }

        public Gender Gender { get; set; }

        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "State Of Origin")]
        public StateOfOrigin StateOfOrigin { get; set; }

        public string Address { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; }

        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string NextOfKinName { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string NextOfKinPhoneNumber { get; set; }

        [Display(Name = "Email")]
        public string NextofKinEmail { get; set; }

        [Display(Name = "Marital Status")]
        public MaritalStatus NextOfKinMaritalStatus { get; set; }

        public bool Status { get; set; }

        public string Password { get; set; }

        public nationality Nationality { get; set; }
    }
}
