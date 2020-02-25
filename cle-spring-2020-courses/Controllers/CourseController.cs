using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cle_spring_2020_courses.Models;
using cle_spring_2020_courses.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace cle_spring_2020_courses.Controllers
{
    public class CourseController : Controller
    {
        IRepository<Course> courseRepo;
        
        public CourseController(IRepository<Course> courseRepo)
        {
            this.courseRepo = courseRepo;
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpGet]
        public ViewResult CreateByInstructorId(int id)
        {
            ViewBag.InstructorId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Course course)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            courseRepo.Create(course);
            return RedirectToAction("Index");
        }
        
        public ViewResult Index()
        {
            var model = courseRepo.GetAll();
            
            return View(model);
        }

        public ViewResult Details(int id)
        {
            Course model = courseRepo.GetById(id);

            return View(model);
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            Course model = courseRepo.GetById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Course course)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            courseRepo.Update(course);

            return RedirectToAction("Details", "Instructor", new { id = course.InstructorId });
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            Course model = courseRepo.GetById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Course course)
        {
            courseRepo.Delete(course);
            
            return RedirectToAction("Index");
        }
    }
}
