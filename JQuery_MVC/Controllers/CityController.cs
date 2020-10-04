using JQuery_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace JQuery_MVC.Controllers
{
    public class CityController : Controller
    {
        TestDbEntities db;
        public CityController()
        {
            db = new TestDbEntities();
        }

        // GET: City
        [HttpGet]
        public ActionResult Index()
        {
            var results = (from row in db.tblCities select row).ToList();
            return View(results);
        }
        [HttpGet]
        public ActionResult AddCity()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCity(tblCity c)
        {
            db.tblCities.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCity(int? id)
        {
            var result = db.tblCities.Single(city => city.CityId == id);
            return View(result);
        }
        [HttpPut]
        public ActionResult UpdateCity(tblCity c)
        {
            tblCity result = db.tblCities.Single(city => city.CityId == c.CityId);
            result.CityName = c.CityName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteCity(int? id)
        {
            var result = db.tblCities.Single(city => city.CityId == id);
            return View(result);
        }
        [HttpDelete]
        public ActionResult DeleteCity(int id)
        {
            var result = db.tblCities.Single(city => city.CityId == id);
            db.tblCities.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
   
}