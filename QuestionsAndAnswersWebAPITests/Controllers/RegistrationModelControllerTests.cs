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
    public class RegistrationModelControllerTests
    {

        private readonly RegistrationModelsController _controller;
        private readonly IRegistrationService _service;

        public RegistrationModelControllerTests()
        {
            _service = new RegistrationServiceFake();
            _controller = new RegistrationModelsController(_service);
            
        }
        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetAllRegisteredUsers();
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }
        [Fact]
        public void Get_WhenCalled_ReturnAllRegistrations()
        {
            //Act
            var okResult = _controller.GetAllRegisteredUsers() as OkObjectResult;
            //Assert
            var items = Assert.IsType<List<RegistrationModel>>(okResult.Value);                
            Assert.Equal(3, items.Count);
        }
        [Fact]
        public void AddNewUsers_ShouldReturnSuccess()
        {
            //Arrange
            RegistrationModel testItem = new RegistrationModel()
            {                
                Username = "Ravi Kumar",
                Pwd = "ravi",
                ConfirmPassword = "ravi",
                Email = "ravi@gmail.com",
                YearsOfExperience = 1,
                Technology = "MVC"
            };            
            // Act
            IActionResult createdResponse = _controller.AddNewRegistrations(testItem);
            // Assert
            Assert.IsType<OkObjectResult>(createdResponse as OkObjectResult);
        }

        [Fact]
        public void Add_ValidObjectPassed_ReturnedResponseHasCreatedItem()
        {
            // Arrange
            var testItem = new RegistrationModel()
            {                
                Username = "Ravi Kumar",
                Pwd = "ravi",
                ConfirmPassword = "ravi",
                Email = "ravi@gmail.com",
                YearsOfExperience = 1,
                Technology = "MVC"
            };
            // Act
            OkObjectResult createdResponse = _controller.AddNewRegistrations(testItem) as OkObjectResult;
            RegistrationModel item = createdResponse.Value as RegistrationModel;
            // Assert
            Assert.IsType<RegistrationModel>(item);
            Assert.Equal("Ravi Kumar", item.Username);
        }
    }
}
