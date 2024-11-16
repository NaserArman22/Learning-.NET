using form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace form.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Create()
        {
            return View();
        }
        
       //HttpRequestBase
        public ActionResult getForm()
        {
            Student s = new Student();
            s.Name = Request["Name"];
            s.Id = Request["Id"];
            s.CGPA = Request["CGPA"];
            return View(s);
        }
        //variable name mapping\
        //[HttpPost]
        /*public ActionResult getForm(string Name, string Id, string CGPA)
        {
            Student s=new Student();
            s.Name = Name;
            s.Id = Id;
            s.CGPA = CGPA;
            return View(s);
        }*/
        /*FormCollection
        [HttpPost]
        public ActionResult getForm(FormCollection form)
        {
            Student s= new Student();
            s.Name = form["Name"];
            s.Id=form["Id"];
            s.CGPA = form["CGPA"];
            return View();
        }*/
    }
    
}