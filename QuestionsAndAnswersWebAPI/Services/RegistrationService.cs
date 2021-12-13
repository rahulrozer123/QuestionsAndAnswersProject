using QuestionsAndAnswersDBContext.Models;
using QuestionsAndAnswersDBContext.Services;
using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRegistrationDBService _dbContext;

        public RegistrationService(IRegistrationDBService dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<RegistrationModel> GetAllRegistrations()
        {
            var data= _dbContext.GetAllRegistrations()
                .Select(f=> new RegistrationModel()
                {
                Username = f.Username,
                Email = f.Email,
                YearsOfExperience = f.YearsOfExperience,
                Technology= f.Technology
            }).ToList();
            return data;
        }
        public Registration Add(Registration registrationModel)
        {
            _dbContext.Add(registrationModel);
            return registrationModel;
        }
    }
}
