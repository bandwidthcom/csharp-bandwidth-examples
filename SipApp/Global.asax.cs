﻿using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SipApp.Lib;

namespace SipApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Common.SetupClient();
            Trace.Listeners.Add(new IisTraceListener());
            Trace.Listeners.Add(new ConsoleTraceListener());
        }
    }
}
