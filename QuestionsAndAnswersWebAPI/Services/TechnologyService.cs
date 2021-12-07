using QuestionsAndAnswersWebAPI.Data;
using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Services
{
    public class TechnologyService : ITechnologyService
    {
        private readonly TechnologyContext _technologyContext;

        public TechnologyService(TechnologyContext technologyContext)
        {
            _technologyContext = technologyContext;
        }
        public IEnumerable<TechnologyModel> GetAllTechnologies()
        {
            return _technologyContext.MasterTechnology.ToList();
        }
    }
}
