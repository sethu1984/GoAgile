using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using GoAgile.Data;

namespace GoAgile.Services
{
    public class Repository : IRepository
    {
        GoAgileContext agileContext = null;
        public Repository()
        {
            agileContext = new GoAgileContext();
        }

        public IEnumerable<Project> GetProjects()
        {
            return agileContext.Projects;
        }

        public IEnumerable<ProjectRelease> GetProjectReleasebyProject(int projectId)
        {
            return agileContext.ProjectReleases.Where(x => x.ProjectID == projectId);
        }

        public ProjectRelease GetProjectReleasebyId(int projectId, int releaseId)
        {
            return GetProjectReleasebyProject(projectId).FirstOrDefault(x => x.ProjectReleaseID == releaseId);
        }

        public Project GetProjectbyId(int projectId)
        {
            return agileContext.Projects.FirstOrDefault(x => x.ProjectID == projectId);
        }

        public void AddProject(Project project)
        {
            agileContext.Projects.AddObject(project);
        }

        public void DeleteProject(Project project)
        {
            agileContext.Projects.DeleteObject(project);
        }

        public IEnumerable<Project> GetProjectswithRelease()
        {
            return agileContext.Projects.Include("ProjectReleases");
        }
    }
}
