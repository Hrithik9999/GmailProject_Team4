﻿using System.Web;
using System.Web.Mvc;

namespace GmailProject_Team4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
