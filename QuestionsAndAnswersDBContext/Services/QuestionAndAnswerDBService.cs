using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswersDBContext.Data;
using QuestionsAndAnswersDBContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuestionsAndAnswersDBContext.Services
{
    public class QuestionAndAnswerDBService : IQuestionAndAnswerDBService
    {
        private  QuestionsandAnswersDBContext _Dbcontext;


        public QuestionAndAnswerDBService(QuestionsandAnswersDBContext Dbcontext)
        {
            _Dbcontext = Dbcontext;
        }
        public IEnumerable<QuestionsAndAnswers> GetAllQuestionsAndAnswers()
        {
            var questionsAndAnswers = _Dbcontext.QuestionandAnswers
                .Select(f => new QuestionsAndAnswers
                {
                    QuestionID = f.QuestionID,
                    TechnologyId = f.TechnologyId,
                    Question = f.Question,
                    Option1 = f.Option1,
                    Option2 = f.Option2,
                    Option3 = f.Option3,
                    Option4 = f.Option4,
                    ActualAnswer = f.ActualAnswer
                }).ToList();

            return questionsAndAnswers;
        }

        //public QuestionsAndAnswersModel GetById(int id)
        //{
        //    var questionsAndAnswersModel = _context.QuestionandAnswer.FirstOrDefault(e => e.QuestionID == id);
        //    return questionsAndAnswersModel;
        //}

        public List<QuestionsAndAnswers> GetQuestionsByTechnologyId(int technologyId)
        {
            var technologyModel = _Dbcontext.QuestionandAnswers
                .Where(f => f.TechnologyId == technologyId)
                .Select(f => new QuestionsAndAnswers
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
        //    _Dbcontext.QuestionandAnswer.Add(new QuestionsAndAnswersModel()
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
        //    var questionsAndAnswersModel = _Dbcontext.QuestionAndAnswer.FirstOrDefault(e => e.QuestionID == id);
        //    if (questionsAndAnswersModel == null)
        //    {
        //       return;
        //    }
        //    _context.QuestionAndAnswer.Remove(questionsAndAnswersModel);
        //    _context.SaveChanges();           
        //}

        public void Update(QuestionsAndAnswers questionsAndAnswersModel)
        {
            var entity = _Dbcontext.QuestionandAnswers.Where(e => e.QuestionID == questionsAndAnswersModel.QuestionID).FirstOrDefault();
            if (entity != null)
            {
                entity.Question = questionsAndAnswersModel.Question;
                entity.TechnologyId = questionsAndAnswersModel.TechnologyId;
                entity.Option1 = questionsAndAnswersModel.Option1;
                entity.Option2 = questionsAndAnswersModel.Option2;
                entity.Option3 = questionsAndAnswersModel.Option3;
                entity.Option4 = questionsAndAnswersModel.Option4;
                entity.ActualAnswer = questionsAndAnswersModel.ActualAnswer;
                _Dbcontext.SaveChanges();
            }
        }
    }
}
