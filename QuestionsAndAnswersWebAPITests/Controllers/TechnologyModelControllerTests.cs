using Microsoft.AspNetCore.Mvc;
using QuestionsAndAnswersWebAPI.Controllers;
using QuestionsAndAnswersWebAPI.Models;
using QuestionsAndAnswersWebAPI.Services;
using QuestionsAndAnswersWebAPITests.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace QuestionsAndAnswersWebAPITests.Controllers
{
    public class TechnologyModelControllerTests 
    {

        private readonly TechnologyModelsController _controller;
        private readonly ITechnologyService _technologyService;

        public TechnologyModelControllerTests()
        {
            _technologyService = new TechnologyServiceFake();
            _controller = new TechnologyModelsController(_technologyService);
           
        }
        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetTechnologies();
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }             
    }
}
