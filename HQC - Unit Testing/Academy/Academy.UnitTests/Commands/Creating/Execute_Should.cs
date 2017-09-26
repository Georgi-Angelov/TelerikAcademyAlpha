using Academy.Core.Contracts;
using Academy.Models.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.UnitTests.Commands.Creating
{
    [TestClass]
    public class Execute_Should
    {
        [TestMethod]
        public void ReturnTextRepresentingUsers_WhenParametersAreCorrect()
        {
            var factoryMock = new Mock<IAcademyFactory>();
            var databaseMock = new Mock<IDatabase>();
            var firstSeasonMock = new Mock<ISeason>();
            var secondSeasonMock = new Mock<ISeason>();

            List<ISeason> seasons = new List<ISeason>()
            {
                firstSeasonMock.Object,
                secondSeasonMock.Object
            };

            string expectedResult = "listing users";

            databaseMock.SetupGet(m => m.Seasons).Returns(seasons);


        }
    }
}
