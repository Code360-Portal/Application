using Code360.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code360.Services.Interface
{
    public interface IEmploymentRepository
    {
        Employment GetEmployment(int id);
        Employment AddEmployment(Employment employment);
        Employment UpdateEmployment(Employment employmentChanges);
        IEnumerable<Employment> GetAllEmployment();
    }
}
