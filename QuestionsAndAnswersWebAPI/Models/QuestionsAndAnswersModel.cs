using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Models
{
    public class QuestionsAndAnswersModel
    {
        [Key]
        public int QuestionID { get; set; }

        public int TechnologyId { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string ActualAnswer { get; set; }

       // public virtual TechnologyModel  TechnologyModel {get;set;}
    }
}
