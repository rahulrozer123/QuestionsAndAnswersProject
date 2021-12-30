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
            if (Session["UserId"] != null)
            {
                IEnumerable<TechnologyViewModel> technologies = null;
                var readdata = client.GetAsync(client.BaseAddress + "TechnologyModels").Result;
                if (readdata.IsSuccessStatusCode)
                {
                    var consmedata = readdata.Content.ReadAsAsync<IList<TechnologyViewModel>>();
                    consmedata.Wait();
                    technologies = consmedata.Result;
                    return View(technologies);
                }                
            }
            return RedirectToAction("Login", "Registration");
        }
        [HttpPost]
        public ActionResult GetTechnologies(TechnologyViewModel technologies)
        {
            return RedirectToAction("Questions", technologies);
        }

        public ActionResult Questions(int technologyId)
        {
            if (Session["username"] != null)
            {
                IEnumerable<QuestionsandAnswersViewModel> questions = null;
                var readdata = client.GetAsync(client.BaseAddress +"QuestionsAndAnswersModels/" + technologyId).Result;            
                if (readdata.IsSuccessStatusCode)
                {
                    var consmedata = readdata.Content.ReadAsAsync<IList<QuestionsandAnswersViewModel>>();
                    consmedata.Wait();
                    questions = consmedata.Result;
                    return View(questions);
                }
            }
            return RedirectToAction("Login", "Registration");
        }
        [HttpPost]
        public ActionResult Questions(AnswersViewModel answers)
        {
            return View();
        }
    }
}