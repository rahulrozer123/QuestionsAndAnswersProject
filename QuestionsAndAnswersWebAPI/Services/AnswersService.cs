using QuestionsAndAnswersDBContext.Data;
using QuestionsAndAnswersDBContext.Models;
using QuestionsAndAnswersDBContext.Services;
using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Services
{
    public class AnswersService : IAnswersService
    {
        private readonly IAnswersDBService _context;        
        private readonly QuestionsandAnswersDBContext _Dbcontext;        
        
        public AnswersService(IAnswersDBService context, QuestionsandAnswersDBContext Dbcontext)
        {
            _context = context;
            _Dbcontext = Dbcontext;           
        }
        public AnswersModel GetAnswersGivenByUser(AnswersModel answersModel)
        {
            _context.GetAnswers(new Answers()
            {
                ReceivedAnswers = answersModel.ReceivedAnswers,
                QuestionId = answersModel.QuestionID,
                UserId = answersModel.UserId,                
                Result = GetResult(answersModel),
                TechnologyId = answersModel.TechnologyId,
            });                                             
            return answersModel;
        }
        
        private bool GetResult(AnswersModel answersModel)
        {            
            var entity = _Dbcontext.QuestionandAnswers.Where(e => e.QuestionID == answersModel.QuestionID).FirstOrDefault();            
            if (entity.ActualAnswer == answersModel.ReceivedAnswers)
                return true;
            else
                return false;
        }
    }
}
