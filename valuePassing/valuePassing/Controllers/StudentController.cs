using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using valuePassing.Models;

namespace valuePassing.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Bio()

        {
            Student s1 = new Student()
            {
                name="Naser Arman",
                id="254788",
                cgpa= 3.2

            };
            /*int a = 5;
            int b = 10;
            int c=a+b;
            ViewBag.a = a;
            ViewBag.b=b;
            ViewBag.c = c;
           
            string[] names = new string[3];
            names[0] = "Arman";
            names[1] = "Naser";
            ViewBag.Names=names;*/
            return View(s1);

        }
        public ActionResult Education()
        {
            Education e1 = new Education()
            {
                Title="SSC",
                INS="ISC",
                Result="5.00"
            };
            Education e2 = new Education()
            {
                Title = "HSC",
                INS = "DC",
                Result = "5.00"
            };
            Education e3 = new Education()
            {
                Title = "BSC",
                INS = "AIUB",
                Result = "3.2"
            };
            Education[] edu = new Education[] { e1, e2, e3 };
            ViewBag.Edu = edu;
            
            return View();
        }
        public ActionResult Reference()
        {
            Reference r1 = new Reference()
            {
                name = "Rakib Hossain",
                designation = "Proffesor",
                email = "rakib@gmail.com"
            };
            Reference r2= new Reference()
            {
                name = "Akib Hossain",
                designation = "Proffesor",
                email = "akib@gmail.com"
            };
            Reference r3= new Reference()
            {
                name = " Hossain",
                designation = "Proffesor",
                email = "r@gmail.com"
            };
            Reference[] references=new Reference[] { r1, r2, r3 };
           
            return View(references);
        }
        
        public ActionResult Qualification()
        {
            bool qualification=false;
            //
            if(qualification)
            {
                return View();  
            }
            else
            {
                TempData["Msg"] = "User has no extra qualififcaion.Visit this page instead";
                return RedirectToAction("Education","Student");
            }
        }
    }
}