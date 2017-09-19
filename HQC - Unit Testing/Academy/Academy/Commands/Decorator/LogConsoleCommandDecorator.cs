using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using Academy.Utils;
using Bytes2you.Validation;
using System;
using System.Collections.Generic;

namespace Academy.Commands.Decorator
{
    public class LogConsoleCommandDecorator : ICommand
    {
        private IDateTimeProvider dateTimeProvider;
        private ICommand command;
        private IWriter writer;

        public LogConsoleCommandDecorator(IDateTimeProvider dateTimeProvider, ICommand command, IWriter writer)
        {
            Guard.WhenArgument(dateTimeProvider, "dateTimeProvider").IsNull().Throw();
            Guard.WhenArgument(command, "command").IsNull().Throw();
            Guard.WhenArgument(writer, "writer").IsNull().Throw();
            
            this.dateTimeProvider = dateTimeProvider;
            this.command = command;
            this.writer = writer;

        }

        public string Execute(IList<string> parameters)
        {
            this.writer.Write(($"{this.command.GetType().Name} is called at {this.dateTimeProvider.DateTimeNow()}!"));
            return this.command.Execute(parameters);
        }
    }
}
