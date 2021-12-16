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
                Pwd = f.Pwd,
                ConfirmPassword = f.ConfirmPassword,
                Email = f.Email,
                YearsOfExperience = f.YearsOfExperience,
                Technology= f.Technology
            }).ToList();
            return data;
        }
        public RegistrationModel Add(RegistrationModel registrationModel)
        {
            //_dbContext.Add(registrationModel);
            //return registrationModel;
            _dbContext.Add(new Registration()
            {
                RoleId = registrationModel.RoleId,
                Username = registrationModel.Username,
                Email = registrationModel.Email,
                Pwd = registrationModel.Pwd,
                ConfirmPassword = registrationModel.ConfirmPassword,
                YearsOfExperience = registrationModel.YearsOfExperience,
                Technology = registrationModel.Technology
            });
            return registrationModel;
        }
    }
}
