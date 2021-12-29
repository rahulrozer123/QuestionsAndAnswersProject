using Newtonsoft.Json;
using QuestionAndAnswerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace QuestionAndAnswerMVC.Controllers
{
    public class RegistrationController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44363/api/");
        HttpClient client;

        public RegistrationController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(RegistrationViewModel register)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("RegistrationModels", register).Result;
            if (response.IsSuccessStatusCode)
            {
                ViewData["Success Message"] = "Registration Successfull";
                return RedirectToAction("Login");
            }
            else
            {
                ViewData["Message"] = "Registration Attempt failed";
            }
            return View(register);            
            //return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel login)
        {
            //if (ModelState.IsValid)
            //{
            //    //var obj = context.UserRegistration.Where(a => a.Username.Equals(login.UserName) && a.Pwd.Equals(login.Pwd)).FirstOrDefault();
            //    //if (obj != null)
            //    //{
            //    //    Session["UserID"] = obj.UserId.ToString();
            //    //    Session["UserName"] = obj.Username.ToString();
            //    //    return RedirectToAction("QuestionAndAnswer", "QuestionsAndAnswers");
            //    //}
            //}            
            HttpResponseMessage response = client.PostAsJsonAsync("LoginModel/Loginmodule", login).Result;
            if (response.IsSuccessStatusCode)
            {
                Session["username"] = login.UserName.ToString();
                FormsAuthentication.SetAuthCookie(login.UserName, false);
                return RedirectToAction("GetTechnologies", "QuestionsAndAnswers");
            }
            else
            {
                ViewData["Message"] = "Login attempt failed";
            }
            return View();
        }

        [Authorize]
        public ActionResult GetAllRegistrations()
        {
            List<RegistrationViewModel> modelList = new List<RegistrationViewModel>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "RegistrationModels").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                modelList = JsonConvert.DeserializeObject<List<RegistrationViewModel>>(data);
            }
            return View(modelList);
        }        
    }
}