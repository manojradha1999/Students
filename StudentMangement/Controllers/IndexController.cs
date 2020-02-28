using System;
using System.Collections.Generic;
using System.Linq;
using Students.Repositery;
using Students.Data;
using System.Web;

using System.Web.Mvc;

namespace StudentMangement.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index

        Repository repository;
        public IndexController()
        {
            repository = new Repository();
        }
        public ActionResult Index()
        {
            IEnumerable<Student> students = repository.GetAllStudents();
            return View(students);
        }
        //    public ActionResult Create()
        //    {
        //        return View();
        //    }
        //    [HttpPost]
        //    public ActionResult Create(Student student)
        //    {
        //        repository.AddStudent(student);
        //        TempData["Message"] = "Student Added Successfully!";
        //        return RedirectToAction("Index");
        //    }
        //    public ActionResult Delete(string id)
        //    {
        //        repository.DeleteStudent(id);
        //        TempData["Message"] = "Student Deleted Successfully!";
        //        return RedirectToAction("Index");
        //    }
        //    public ActionResult Edit(string id)
        //    {
        //        Student student = repository.GetStudent(id);
        //        return View(student);
        //    }
        //    [HttpPost]
        //    public ActionResult Update(Student student)
        //    {
        //        repository.UpdateStudent(student);
        //        TempData["Message"] = "Student Details Updated Successfully";
        //        return RedirectToAction("Index");
        //    }

        //}
        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            Repository repository = new Repository();
            Student student = new Student();
            TryUpdateModel(student);
            if (ModelState.IsValid)
            {
                repository.AddStudent(student);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Delete(string StudentId)
        {
            repository.DeleteStudent(StudentId);
            TempData["Message"] = "Student Detail Deleted Successfully!";
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string StudentId)
        {
            Student student = repository.GetStudent(StudentId);
            return View(student);
        }
        [HttpPost]
        public ActionResult Update(Student student)
        {
            repository.UpdateStudent(student);
            TempData["Message"] = "Student Details Updated Successfully";
            return RedirectToAction("Index");
        }
    }
}