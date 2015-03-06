using System;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ViewResult Index()
        {
            ViewBag.Message = TempData["Message"];
            ViewBag.Date = TempData["Date"];
            return View();
        }



        public RedirectToRouteResult Redirect()
        {
            TempData["Message"] = "Hello";
            TempData["Date"] = DateTime.Now;

            return RedirectToAction("Index");
        }

        public HttpStatusCodeResult StatusCode()
        {
            return HttpNotFound();
        }
    }
}