﻿using System.Web;
using System.Web.Mvc;

namespace mvcbs_music
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}