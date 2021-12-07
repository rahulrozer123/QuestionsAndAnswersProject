using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersProject.Models
{
    public class QuestionandAnswer
    {
        [Key]
        public int QuestionId { get; set; }

        public string Technology { get; set; }

        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string ActualAnswer { get; set; }

    }
}
