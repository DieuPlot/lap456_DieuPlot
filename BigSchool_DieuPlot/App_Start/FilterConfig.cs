﻿using System.Web;
using System.Web.Mvc;

namespace BigSchool_DieuPlot
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
