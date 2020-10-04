using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace JQuery_MVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            int id = 45;
            ViewBag.Message = id;
            return PartialView();
        }

        public ActionResult Index2(int id)
        {
            ViewBag.Message = id;
            return PartialView() ;
        }
        public ActionResult Index3(string id)
        {
            ViewBag.Message = id;
            return PartialView();
        }
    }
}