using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nitrogen.AzureCore.App_Start.Handler
{
    /// <summary>
    /// 
    /// </summary>
    public class HandlerErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }


        private void WriteLog(ExceptionContext context)
        { 
             
        }
    }
}