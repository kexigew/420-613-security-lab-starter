using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter.Controllers
{
    public class InventoryController : Controller
    {
		protected override void OnActionExecuted(ActionExecutedContext filterContext) {
            filterContext.ExceptionHandled = true;

            //Log the error!!
            Console.WriteLine(filterContext.Exception);
            //Redirect or return a view, but not both.
            filterContext.Result = RedirectToAction("ServerError", "Error");
        }

		// GET: Inventory
		public ActionResult Index()
        {
            return View();
        }
    }
}