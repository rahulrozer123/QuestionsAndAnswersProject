using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Services
{
    public interface IAnswersService
    {
        IEnumerable<AnswersModel> GetAllAnswersByID(int id);
    }
}
