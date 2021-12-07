using QuestionsAndAnswersWebAPI.Data;
using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly RegistrationContext _context;

        public RegistrationService(RegistrationContext context)
        {
            _context = context;
        }

        public IEnumerable<RegistrationModel> GetAllRegistrations()
        {
            return _context.UserRegistration.ToList();
        }
        public RegistrationModel Add(RegistrationModel registrationModel)
        {
            _context.UserRegistration.Add(new RegistrationModel()
            {
                UserId =registrationModel.UserId,
                RoleId= registrationModel.RoleId,
                Username= registrationModel.Username,
                Pwd=registrationModel.Pwd,
                ConfirmPassword=registrationModel.ConfirmPassword,
                Email=registrationModel.Email,
                YearsOfExperience = registrationModel.YearsOfExperience,
                Technology = registrationModel.Technology
            }) ;
            _context.SaveChanges();

            return registrationModel;
        }
    }
}
