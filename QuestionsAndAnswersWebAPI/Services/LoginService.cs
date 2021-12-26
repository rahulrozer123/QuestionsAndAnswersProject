using QuestionsAndAnswersDBContext.Data;
using QuestionsAndAnswersDBContext.Models;
using QuestionsAndAnswersDBContext.Services;
using QuestionsAndAnswersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Services
{
    public class LoginService : ILoginService
    {
        private readonly QuestionsandAnswersDBContext _dbContext;
        
        public LoginService(QuestionsandAnswersDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public LoginModel ValidateUserLogin(LoginModel login)
        {
            var obj =_dbContext.UserRegistrations.Where(a => a.Username == login.UserName & a.Pwd == login.Password).FirstOrDefault();
            if(obj == null)
            {
                return null;
            }
            return login;
        }       
    }
}
