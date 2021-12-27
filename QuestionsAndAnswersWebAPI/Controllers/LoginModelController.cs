using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using QuestionsAndAnswersDBContext.Data;
using QuestionsAndAnswersDBContext.Models;
using QuestionsAndAnswersWebAPI.Models;
using QuestionsAndAnswersWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginModelController : ControllerBase
    {
        private readonly ILoginService _service;
        //private readonly QuestionsandAnswersDBContext _dbContext;
       // Answers answers = new Answers();
        
        public LoginModelController(ILoginService service/*, QuestionsandAnswersDBContext dbContext*/)
        {
            _service = service;
            //_dbContext = dbContext;
        }
        
        
    }
}
