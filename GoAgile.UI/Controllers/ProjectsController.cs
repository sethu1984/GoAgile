using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GoAgile.UI.Models;
using GoAgile.Data;
using GoAgile.Services;

namespace GoAgile.UI.Controllers
{
    public class ProjectsController : ApiController
    {
        IRepository repo = null;
        public ProjectsController(IRepository repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public IEnumerable<ProjectModel> GetProjects()
        {
            return repo.GetProjects().ToList().Select(p => ModelFactory.CreateProjectModel(p));
        }
        [HttpGet]
        public ProjectModel GetProject(int id)
        {
            return ModelFactory.CreateProjectModel(repo.GetProjectbyId(id));
        }
        [HttpDelete]
        public HttpStatusCode DeleteProject(int id)
        {
            repo.DeleteProject(repo.GetProjectbyId(id));
            return HttpStatusCode.OK;
        }
        [HttpPost]
        public HttpStatusCode AddProject(ProjectModel projModel)
        {
            repo.AddProject(ModelFactory.CreateProject(projModel));
            return HttpStatusCode.OK;
        }
        [HttpPut]
        public HttpStatusCode UpdateProject(ProjectModel projModel)
        {
            Project p = repo.GetProjectbyId(projModel.ProjectID);
            if (p == null)
                return HttpStatusCode.BadRequest;
            else
            {
                p = ModelFactory.CreateProject(projModel);
                return HttpStatusCode.OK;
            }
        }
    }
}
