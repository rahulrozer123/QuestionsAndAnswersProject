using Microsoft.AspNetCore.Mvc;
using QuestionsAndAnswersDBContext.Models;
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
    public class QuestionsAndAnswersModelControllerTests
    {
        private readonly QuestionsAndAnswersModelsController _controller;
        private readonly IQuestionAndAnswerService _service;

        public QuestionsAndAnswersModelControllerTests()
        {
            _service = new QuestionsAndAnswersServiceFake();
            _controller = new QuestionsAndAnswersModelsController(_service);

        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            //Act
            var okResult = _controller.GetQuestionAndAnswer();
            //Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }
        [Fact]
        public void Get_AlltheQuestionsAndAnswers()
        {
            var okResult = _controller.GetQuestionAndAnswer() as OkObjectResult;
            //Assert
            var items = Assert.IsType<List<QuestionsAndAnswersModel>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
        //[Fact]
        //public void GetByTechnologyId_UnknownTechnologyIdPassed_ReturnsNotFoundResult()
        //{
        //    //Arrange
        //    //var controller = new QuestionsAndAnswersModelsController(_service);
        //    var testId = 6;
        //    //Act
        //    IActionResult notFoundResult = _controller.GetTechnologyModel(testId);
        //    //Assert
        //    Assert.IsType<NotFoundObjectResult>(notFoundResult);
        //}
        [Fact]
        public void GetByTechnologyId_ExistingIdPassed_ReturnsOkResult()
        {
            // Arrange
            var testId = 1;
            // Act
            var okResult = _controller.GetTechnologyModel(testId);
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }
    }
}
