using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModelStudent;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentInterface student;
        public StudentController(StudentInterface student)
        {
            this.student = student;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SingleDetails(int Id)
        {
            Student s = student.fetchStudentDetails(Id);
            return View(s);
        }
        public IActionResult AllDetails()
        {
            var data = student.StudentDetails();
            return View(data);

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Student students = student.fetchStudentDetails(Id);
            EditStudentViewModel editStudentViewModel = new EditStudentViewModel
            {
                Id = students.Id,
                sId=students.sId,
                sName=students.sName,
                sEmailId=students.sEmailId,
                sDOB=students.sDOB,
                sFatherName=students.sFatherName,
                sMotherName=students.sMotherName,
                sBloodGroup=students.sBloodGroup,
                sGender=students.sGender,
                sMobileNumber=students.sMobileNumber,
                sAddress=students.sAddress,
                sRollNumber=students.sRollNumber

            };
            return View(editStudentViewModel);
        }
        [HttpPost]
        public IActionResult Edit(EditStudentViewModel model)
        {
            if (ModelState.IsValid)
            {
                Student students = student.fetchStudentDetails(model.Id);
                students.sName = model.sName;
                students.sEmailId = model.sEmailId;
                students.sDOB = model.sDOB;
                students.sFatherName = model.sFatherName;
                students.sMotherName = model.sMotherName;
                students.sBloodGroup = model.sBloodGroup;
                students.sGender = model.sGender;
                students.sMobileNumber = model.sMobileNumber;
                students.sAddress = model.sAddress;
                students.sRollNumber = model.sRollNumber;
            Student updateStudent = student.Update(students);
                return RedirectToAction("AllDetails");
            }
                return View(model);
        }
        public IActionResult Delete(int Id)
        {
            student.Delete(Id);
            return RedirectToAction("AllDetails");

        }
        [HttpGet]
        public IActionResult NewStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateStudentViewModel model)
        {
            if (ModelState.IsValid)
            {
                Student newStudent = new Student
                {
                    sId = model.sId,
                    sName = model.sName,
                    sEmailId=model.sEmailId,
                    sDOB=model.sDOB,
                    sFatherName=model.sFatherName,
                    sMotherName=model.sMotherName,
                    sBloodGroup=model.sBloodGroup,
                    sGender=model.sGender,
                    sMobileNumber=model.sMobileNumber,
                    sAddress=model.sAddress,
                    sRollNumber=model.sRollNumber
                };
                student.Add(newStudent);
                return RedirectToAction("AllDetails", new { Id = newStudent.Id });
            }
            return View();
        }
    }
}