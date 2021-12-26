using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionAndAnswerMVC.Models
{
    public class CommonViewModel
    {
        public TechnologyViewModel technologies { get; set; }

        public QuestionsandAnswersViewModel qanda { get; set; }
    }
}