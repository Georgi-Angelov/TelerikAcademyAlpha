using Academy.Commands.Creating;
using Academy.Core.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Academy.UnitTests.Commands.Creating
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void CreateCourseCommand_WhenAParametersAreCorrect()
        {
            //Arrange
            var factoryMock = new Mock<IAcademyFactory>();
            var databaseMock = new Mock<IDatabase>();

            //Act
            var createCourseCommmand = new CreateCourseCommand(factoryMock.Object, databaseMock.Object);

            //Assert
            Assert.IsNotNull(createCourseCommmand);
        }

        [TestMethod]
        public void ThrowExceptionMessage_WhenDatabaseIsNull()
        {
            //Arrange
            var factoryMock = new Mock<IAcademyFactory>();

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new CreateCourseCommand(factoryMock.Object, null));

        }
        [TestMethod]
        public void ThrowExceptionMessage_WhenFactoryIsNull()
        {
            //Arrange
            var database = new Mock<IDatabase>();

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new CreateCourseCommand(null, database.Object));

        }
    }
}
