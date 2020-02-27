using cle_spring_2020_courses.Models;
using cle_spring_2020_courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2020_courses.Controllers
{
    public class StudentCourseController : Controller
    {
        IRepository<StudentCourse> studentCourseRepo;

        public StudentCourseController(IRepository<StudentCourse> studentCourseRepo)
        {
            this.studentCourseRepo = studentCourseRepo;
        }

        [HttpGet]
        public ViewResult CreateByCourseId(int id)
        {
            ViewBag.InstructorId = id;
            return View();
        }
    }
}
