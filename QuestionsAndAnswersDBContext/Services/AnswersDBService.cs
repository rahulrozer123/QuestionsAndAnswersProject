using QuestionsAndAnswersDBContext.Data;
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
        public IEnumerable<Answers> GetAnswers(Answers answers)
        {
            var answersModel = _Dbcontext.Answers
                .Where(f => f.TechnologyId == answers.AnswersId)
                .Select(f => new Answers
                {
                    AnswersId = f.AnswersId,
                    ReceivedAnswers = f.ReceivedAnswers,
                    UserId = f.UserId,
                    TechnologyId = f.TechnologyId,
                    QuestionId = f.QuestionId
                })
                .ToList();
            return answersModel;
        }
       
    }
}
