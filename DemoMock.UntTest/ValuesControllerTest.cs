using DemoMock.Controllers;
using DemoMock.Models;
using DemoMock.Repository;
using DemoMock.UntTest.MockData;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace DemoMock.UntTest
{
    public class ValuesControllerTest
    {
        [Fact]
        public void Index_ReturnsActionResult_ListOfEmployees()
        {
            //Arrange
            var mockRepo = new Mock<IEmployeeRepository>();
            mockRepo.Setup(x => x.GetEmployees()).Returns(EmployeeData.GetEmployeeModels());

            var controller = new ValuesController(mockRepo.Object);

            //Act
            var result = controller.GetEmployees();

            //Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var model = Assert.IsAssignableFrom<List<EmployeeModel>>(okResult.Value);
            Assert.Equal(3, model.Count);
        }

        [Fact]
        public void Index_ReturnsActionResult_SingleEmployee()
        {
            int id = 1;
            //Arrange
            var mockRepo = new Mock<IEmployeeRepository>();
            mockRepo.Setup(x => x.GetEmployee(It.IsAny<int>())).Returns(EmployeeData.GetEmployee(id));

            var controller = new ValuesController(mockRepo.Object);

            //Act
            var result = controller.GetEmployee(id);

            //Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var model = Assert.IsAssignableFrom<EmployeeModel>(okResult.Value);
            
        }
    }
}
