using QuestionsAndAnswersDBContext.Data;
using QuestionsAndAnswersDBContext.Models;
using QuestionsAndAnswersDBContext.Services;
using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Services
{
    public class LoginService : ILoginService
    {
        private readonly QuestionsandAnswersDBContext _dbContext;
        Answers answers = new Answers();
        public LoginService(QuestionsandAnswersDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public LoginModel GetUserId(LoginModel login)
        {
            var obj = _dbContext.UserRegistrations.Where(a => a.Username == login.UserName & a.Pwd == login.Password).FirstOrDefault();
            answers.UserId = obj.UserId;
            return login;
        }
    }
}
