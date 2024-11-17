using EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        studentEntities db=new studentEntities();
       [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            //
            db.Students.Add(s);//for inserting tablename.Add(instance name)
            db.SaveChanges();//to exequte any query for modification
            TempData["Msg"] = "Student Created";
            return RedirectToAction("list");


            
        }
        public ActionResult list(Student student)
        {

            var data = db.Students.ToList();

            return View(data);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = db.Students.Find(id);

            
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Student formObj)
        {
            var exobj=db.Students.Find(formObj.id);
            formObj.cgpa = exobj.cgpa;
            exobj.name= formObj.name;
            //db.Entry(exobj).CurrentValues.SetValues(formObj);//another process
            db.SaveChanges();
            TempData["Msg"] = "Student" +formObj.id + "updated";

            return RedirectToAction("List","Student");
        }
        [HttpGet]
        public ActionResult Delete(int Id) {

            var data = db.Students.Find(Id);
            return View(data); 
        
        }
        [HttpPost]
        public ActionResult Delete(Student formObj)
        {
            var exobj = db.Students.Find(formObj.id);
            db.Students.Remove(exobj);
            db.SaveChanges();
            TempData["Msg"] = "Student deleted";
            return RedirectToAction("List", "Student");
        }
        public ActionResult Details()
        {

           return View();
        
        
        }
    
    }
}