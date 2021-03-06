﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace menagerplików
    
{
    public class Global : System.Web.HttpApplication
    {
        
        
        void Application_Start(object sender, EventArgs e)
        {
            Application["LiczbaUzytkownikow "] = 0;
        }

        void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["LiczbaUzytkownikow"] = (int)Application["LiczbaUzytkownikow"] + 1;
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["LiczbaUzytkownikow"] = (int)Application["LiczbaUzytkownikow"] - 1;
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}