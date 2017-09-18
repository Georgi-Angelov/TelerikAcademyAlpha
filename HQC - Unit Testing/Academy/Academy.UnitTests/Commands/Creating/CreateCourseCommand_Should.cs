using Academy.Commands.Contracts;
using Academy.Commands.Creating;
using Academy.Core;
using Academy.Core.Contracts;
using Academy.Models;
using Academy.Models.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy.UnitTests.Core
{
    [TestClass]
    public class CreateCourseCommand_Should
    {
        [TestMethod]
        public void ThrowExceptionMessage_WhenGivenInvalidInput()
        {
            //Arrange
            var seasonMock = new Mock<ISeason>();
            var databaseMock = new Mock<IDatabase>();
            var factoryMock = new Mock<IAcademyFactory>();

            var seasonId = "0";
            var name = "Javascript";
            var lecturesPerWeek = "3";
            var startingDate = "2017/07/12";

            var course = new Course(name, int.Parse(lecturesPerWeek), DateTime.Parse(startingDate), DateTime.Parse(startingDate).AddDays(30));

            var databaseSeasons = new List<ISeason>() { seasonMock.Object };
            var seasonCourses = new List<ICourse>();
            var parametersList = new List<string>()
            {
                seasonId,
                name,
                lecturesPerWeek,
                startingDate
            };

            seasonMock.SetupGet(s => s.Courses)
                .Returns(seasonCourses);

            databaseMock.SetupGet(d => d.Seasons)
                .Returns(databaseSeasons);

            factoryMock.Setup(f => f.CreateCourse(name, lecturesPerWeek, startingDate))
                .Returns(course);

            var createCourseCommand = new CreateCourseCommand(factoryMock.Object, databaseMock.Object);

            string expectedsuccessMessage = "Course with ID 0 was created in Season 0.";

            // Act
            string successMessage = createCourseCommand.Execute(parametersList);

            // Assert
            Assert.AreEqual(course, seasonMock.Object.Courses.Single());
            Assert.AreEqual(expectedsuccessMessage, successMessage);
        }
    
    }
}
