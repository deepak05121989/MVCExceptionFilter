using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExceptionFilter.ExceptionFilter
{
    public class CustomeExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled && filterContext.Exception is DivideByZeroException)
            {
                filterContext.Result = new RedirectResult("~/Content/ErrorPage.html");
                filterContext.ExceptionHandled = true;
            }
        }
    }
}