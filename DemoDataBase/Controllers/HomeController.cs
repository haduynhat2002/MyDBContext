using DemoDataBase.Data;
using DemoDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoDataBase.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext myDBContext = new MyDBContext();
        public ActionResult Index()
        {
            var result = myDBContext.Students.ToList();
            return View(result);
        }

        public ActionResult Create()
        {          

            return View();
        }
        [HttpPost]
        public ActionResult Store(string name)
        {
            var student = new Student()
            {
                Name = name
            };
            myDBContext.Students.Add(student);
            myDBContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}