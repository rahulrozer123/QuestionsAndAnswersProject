using QuestionsAndAnswersDBContext.Models;
using QuestionsAndAnswersWebAPI.Models;
using QuestionsAndAnswersWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPITests.Services
{
    public class TechnologyServiceFake : ITechnologyService
    {
        private readonly IList<TechnologyModel> _technology;

        public TechnologyServiceFake()
        {
            _technology = new List<TechnologyModel>()
            {
                new TechnologyModel(){ TechnologyName = "CSharp"},
                new TechnologyModel(){ TechnologyName = "ASP NET MVC"},
                new TechnologyModel(){ TechnologyName = "Angular"},
                new TechnologyModel(){ TechnologyName = "JQuery"},
                new TechnologyModel(){ TechnologyName = "Javascript"},
            };
        }

        public IEnumerable<TechnologyModel> GetAllTechnologies()
        {
            var data = _technology.Select(f => new TechnologyModel()
            {
                TechnologyName = f.TechnologyName
            });
            return data;
            //return _technology;
        }
    }
}
