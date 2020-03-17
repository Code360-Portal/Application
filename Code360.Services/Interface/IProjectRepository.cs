using System;
using System.Collections.Generic;
using System.Text;

namespace Code360.Services.Interface
{
    public interface IProjectRepository
    {
        Project GetProject(int id);
        Project AddProject(Project project);
        Project UpdateProject(Project projectChanges);
        Project DeleteProject(int id);
        IEnumerable<Project> GetAllProject();
    }
}
