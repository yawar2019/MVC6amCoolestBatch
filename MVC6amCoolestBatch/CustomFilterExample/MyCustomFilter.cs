using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6amCoolestBatch.CustomFilterExample
{
    public class MyCustomFilter :ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //(filterContext.Result as ViewResult).ViewBag.Player = "Kohli";
            ((MVC6amCoolestBatch.Models.EmployeeModel)((System.Web.Mvc.ViewResultBase)filterContext.Result).Model).EmpName = "Rakshita";
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
    }
}