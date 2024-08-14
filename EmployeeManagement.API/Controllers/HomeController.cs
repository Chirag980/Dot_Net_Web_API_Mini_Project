using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.API.Controllers
{
    public class HomeController : Controller
    {
        //loginUser db = new loginUser();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        //public JsonResult CheckUserNameAvailability(string userdata)
        //{
        //    System.Threading.Thread.Sleep(200);
        //    var SearchData = db.loginUser.Where(x => x.userName == userdata).SingleOrDefault();
        //    if (SearchData != null)
        //    {
        //        return Json(1);
        //    }
        //    else
        //    {
        //        return Json(0);
        //    }
        //}
    }
}
