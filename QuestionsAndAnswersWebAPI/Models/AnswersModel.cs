﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Models
{
    public class AnswersModel
    {
        [Key]
        public int AnswerID { get; set; }

        public string ReceivedAnswers { get; set; }
       
        public int QuestionID { get; set; }
    }
}