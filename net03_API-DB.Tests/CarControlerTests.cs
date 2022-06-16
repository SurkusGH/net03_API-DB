using AutoFixture.Xunit2;
using Moq;
using net03_API_DB.Controllers;
using net03_API_DB.Models;
using net03_API_DB.Repositories;
using System;
using System.Collections.Generic;
using Xunit;

namespace net03_API_DB.Tests
{
    public class CarControlerTests
    {
        [Theory, AutoData] // [Fact] means that test does not have any params
        public void CarControler_GetCarsByColor_Returns_Not_Found_When_Repository_Returns_Null(IEnumerable<Car> cars)
        {
            // Arrange
            var repositoryMock = new Mock<ICarRepository>();
            // Subject under test
            var sut = new CarController(repositoryMock.Object);
            repositoryMock.Setup(x => x.GetCarsByColor(It.IsAny<string>())).Returns(cars);
            sut.GetCarsByColor(It.IsAny<string>());
            //Act
            var response = sut.GetCarsByColor(It.IsAny<string>());
            //Assert
            Assert.Equal(cars, response);
        }
    }
}
