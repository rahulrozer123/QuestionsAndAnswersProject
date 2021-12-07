using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Services
{
    public interface IRegistrationService
    {
        IEnumerable<RegistrationModel> GetAllRegistrations();
        RegistrationModel Add(RegistrationModel registrationModel);
    }
}
