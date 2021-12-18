using QuestionsAndAnswersDBContext.Models;
using QuestionsAndAnswersDBContext.Services;
using QuestionsAndAnswersWebAPI.Models;
using QuestionsAndAnswersWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPITests.Services
{
    public class RegistrationServiceFake : IRegistrationService
    {
        private readonly IList<RegistrationModel> _register;

        public RegistrationServiceFake()
        {
            _register = new List<RegistrationModel>()
            {
                new RegistrationModel(){ Username = "Raju",Pwd = "password",ConfirmPassword = "password",
                    Email = "santosh@gmail.com",YearsOfExperience = 1,Technology = "MVC"},
                new RegistrationModel(){ Username = "Elten",Pwd = "password",ConfirmPassword = "password",
                    Email = "elten@gmail.com",YearsOfExperience = 2,Technology = "ASP"},
                new RegistrationModel(){ Username = "Dinesh",Pwd = "password",ConfirmPassword = "password",
                    Email = "Dinesh@gmail.com",YearsOfExperience = 0,Technology = "None"},
            };
        }

        public IEnumerable<RegistrationModel> GetAllRegistrations()
        {            
            return _register;
        }

        public RegistrationModel Add(RegistrationModel newItem)
        {                        
            _register.Add(newItem);
            return newItem;
        }

    }
}
