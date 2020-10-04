using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JQuery_MVC.Models;

namespace JQuery_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult addName(string nameData)
        {
            List<clsUser> detail = JsonConvert.DeserializeObject<List<clsUser>>(nameData);
            return Json(new { msg = "Successfully added "});
        }
    }
}