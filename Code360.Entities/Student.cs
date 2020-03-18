using Code360.Web.Areas.Student.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Code360.Entities
{
  public  class Student
    {
        
        public Guid StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherNames { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public StateOfOrigin StateOfOrigin { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string NextOfKinName { get; set; }
        public int NextOfKinPhoneNumber { get; set; }
        public MaritalStatus NextOfKinMaritalStatus { get; set; }
        public bool Status { get; set; }
        public string Password { get; set; }
        public nationality Nationality { get; set; }
    }
}
