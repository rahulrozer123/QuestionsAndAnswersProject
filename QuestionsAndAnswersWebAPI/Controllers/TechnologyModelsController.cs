using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswersWebAPI.Data;
using QuestionsAndAnswersWebAPI.Models;
using QuestionsAndAnswersWebAPI.Services;

namespace QuestionsAndAnswersWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyModelsController : ControllerBase
    {
        private readonly ITechnologyService _service;

        public TechnologyModelsController(ITechnologyService service)
        {
            _service = service;
        }

        // GET: api/TechnologyModels
        [HttpGet]
        public IActionResult GetTechnologies()
        {
            var technologies = _service.GetAllTechnologies();
            return Ok(technologies);
        }      
    }
}
