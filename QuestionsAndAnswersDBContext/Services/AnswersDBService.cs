﻿using QuestionsAndAnswersDBContext.Data;
using QuestionsAndAnswersDBContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersDBContext.Services
{
    public class AnswersDBService : IAnswersDBService
    {
        private  QuestionsandAnswersDBContext _Dbcontext;
        
        public AnswersDBService(QuestionsandAnswersDBContext Dbcontext)
        {
            _Dbcontext = Dbcontext;
        }
        public Answers GetAnswers(Answers answers)
        {
            _Dbcontext.Answers.Add(new Answers()
            {
                AnswersId = answers.AnswersId,
                ReceivedAnswers = answers.ReceivedAnswers,
                Result= answers.Result,
                UserId = answers.UserId,
                TechnologyId = answers.TechnologyId,
                QuestionId = answers.QuestionId                
            });
            _Dbcontext.SaveChanges();
            return answers;
        }

        public List<Answers> GetResultByUserId(int userId)
        {
            var result = _Dbcontext.Answers
                .Where(f => f.UserId == userId)
                .Select(f => new Answers
                {
                    TechnologyId = f.TechnologyId,
                    QuestionId = f.QuestionId,
                    Result = f.Result
                }).ToList();
            return result;
        }
    }
}
