using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoAgile.Data;

namespace GoAgile.Services
{
    public interface IRepository
    {
        IEnumerable<Project> GetProjects();
        IEnumerable<ProjectRelease> GetProjectReleasebyProject(int projectId);
        ProjectRelease GetProjectReleasebyId(int projectId, int releaseId);
        Project GetProjectbyId(int projectId);
        void AddProject(Project project);
        void DeleteProject(Project project);
        IEnumerable<Project> GetProjectswithRelease();

    }
}
