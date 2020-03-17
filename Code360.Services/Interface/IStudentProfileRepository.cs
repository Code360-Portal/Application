using System;
using System.Collections.Generic;
using System.Text;

namespace Code360.Services.Interface
{
    public interface IStudentProfileRepository
    {
        StudentProfile Add(StudentProfile studentProfile);
        StudentProfile Update(StudentProfile studentProfileChanges);
        StudentProfile Delete(int id);
        StudentProfile GetStudentProfile(int id);
    }
}
