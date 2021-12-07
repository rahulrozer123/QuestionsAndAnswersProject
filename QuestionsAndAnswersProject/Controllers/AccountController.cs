using Microsoft.AspNetCore.Mvc;
using QuestionsAndAnswersProject.Data;
using QuestionsAndAnswersProject.Models;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationUser user;

        public AccountController(ApplicationUser _user)
        {
            user = _user;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(RegistrationModel register)
        {
            user.Add(register);
            user.SaveChanges();
            // ViewBag.message = "The user " + uc.Username + " is saved successfully";
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            //return View();
            if (ModelState.IsValid)
            {
                var obj = user.UserRegistration.Where(a => a.Username.Equals(login.UserName) && a.Pwd.Equals(login.Password)).FirstOrDefault();
                if (obj != null)
                {
                    TempData["UserID"] = obj.UserId.ToString();
                    TempData["UserName"] = obj.Username.ToString();
                    return RedirectToAction("QuestionsAndAnswers", "QuestionsAndAnswers");
                }
            }
            return View(login);
        }
    }
}
