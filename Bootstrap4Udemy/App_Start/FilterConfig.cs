﻿using System.Web;
using System.Web.Mvc;

namespace Bootstrap4Udemy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
