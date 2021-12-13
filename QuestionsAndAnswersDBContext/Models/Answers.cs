using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersDBContext.Models
{
    public partial class Answers
    {
        [Key]
        public int AnswersId { get; set; }

        public string ReceivedAnswers { get; set; }

        public bool Result { get; set; }

        public int UserId { get; set; }

        public int TechnologyId { get; set; }
        public int QuestionId { get; set; }
    }
}
