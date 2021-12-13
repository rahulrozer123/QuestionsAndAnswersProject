using QuestionsAndAnswersDBContext.Models;
using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Services
{
    public interface ITechnologyService
    {
        IEnumerable<TechnologyModel> GetAllTechnologies();
    }
}
