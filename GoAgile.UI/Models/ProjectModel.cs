using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoAgile.UI.Models
{
    public class ProjectModel
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual IEnumerable<ProjectReleaseModel> ReleaseModel { get; set; }
    }
    public class ProjectReleaseModel
    {
        public int ProjectReleaseID { get; set; }
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}