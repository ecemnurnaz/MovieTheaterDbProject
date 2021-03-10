using NetCoreMovieTheater.Models;
using NetCoreMovieTheater.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NetCoreMovieTheater.Filters
{
    //public class AcFilter : FilterAttribute, IActionFilter
    //{
    //    public void OnActionExecuted(ActionExecutedContext filterContext)
    //    {
    //        Log log = new Log();
    //        log.ActionName = filterContext.ActionDescriptor.ActionName;
    //        log.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
    //        log.LogDate = DateTime.Now;
    //        log.UserName = "admin";
    //        log.Description = log.UserName + " " + "isteği tamamladı";
    //        .Logs.Add(log);
    //        db.SaveChanges();
    //    }

    //    public void OnActionExecuting(ActionExecutingContext filterContext)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
