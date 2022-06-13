using AutoFixture.Xunit2;
using Moq;
using net03_API_DB.Controllers;
using net03_API_DB.Models;
using net03_API_DB.Repositories;
using System;
using Xunit;

namespace net03_API_DB.Tests
{
    public class CarControlerTests
    {
        [Theory, AutoData] // Fact reiðkia, kad testas neturi param
        public void CarControler_GetCarByID_Returns_Not_Found_When_Repository_Returns_Null(Car car)
        {
            // Arrange
            var repositoryMock = new Mock<ICarRepository>();

            // Subject under test
            var sut = new CarController(repositoryMock.Object);
            repositoryMock.Setup(x => x.GetCarsByColor(It.IsAny<string>())).Returns((System.Collections.Generic.IEnumerable<Car>)car);
            sut.GetCarsByColor(It.IsAny<string>());

            //Act
            var response = sut.GetCarsByColor(It.IsAny<string>());
            //Assert
            Assert.Equal((System.Collections.Generic.IEnumerable<Car>)car, response);
        }
    }
}
