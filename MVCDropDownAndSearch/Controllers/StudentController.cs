using MVCDropDownAndSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDropDownAndSearch.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateStudent()
        {
            List<SelectListItem> department = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text="CS",
                    Value="1"

                },
                new SelectListItem
                {
                    Text="EEE",
                    Value="2"

                }

            };
            ViewBag.Department = department;
            
            return View();
        }
        [HttpPost]
        public ActionResult CreateStudent(Student st)
        {
            
            StudentContext sc = new StudentContext();
            sc.Students.Add(st);
            sc.SaveChanges();
            return View();

        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Details(string name)
        {
            StudentContext sc = new StudentContext();
            var result = sc.Students.Where(c => c.name == name).FirstOrDefault();
            return PartialView(result);
        }

        




    }
}