using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswersDBContext.Models;
using QuestionsAndAnswersWebAPI.Models;
using QuestionsAndAnswersWebAPI.Services;

namespace QuestionsAndAnswersWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsAndAnswersModelsController : ControllerBase
    {
        private readonly IQuestionAndAnswerService _service;

        public QuestionsAndAnswersModelsController(IQuestionAndAnswerService service)
        {
            _service = service;
        }

        //GET: api/QuestionsAndAnswersModels
        [HttpGet]
        [Route("Get all the questions and options")]
        public IActionResult GetQuestionAndAnswer()
        {
            var questionAndAnswers = _service.GetAllQuestionsAndAnswers();
            if (questionAndAnswers == null)
            {
                return BadRequest();
            }
            return Ok(questionAndAnswers);
        }

        //GET: api/QuestionsAndAnswersModels/5
        //[HttpGet("{id}")]
        //public IActionResult GetQuestionsAndAnswersModel(int id)
        //{
        //    var questionsAndAnswersModel = _service.GetById(id);

        //    if (questionsAndAnswersModel == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(questionsAndAnswersModel);
        //}

        //GET: api/TechnologyModels/5
        [HttpGet]
        [Route("Get questions based on technology id")]
        public IActionResult GetTechnologyModel(int id)
        {
            var technologyModel = _service.GetQuestionsByTechnologyId(id);
            if (technologyModel == null)
            {
                return NotFound();
            }
            return Ok(technologyModel);
        }

        // PUT: api/QuestionsAndAnswersModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //Used to update the entries by id
        [HttpPut("{id}")]        
        public IActionResult PutQuestionsAndAnswersModel(QuestionsAndAnswers questionsAndAnswersModel)
        {                     
            try
            {
                _service.Update(questionsAndAnswersModel);
                return Ok();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();                
            }            
        }

        // POST: api/QuestionsAndAnswersModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // [HttpPost]
        //Used to add data to db
        //public IActionResult PostQuestionsAndAnswersModel([FromBody] QuestionsAndAnswersModel questionsAndAnswersModel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var item = _service.Add(questionsAndAnswersModel);
        //    if(item == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok();
        //}

        // DELETE: api/QuestionsAndAnswersModels/5
        //[HttpDelete("{id}")]
        //public IActionResult DeleteQuestionsAndAnswersModel(int id)
        //{
        //    //var questionsAndAnswersModel = await _context.QuestionAndAnswer.FindAsync(id);
        //    _service.Delete(id);                      
        //    return NoContent();
        //}

        //private bool QuestionsAndAnswersModelExists(int id)
        //{
        //    return _context.QuestionAndAnswer.Any(e => e.QuestionID == id);
        //}
        //GET: api/QuestionsAndAnswersModels
        
    }
}
