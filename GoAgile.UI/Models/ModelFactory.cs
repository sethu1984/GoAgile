using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoAgile.Data;

namespace GoAgile.UI.Models
{
    public static class ModelFactory
    {
        public static ProjectModel CreateProjectModel(Project project)
        {
            return new ProjectModel
            {
                ProjectID = project.ProjectID,
                Description = project.Description,
                Name = project.Name,
                StartDate = project.StartDate,
                EndDate = project.EndDate                
            };
        }

        public static Project CreateProject(ProjectModel projectModel)
        {
            return new Project
            {
                ProjectID = projectModel.ProjectID,
                Description = projectModel.Description,
                Name = projectModel.Name,
                StartDate = projectModel.StartDate,
                EndDate = projectModel.EndDate
            };
        }

        public static ProjectReleaseModel CreateProjectReleaseModel(ProjectRelease project)
        {
            return new ProjectReleaseModel
            {
                ProjectReleaseID = project.ProjectReleaseID,
                ProjectID = project.ProjectID,
                Description = project.Description,
                Name = project.Name,
                StartDate = project.StartDate,
                EndDate = project.EndDate
            };
        }

        public static ProjectRelease CreateProjectReleaseModel(ProjectReleaseModel projectReleaseModel)
        {
            return new ProjectRelease
            {
                ProjectReleaseID = projectReleaseModel.ProjectReleaseID,
                ProjectID = projectReleaseModel.ProjectID,
                Description = projectReleaseModel.Description,
                Name = projectReleaseModel.Name,
                StartDate = projectReleaseModel.StartDate,
                EndDate = projectReleaseModel.EndDate
            };
        }
    }
}