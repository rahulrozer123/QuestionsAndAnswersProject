using Microsoft.AspNetCore.Mvc;
using QuestionsAndAnswersProject.Data;
using QuestionsAndAnswersProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersProject.Controllers
{
    public class QuestionsAndAnswersController : Controller
    {
        //private readonly ApplicationUser user;

        //public QuestionsAndAnswersController(ApplicationUser _user)
        //{
        //    user = _user;
        //}
        public IActionResult QuestionsAndAnswers()
        {
            if (TempData["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login","Account");
            }           
        }

        [HttpPost]
        public IActionResult QuestionsAndAnswers(Technology technology)
        {
            
            return View();
            //List<string> answers = new List<string>();
            //answers.Add("C");
            //answers.Add("C");  
            //answers.Add("A");
            //answers.Add("D");
            //answers.Add("D");
            //answers.Add("B");
            //answers.Add("A");
            //answers.Add("C");
            //answers.Add("A");
            //answers.Add("C");
            //answers.Add("C");

            ////Console.WriteLine(answers);

            //List<String> user_answers = new List<string>();
            //user_answers.Add(technology.firstTechnology.Question1Answer);
            //user_answers.Add(technology.firstTechnology.Question2Answer);
            //user_answers.Add(technology.firstTechnology.Question3Answer);
            //user_answers.Add(technology.firstTechnology.Question4Answer);
            //user_answers.Add(technology.firstTechnology.Question5Answer);
            //user_answers.Add(technology.firstTechnology.Question6Answer);
            //user_answers.Add(technology.firstTechnology.Question7Answer);
            //user_answers.Add(technology.firstTechnology.Question8Answer);
            //user_answers.Add(technology.firstTechnology.Question9Answer);
            //user_answers.Add(technology.firstTechnology.Question10Answer);

            //List<bool> write_or_wrong = new List<bool>();

            //for (int i= 0; i< user_answers.Count; i++) {
            //    if (answers[i].Equals(user_answers[i]))
            //        write_or_wrong.Add(true);
            //    else
            //        write_or_wrong.Add(false);
            //}

            //Console.WriteLine(write_or_wrong);
            //int j = 1;
            //foreach(bool x in write_or_wrong)
            //{
            //    Console.WriteLine("" + j + " : " + x);
            //    j++;
            //}

            //f = technology.firstTechnology;
            //Still to write the logic of saving data and checking the answer with the user answer
           // return RedirectToAction("Login", "Account");
        }        
    }
}
