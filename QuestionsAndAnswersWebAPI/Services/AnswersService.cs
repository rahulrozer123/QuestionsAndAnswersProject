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

        public AnswersService(IAnswersDBService context)
        {
            _context = context;
        }
        public IEnumerable<Answers> GetAnswersGivenByUser(Answers ans)
        {
            var result = _context.GetAnswers(ans);               
            return result;
        }

    }
}
