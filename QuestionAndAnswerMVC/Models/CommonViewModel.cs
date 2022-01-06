using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionAndAnswerMVC.Models
{
    public class CommonViewModel
    {
        //public TechnologyViewModel technologies { get; set; }

        public IEnumerable<QuestionsandAnswersViewModel> listQuestions { get; set; }

        public string selectedAnswer { get; set; }

        //public IEnumerable<AnswersViewModel> listAnswers { get; set; }        
    }
}