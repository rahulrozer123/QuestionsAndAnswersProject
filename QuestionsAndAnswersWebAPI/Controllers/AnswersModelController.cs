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
    public class AnswersModelController : ControllerBase
    {
        private readonly IAnswersService _service;

        public AnswersModelController(IAnswersService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("GetAnswers")]
        //Used to add data to db
        public IActionResult GetAnswersFromUser([FromBody] AnswersModel answersModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = _service.GetAnswersGivenByUser(answersModel);
            if (item == null)
            {
                return NoContent();
            }
            return Ok();
        }
        [HttpGet]
        [Route("GetResult")]
        public IActionResult GetResult(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = _service.GetResultByUserId(id);
            if (item.Count() == 0)
            {
                return NoContent();
            }
            return Ok(item);
        }
    }
}
