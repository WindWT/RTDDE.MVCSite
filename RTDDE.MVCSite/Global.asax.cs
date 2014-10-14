using RTDDE.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace RTDDE.MVCSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);   //API routes should evaluate first
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //修改DAL层连接字符串
            DAL.ConnectionString = "data source=|DataDirectory|RTD.db";
        }
    }
}
