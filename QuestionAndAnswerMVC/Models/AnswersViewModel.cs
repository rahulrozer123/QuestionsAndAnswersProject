using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestionAndAnswerMVC.Models
{
    public class AnswersViewModel
    {
        [Key]
        //public int AnswerID { get; set; }
        public int QuestionID { get; set; }
        public string ReceivedAnswers { get; set; }       
        public int UserId { get; set; }

        public bool Result { get; set; }
        //public int TechnologyId { get; set; }
        //This will store the list of questions and answers which the user will be giving
        //public Dictionary<string, string> qanda { get; set; }        
    }
}