using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace GoAgile.UI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
              name: "ProjectRelease",
              routeTemplate: "api/projects/{projectid}/{controller}/{id}",
              defaults: new { id = RouteParameter.Optional }
          );
        }
    }
}
