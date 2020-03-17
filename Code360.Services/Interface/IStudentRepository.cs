using Code360.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code360.Services.Interface
{
  public  interface IStudentRepository
    {
        Student AddStudent(Student student);
    }
}
