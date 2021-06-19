using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly StudentInterface student;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, StudentInterface student)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.student = student;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email

                };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {

                    return RedirectToAction("index", "home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model/*, string returnUrl*/)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.Email, model.Password, model.Rememberme, false
                    );

                var stu = student.GetDetailByEmail(model.Email);

                if (result.Succeeded)
                {
                    //if (!string.IsNullOrEmpty(returnUrl))
                    //{
                    //    return Redirect(returnUrl);
                    //}
                    //else
                    //{
                    //    return RedirectToAction("Login", "Account");
                    //}
                    //return RedirectToAction("index", "home");
                    return RedirectToAction("Profile", "Dashboard", new { id = stu.Id });
                }
                else
                {

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult RegisterStudent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterStudent(StudentRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var f = new IdentityUser
                {
                    UserName = model.sEmailId,
                    Email = model.sEmailId
                };
                var r = await userManager.CreateAsync(f, model.Password);
                //var user = new IdentityUser
                //{
                //    UserName = model.sEmailId,
                //    Email = model.sEmailId
                //};
                //var result = await userManager.CreateAsync(user, model.Password);

                var st = new Student
                {
                    sName = model.sName,
                    sEmailId = model.sEmailId,
                    sDOB = model.sDOB,
                    sFatherName = model.sFatherName,
                    sMotherName = model.sMotherName,
                    sBloodGroup = model.sBloodGroup,
                    sGender = model.sGender,
                    sMobileNumber = model.sMobileNumber,
                    sAddress = model.sAddress,
                    sRollNumber = model.sRollNumber
                };
                var re = student.Add(st);
                if (r.Succeeded)
                {
                    return RedirectToAction("index", "Home");
                }
                foreach(var error in r.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
                return View(model);
        }
    }
}