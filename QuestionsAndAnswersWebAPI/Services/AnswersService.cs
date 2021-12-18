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
            //New code which will store multiple entires
            var all_keys = answersModel.qanda.Keys;
            foreach(string x in all_keys) {
                string val = answersModel.qanda[x];
                
                _context.GetAnswers(new Answers()
                {
                    ReceivedAnswers = val,
                    QuestionId = int.Parse(x),
                    UserId = answersModel.UserId,
                    Result = GetResult(int.Parse(x), val),
                    TechnologyId = answersModel.TechnologyId,
                });
            }            

            //Old code which used to save only 1 user responses
            //_context.GetAnswers(new Answers()
            //{
            //    ReceivedAnswers = answersModel.ReceivedAnswers,
            //    QuestionId = answersModel.QuestionID,
            //    UserId = answersModel.UserId,                
            //    Result = GetResult(answersModel),
            //    TechnologyId = answersModel.TechnologyId,
            //});                                             
            return answersModel;
        }
        
        private bool GetResult(int questonId,string answer)
        {            
            var entity = _Dbcontext.QuestionandAnswers.Where(e => e.QuestionID == questonId).FirstOrDefault();            
            if (entity.ActualAnswer == answer)
                return true;
            else
                return false;
        }
    }
}
