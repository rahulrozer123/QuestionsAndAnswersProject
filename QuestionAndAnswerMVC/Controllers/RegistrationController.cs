using Newtonsoft.Json;
using QuestionAndAnswerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult Index(RegistrationViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            return RedirectToAction("Login");
            //return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
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
            string data = JsonConvert.SerializeObject(login);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "RegistrationModels", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetTechnologies", "QuestionsAndAnswers");
            }
            return View();
        }
    }
}