using QuestionsAndAnswersDBContext.Data;
using QuestionsAndAnswersDBContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersDBContext.Services
{
    public class TechnologyDBService : ITechnologyDBService
    {
        private  QuestionsandAnswersDBContext _Dbcontext;

        public TechnologyDBService(QuestionsandAnswersDBContext Dbcontext)
        {
            _Dbcontext = Dbcontext;
        }
        public IEnumerable<Technology> GetAllTechnologies()
        {
            var technologies = _Dbcontext.MasterTechnologies
                .Select(f => new Technology
                {
                    TechnologyId = f.TechnologyId,
                    TechnologyName = f.TechnologyName                    
                }).ToList();

            return technologies;
        }
    }
}
