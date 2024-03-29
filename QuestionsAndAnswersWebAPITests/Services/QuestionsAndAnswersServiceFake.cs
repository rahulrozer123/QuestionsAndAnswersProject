﻿using QuestionsAndAnswersDBContext.Models;
using QuestionsAndAnswersWebAPI.Models;
using QuestionsAndAnswersWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPITests.Services
{
    public class QuestionsAndAnswersServiceFake : IQuestionAndAnswerService
    {
        private readonly IList<QuestionsAndAnswersModel> _questionsAndAnswers;

        public QuestionsAndAnswersServiceFake()
        {
            _questionsAndAnswers = new List<QuestionsAndAnswersModel>()
            {
                new QuestionsAndAnswersModel(){ QuestionID = 1,Question = "CLR is the .Net equivalent of ",Option1 = "A-Java Virtual machine",
                    Option2 = "B-Common Language Runtime",Option3 = "C-Common Type System",Option4 = "D-Common Language Specification"},
                new QuestionsAndAnswersModel(){ QuestionID = 2,Question = "The default scope for the members of an interface is",Option1 = "A-private",
                    Option2 = "B-Public",Option3 = "Protected",Option4 = "internal"},
                new QuestionsAndAnswersModel(){ QuestionID = 3,Question = "The space required for structure variables is allocated on the stack.",Option1 = "True",
                    Option2 = "False",Option3 = "Maybe",Option4 = "Can't say"},
            };
        }

        public IEnumerable<QuestionsAndAnswersModel> GetAllQuestionsAndAnswers()
        {
            return _questionsAndAnswers;
        }

        public IEnumerable<QuestionsAndAnswersModel> GetQuestionsByTechnologyId(int questionId)
        {
               var data=_questionsAndAnswers
                            .Where(a => a.QuestionID == questionId).FirstOrDefault();
            yield return data;
        }        

        public void Update(QuestionsAndAnswers questionsAndAnswersModel)
        {
            //var entity = _questionsAndAnswers.Where(e => e.QuestionID == questionsAndAnswersModel.QuestionID).FirstOrDefault();
            //if (entity != null)
            //{
            //    entity.Question = questionsAndAnswersModel.Question;                
            //    entity.Option1 = questionsAndAnswersModel.Option1;
            //    entity.Option2 = questionsAndAnswersModel.Option2;
            //    entity.Option3 = questionsAndAnswersModel.Option3;
            //    entity.Option4 = questionsAndAnswersModel.Option4;                              
            //}
        }
    }
}
