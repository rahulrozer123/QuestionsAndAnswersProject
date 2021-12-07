using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswersWebAPI.Data;
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
        private readonly QuestionsAndAnswersContext _context;


        public QuestionAndAnswerService(QuestionsAndAnswersContext context)
        {
            _context = context;
        }
        public IEnumerable<QuestionsAndAnswersModel> GetAllQuestionsAndAnswers()
        {
            return _context.QuestionandAnswer.ToList();
        }

        //public QuestionsAndAnswersModel GetById(int id)
        //{
        //    var questionsAndAnswersModel = _context.QuestionandAnswer.FirstOrDefault(e => e.QuestionID == id);
        //    return questionsAndAnswersModel;
        //}

        public List<QuestionsAndAnswersModel> GetByTechnologyId(int id)
        {
            var technologyModel = _context.QuestionandAnswer
                .Where(f => f.TechnologyId == id)
                .Select(f => new QuestionsAndAnswersModel
                {
                    Question = f.Question,
                    TechnologyId = f.TechnologyId,
                    QuestionID = f.QuestionID,
                    Option1 = f.Option1,
                    Option2 = f.Option2,
                    Option3 = f.Option3,
                    Option4 = f.Option4,
                    ActualAnswer = f.ActualAnswer
                })
                .ToList();
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

        public void Update(QuestionsAndAnswersModel questionsAndAnswersModel)
        {
            var entity = _context.QuestionandAnswer.Where(e => e.QuestionID == questionsAndAnswersModel.QuestionID).FirstOrDefault();
            if (entity != null)
            {
                entity.Question = questionsAndAnswersModel.Question;
                entity.TechnologyId = questionsAndAnswersModel.TechnologyId;
                entity.Option1 = questionsAndAnswersModel.Option1;
                entity.Option2 = questionsAndAnswersModel.Option2;
                entity.Option3 = questionsAndAnswersModel.Option3;
                entity.Option4 = questionsAndAnswersModel.Option4;
                entity.ActualAnswer = questionsAndAnswersModel.ActualAnswer;
                _context.SaveChanges();
            }
        }
    }
}
