using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestionsAndAnswersDBContext.Models;
using QuestionsAndAnswersWebAPI.Models;
using QuestionsAndAnswersWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationModelsController : ControllerBase
    {
        private readonly IRegistrationService _service;
        private readonly ILoginService _loginService;

        public RegistrationModelsController(IRegistrationService service,  ILoginService loginService)
        {
            _service = service;
            _loginService = loginService;
        }

        //GET: api/RegistraionModels
        [HttpGet]
        public IActionResult GetAllRegisteredUsers()
        {
            var registrations = _service.GetAllRegistrations();
            if(registrations == null)
            {
                return NoContent();
            }
            return Ok(registrations);
        }

        // POST: api/RegistraionModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]        
        //Used to add data to db
        public IActionResult AddNewRegistrations([FromBody] RegistrationModel registrationModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = _service.Add(registrationModel);
            if (item == null)
            {
                return NoContent();
            }
            return Ok(item);
        }

        [HttpPost]
        [Route("Login module")]
        public IActionResult GetLoginDetails([FromBody] LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = _loginService.ValidateUserLogin(loginModel);

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
