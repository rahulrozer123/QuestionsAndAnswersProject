using QuestionsAndAnswersWebAPI.Data;
using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Services
{
    public class AnswersService : IAnswersService
    {
        private readonly AnswersContext _context;

        public AnswersService(AnswersContext context)
        {
            _context = context;
        }
        public IEnumerable<AnswersModel> GetAllAnswersByID(int id)
        {
            var answersModel = _context.Answers
                .Where(f => f.TechnologyID == id)
                .Select(f => new AnswersModel
                {
                    AnswerID = f.AnswerID,
                    ReceivedAnswers = f.ReceivedAnswers,
                    Result = f.Result,
                    UserID = f.UserID,
                    TechnologyID = f.TechnologyID,
                    QuestionID = f.QuestionID                    
                })
                .ToList();
            return answersModel;
        }
       
    }
}
