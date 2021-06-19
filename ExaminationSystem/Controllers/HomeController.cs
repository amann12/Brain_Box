using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModel;
using Microsoft.AspNetCore.Identity;

namespace ExaminationSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentInterface student;
        private readonly CourseInterface course;
        public HomeController(StudentInterface _student, CourseInterface _course)
        {
            student = _student;
            course = _course;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult StudCourse()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StudCourse(StudentCourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var st=new Student
                {
                    sName = model.sName,
                    sEmailId = model.sEmailId,
                    sFatherName = model.sFatherName,
                    sMotherName = model.sMotherName,
                    sMobileNumber = model.sMobileNumber,
                };
                var res = student.Add(st);
                var cour = new Course
                {
                    cName = model.cName,
                    cType = model.cType,
                    cDuration = model.cDuration
                };
                var result = course.Add(cour);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
