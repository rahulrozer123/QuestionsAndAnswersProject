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
        private readonly QuestionsandAnswersDBContext _dbContext;       
        
        public LoginModelController(ILoginService service, QuestionsandAnswersDBContext dbContext)
        {
            _service = service;
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("Loginmodule")]
        public IActionResult GetLoginDetails([FromBody] LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {                
                var item = _service.ValidateUserLogin(loginModel);
                if (item != null)
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Logged in successfully"
                    });
                }
                else
                {
                    return NotFound(new
                    {
                        StatusCode = 404,
                        Message = "User not found"
                    });
                }
            }
            
        }
    }
}
