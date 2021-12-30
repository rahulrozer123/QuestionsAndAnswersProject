using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswersDBContext.Models;
using QuestionsAndAnswersDBContext.Services;
using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Services
{
    public class QuestionAndAnswerService : IQuestionAndAnswerService
    {
        private readonly IQuestionAndAnswerDBService _context;


        public QuestionAndAnswerService(IQuestionAndAnswerDBService context)
        {
            _context = context;
        }
        public IEnumerable<QuestionsAndAnswersModel> GetAllQuestionsAndAnswers()
        {
            var data = _context.GetAllQuestionsAndAnswers()
                .Select(f => new QuestionsAndAnswersModel()
                {
                    QuestionID = f.QuestionID,
                    Question = f.Question,
                    Option1 = f.Option1,
                    Option2 = f.Option2,
                    Option3 = f.Option3,
                    Option4 = f.Option4
                }).ToList();
            return data;
        }

        //public QuestionsAndAnswersModel GetById(int id)
        //{
        //    var questionsAndAnswersModel = _context.QuestionandAnswer.FirstOrDefault(e => e.QuestionID == id);
        //    return questionsAndAnswersModel;
        //}

        public IEnumerable<QuestionsAndAnswersModel> GetQuestionsByTechnologyId(int technologyId)
        {
            var technologyModel = _context.GetQuestionsByTechnologyId(technologyId)
                .Where(f => f.TechnologyId == technologyId)
                .Select(f => new QuestionsAndAnswersModel
                {
                    QuestionID = f.QuestionID,
                    Question = f.Question,
                    Option1 = f.Option1,
                    Option2 = f.Option2,
                    Option3 = f.Option3,
                    Option4 = f.Option4,                   
                }).ToList();
            return technologyModel;
        }        

        //public QuestionsAndAnswersModel Add(QuestionsAndAnswersModel questionsAndAnswersModel)
        //{
        //    _context.QuestionandAnswer.Add(new QuestionsAndAnswersModel()
        //    {
        //        QuestionID = questionsAndAnswersModel.QuestionID,
        //        TechnologyId = questionsAndAnswersModel.TechnologyId,
        //        Question = questionsAndAnswersModel.Question,
        //        Option1 = questionsAndAnswersModel.Option1,
        //        Option2 = questionsAndAnswersModel.Option2,
        //        Option3 = questionsAndAnswersModel.Option3,
        //        Option4 = questionsAndAnswersModel.Option4,
        //        ActualAnswer = questionsAndAnswersModel.ActualAnswer
        //    });
        //    _context.SaveChanges();

        //    return questionsAndAnswersModel;
        //}

        //public void Delete(int id)
        //{           
        //    var questionsAndAnswersModel = _context.QuestionAndAnswer.FirstOrDefault(e => e.QuestionID == id);
        //    if (questionsAndAnswersModel == null)
        //    {
        //       return;
        //    }
        //    _context.QuestionAndAnswer.Remove(questionsAndAnswersModel);
        //    _context.SaveChanges();           
        //}

        public void Update(QuestionsAndAnswers questionsAndAnswersModel)
        {
            _context.Update(questionsAndAnswersModel);
        }
    }
}
