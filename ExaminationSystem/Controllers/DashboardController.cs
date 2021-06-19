using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExaminationSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    public class DashboardController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly StudentInterface student;
        public DashboardController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, StudentInterface student)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.student = student;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Profile(int Id)
        {
            Student stu = student.fetchStudentDetails(Id);
            return View(stu);
        }
    }
}