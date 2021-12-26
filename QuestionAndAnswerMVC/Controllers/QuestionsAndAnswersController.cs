using QuestionAndAnswerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace QuestionAndAnswerMVC.Controllers
{
    public class QuestionsAndAnswersController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44363/api/");
        HttpClient client;

        public QuestionsAndAnswersController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public ActionResult GetTechnologies()
        {
            //if (Session["UserID"] != null)
            //{
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}
            IEnumerable<TechnologyViewModel> technologies = null;          
            var readdata = client.GetAsync(client.BaseAddress + "TechnologyModels").Result;
            if(readdata.IsSuccessStatusCode)
            {
                var consmedata = readdata.Content.ReadAsAsync<IList<TechnologyViewModel>>();
                consmedata.Wait();
                technologies = consmedata.Result;
            }
            return View(technologies);
        }
    }
}