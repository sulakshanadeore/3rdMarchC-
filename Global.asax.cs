﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace StateMgtDemo
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["visitors"] = 0;
        }

        void Session_Start(object sender, EventArgs e)
        {
            int cnt=Convert.ToInt32(Application["visitors"]);
            cnt += 1;
            Application["visitors"] = cnt;

        }
        void Session_End(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            
            

        }

    }
}