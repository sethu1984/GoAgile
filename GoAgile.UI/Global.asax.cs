using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using GoAgile.UI.Controllers;
using GoAgile.UI.Helper;
using GoAgile.Services;

namespace GoAgile.UI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ConfigureApi(GlobalConfiguration.Configuration);
        }

        void ConfigureApi(HttpConfiguration httpConfiguration)
        {
            var unity = new UnityContainer();

            unity.RegisterType<IRepository, Repository>(new HierarchicalLifetimeManager());
            unity.RegisterType<ProjectsController>();

            httpConfiguration.DependencyResolver = new IoCContainer(unity);
        }
    }
}