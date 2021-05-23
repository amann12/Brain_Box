using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModelCourse;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    public class CourseController : Controller
    {
        private readonly CourseInterface course;
        public CourseController(CourseInterface course)
        {
            this.course = course;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SingleDetails(int Id)
        {
            Course c = course.fetchCourseDetails(Id);
            return View(c);
        }

        public IActionResult AllDetails()
        {
            var data = course.CourseDetails();
            return View(data);

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Course courses = course.fetchCourseDetails(Id);
            EditCourseViewModel editCourseViewModel = new EditCourseViewModel
            {
                Id = courses.Id,
                cId=courses.cId,
                cName=courses.cName,
                cType=courses.cType,
                cDuration=courses.cDuration

            };
            return View(editCourseViewModel);
        }
        [HttpPost]
        public IActionResult Edit(EditCourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                Course courses = course.fetchCourseDetails(model.Id);
                courses.cName = model.cName;
                courses.cType = model.cType;
                courses.cDuration = model.cDuration;
                Course updateCourse = course.Update(courses);
                return RedirectToAction("AllDetails");
            }
            return View(model);
        }
        public IActionResult Delete(int Id)
        {
            course.Delete(Id);
            return RedirectToAction("AllDetails");

        }
        [HttpGet]
        public IActionResult NewCourse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateCourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                Course newCourse = new Course
                {
                    cId = model.cId,
                    cName = model.cName,
                    cType=model.cType,
                    cDuration=model.cDuration
                };
                course.Add(newCourse);
                return RedirectToAction("AllDetails", new { Id = newCourse.Id });
            }
            return View();
        }
    }
}