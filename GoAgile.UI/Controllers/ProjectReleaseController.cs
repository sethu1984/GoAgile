using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GoAgile.Data;
using GoAgile.UI.Models;
using GoAgile.Services;

namespace GoAgile.UI.Controllers
{
    public class ProjectReleaseController : ApiController
    {
        IRepository repo = null;
        public ProjectReleaseController(IRepository repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public IEnumerable<ProjectReleaseModel> GetProjectReleases(int projectId)
        {
            return from x in repo.GetProjectReleasebyProject(projectId).ToList()
                   select ModelFactory.CreateProjectReleaseModel(x);
        }
        [HttpGet]
        public ProjectReleaseModel GetProjectReleases(int projectId, int id)
        {
            return ModelFactory.CreateProjectReleaseModel(repo.GetProjectReleasebyId(projectId, id));            
        }
    }
}
