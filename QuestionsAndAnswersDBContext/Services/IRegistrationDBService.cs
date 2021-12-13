using QuestionsAndAnswersDBContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersDBContext.Services
{
    public interface IRegistrationDBService
    {
       public  IEnumerable<Registration> GetAllRegistrations();
       public  Registration Add(Registration registrationModel);
    }
}
