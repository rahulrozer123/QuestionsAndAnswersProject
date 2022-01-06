using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestionAndAnswerMVC.Models
{
    public class QuestionsandAnswersViewModel
    {
        [Key]
        public int QuestionID { get; set; }

        //public int TechnologyId { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string ActualAnswer { get; set; }
    }
}