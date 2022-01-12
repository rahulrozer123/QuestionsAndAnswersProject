using Kendo.Mvc.Extensions;
using Newtonsoft.Json;
using QuestionAndAnswerMVC.Logging;
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
        [Authorize(Roles = "Admin")]
        public ActionResult GetAllQuestions()
        {
            try
            {
                if (Session["UserId"] != null)
                {
                    IEnumerable<QuestionsandAnswersViewModel> allQuestions = null;
                    var readdata = client.GetAsync(client.BaseAddress + "QuestionsAndAnswersModels/Get all the questions and options").Result;
                    if (readdata.IsSuccessStatusCode)
                    {
                        var consmedata = readdata.Content.ReadAsAsync<IList<QuestionsandAnswersViewModel>>();
                        consmedata.Wait();
                        allQuestions = consmedata.Result;
                        return View(allQuestions);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Default.WriteError(ex.Message, ex);
            }
            return RedirectToAction("Login", "Registration");
        }

        public ActionResult Search(int id)
        {
            try
            {
                if (Session["UserId"] != null)
                {
                    var answerResultlist = new List<AnswersViewModel>();
                    HttpResponseMessage response = client.GetAsync("AnswersModel/GetResult?id=" + id).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var consumeData = response.Content.ReadAsAsync<List<AnswersViewModel>>();
                        consumeData.Wait();
                        answerResultlist = consumeData.Result;
                        return View(answerResultlist);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Default.WriteError(ex.Message, ex);
            }
            return RedirectToAction("Login", "Registration");
        }
        public ActionResult GetTechnologies()
        {
            try
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
            }
            catch (Exception ex)
            {
                LogHelper.Default.WriteError(ex.Message, ex);
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
            try
            {
                if (Session["username"] != null)
                {
                    IEnumerable<QuestionsandAnswersViewModel> questions = null;
                    var readdata = client.GetAsync(client.BaseAddress + "QuestionsAndAnswersModels/" + technologyId).Result;
                    if (readdata.IsSuccessStatusCode)
                    {
                        var consmedata = readdata.Content.ReadAsAsync<IList<QuestionsandAnswersViewModel>>();
                        consmedata.Wait();
                        questions = consmedata.Result;
                        return View(questions);
                    }
                    //IEnumerable<QuestionsandAnswersViewModel> questions = null;                                
                    //var readdata = client.GetAsync(client.BaseAddress + "QuestionsAndAnswersModels/" + technologyId).Result;
                    //if (readdata.IsSuccessStatusCode)
                    //{
                    //    var consmedata = readdata.Content.ReadAsAsync<IList<QuestionsandAnswersViewModel>>();
                    //    consmedata.Wait();
                    //    questions = consmedata.Result;
                    //    CommonViewModel model = new CommonViewModel();
                    //    model.listQuestions = questions;
                    //    model.selectedAnswer = string.Empty;
                    //    return View(model);
                    //}
                }
            }
            catch (Exception ex)
            {
                LogHelper.Default.WriteError(ex.Message, ex);
            }
            return RedirectToAction("Login", "Registration");
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Questions(List<QuestionsandAnswersViewModel> model, FormCollection test)
        {
            try
            {
                AnswersViewModel answers = new AnswersViewModel();
                HttpResponseMessage response = null;
                answers.UserId = (int)Session["userid"];
                foreach (var item in model)
                {
                    answers.QuestionID = item.QuestionID;
                    answers.ReceivedAnswers = item.Answers.ReceivedAnswers;
                    response = client.PostAsJsonAsync("AnswersModel/GetAnswers", answers).Result;
                }
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Thankyou");
                }
            }
            catch (Exception ex)
            {
                LogHelper.Default.WriteError(ex.Message, ex);
            }
            return View(model);
        }

        public ActionResult Thankyou()
        {
            return View();
        }
    }
}