using QuestionsAndAnswersDBContext.Models;
using QuestionsAndAnswersDBContext.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersDBContext.Services
{
    public class RegistrationDBService : IRegistrationDBService
    {
        private  QuestionsandAnswersDBContext _Dbcontext;

        public RegistrationDBService(QuestionsandAnswersDBContext Dbcontext)
        {
            _Dbcontext = Dbcontext;
        }

        public IEnumerable<Registration> GetAllRegistrations()
        {
            var registration = _Dbcontext.UserRegistrations
                .Select(f => new Registration
                {
                    UserId = f.UserId,
                    RoleId = f.RoleId,
                    Username = f.Username,
                    Pwd = f.Pwd,
                    ConfirmPassword = f.ConfirmPassword,
                    Email = f.Email,
                    YearsOfExperience = f.YearsOfExperience,
                    Technology = f.Technology
                }).ToList();

            return registration;
        }
        public Registration Add(Registration registrationModel)
        {
            _Dbcontext.UserRegistrations.Add(new Registration()
            {
                UserId =registrationModel.UserId,
                RoleId= registrationModel.RoleId,
                Username = registrationModel.Username,
                Pwd = registrationModel.Pwd,
                ConfirmPassword = registrationModel.ConfirmPassword,
                Email = registrationModel.Email,
                YearsOfExperience = registrationModel.YearsOfExperience,
                Technology = registrationModel.Technology
            });
            _Dbcontext.SaveChanges();
            return registrationModel;
        }
    }
}
