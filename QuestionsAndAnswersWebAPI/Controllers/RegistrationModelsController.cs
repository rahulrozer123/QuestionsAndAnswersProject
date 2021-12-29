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
        

        public RegistrationModelsController(IRegistrationService service)
        {
            _service = service;
           
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
    }
}
