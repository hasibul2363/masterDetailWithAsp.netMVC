﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MasterDetail.Models;

namespace MasterDetail
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {


            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            //System.Data.Entity.Database.DbDatabase.SetInitializer(new System.Data.Entity.Database.DropCreateDatabaseIfModelChanges<MasterDetailContext>());
            

            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }


        //public class MasterDetailDBInitializer : System.Data.Entity.Database.DropCreateDatabaseIfModelChanges<MasterDetailContext> 
        //{
        //    protected override void Seed(MasterDetailContext context)
        //    {
        //        base.Seed(context);
        //    }
        //}
    }
}