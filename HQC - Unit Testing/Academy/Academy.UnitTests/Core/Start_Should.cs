using Academy.Commands.Contracts;
using Academy.Core;
using Academy.Core.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy.UnitTests.Core.EngineTests
{
    [TestClass]
    public class Start_Should
    {
        [TestMethod]
        public void CallWriteMethodWithExceptionMessage_WhenExceptionIsThrown()
        {
            //Arrange
            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var commandProcessorMock = new Mock<ICommandProcessor>();
            var commandMock = new Mock<ICommand>();
            var databaseMock = new Mock<IDatabase>();
           
            var engine = new Engine(readerMock.Object,
                                    writerMock.Object, 
                                    commandProcessorMock.Object, 
                                    databaseMock.Object);

            string exceptionMessage = new Exception().Message;

            readerMock.SetupSequence(r => r.ReadLine())
               .Returns("This is not a valid command")
               .Returns("Exit");
            
            commandProcessorMock.Setup(p => p.ProcessCommand("This is not a valid command"))
                .Throws<Exception>();

            List<string> databaseList = new List<string>();
            databaseMock.SetupGet(d => d.LogResult)
                .Returns(databaseList);

            // Act
            engine.Start();

            // Assert
            Assert.AreEqual(exceptionMessage, databaseMock.Object.LogResult.Single());
        }
        [TestMethod]
        public void LogsCustomMessage_WhenInputIsValid()
        {
            //Arrange
            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var commandProcessorMock = new Mock<ICommandProcessor>();
            var commandMock = new Mock<ICommand>();
            var databaseMock = new Mock<IDatabase>();

            var engine = new Engine(readerMock.Object,
                                    writerMock.Object,
                                    commandProcessorMock.Object,
                                    databaseMock.Object);

            string exceptionMessage = new Exception().Message;

            readerMock.SetupSequence(r => r.ReadLine())
               .Returns("CreateSeason 2016 2017 SoftwareAcademy")
               .Returns("Exit");
              

            commandProcessorMock.Setup(p => p.ProcessCommand("CreateSeason 2016 2017 SoftwareAcademy")) 
                .Throws<Exception>();

            List<string> databaseList = new List<string>();
            databaseMock.SetupGet(d => d.LogResult)
                .Returns(databaseList);

            // Act
            engine.Start();

            // Assert
            Assert.AreEqual(exceptionMessage, databaseMock.Object.LogResult.Single());
        }
    }
}
