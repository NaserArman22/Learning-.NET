using formValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace formValidation.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        //Model binding]
        //responsible for displaying the form to create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Student());//By passing a new instance of the Student class (new Student()) to the view, it ensures that the form is bound to a Student model.
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(s);
        }

    }
}