using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModelTeacher;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    public class TeacherController : Controller
    {
        private readonly TeacherInterface teacher;
        public TeacherController(TeacherInterface teacher)
        {
            this.teacher = teacher;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SingleDetails(int Id)
        {
            Teacher t = teacher.fetchTeacherDetails(Id);
            return View(t);
        }

        public IActionResult AllDetails()
        {
            var data = teacher.TeacherDetails();
            return View(data);

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Teacher teachers = teacher.fetchTeacherDetails(Id);
            EditTeacherViewModel editTeacherViewModel = new EditTeacherViewModel
            {
                Id = teachers.Id,
                tId = teachers.tId,
                tName = teachers.tName,
                tGender = teachers.tGender,
                tBloodGroup = teachers.tBloodGroup,
                tEmailId = teachers.tEmailId,
                tMobileNumber = teachers.tMobileNumber,
                tQualification = teachers.tQualification

            };
            return View(editTeacherViewModel);
        }
        [HttpPost]
        public IActionResult Edit(EditTeacherViewModel model)
        {
            if (ModelState.IsValid)
            {
                Teacher teachers = teacher.fetchTeacherDetails(model.Id);
                teachers.tName = model.tName;
                teachers.tGender = model.tGender;
                teachers.tBloodGroup = model.tBloodGroup;
                teachers.tEmailId = model.tEmailId;
                teachers.tMobileNumber = model.tMobileNumber;
                teachers.tQualification= model.tQualification;
                teachers.tAddress = model.tAddress;
                Teacher updateTeacher = teacher.Update(teachers);
                return RedirectToAction("AllDetails");
            }
            return View(model);
        }
        public IActionResult Delete(int Id)
        {
            teacher.Delete(Id);
            return RedirectToAction("AllDetails");

        }
        [HttpGet]
        public IActionResult NewTeacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateTeacherViewModel model)
        {
            if (ModelState.IsValid)
            {
                Teacher newTeacher = new Teacher
                {
                    tId = model.tId,
                    tName = model.tName,
                    tGender = model.tGender,
                    tBloodGroup = model.tBloodGroup,
                    tEmailId = model.tEmailId,
                    tMobileNumber = model.tMobileNumber,
                    tQualification = model.tQualification,
                    tAddress = model.tAddress
                };
                teacher.Add(newTeacher);
                return RedirectToAction("AllDetails", new { Id = newTeacher.Id });
            }
            return View();
        }

    }
}