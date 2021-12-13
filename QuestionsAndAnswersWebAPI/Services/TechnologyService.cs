using QuestionsAndAnswersDBContext.Models;
using QuestionsAndAnswersDBContext.Services;
using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Services
{
    public class TechnologyService : ITechnologyService
    {
        private readonly ITechnologyDBService _technologyContext;

        public TechnologyService(ITechnologyDBService technologyContext)
        {
            _technologyContext = technologyContext;
        }
        public IEnumerable<TechnologyModel> GetAllTechnologies()
        {
            var data = _technologyContext.GetAllTechnologies()
                 .Select(f => new TechnologyModel()
                 {
                    TechnologyName = f.TechnologyName
                 }) ;
            return data;
        } 
    }
}
