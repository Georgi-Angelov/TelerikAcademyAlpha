using Academy.Commands.Contracts;
using Academy.Core.Providers;
using Academy.Utils;
using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Commands.Decorator
{
    public class LogConsoleCommandDecorator : ICommand
    {
        private IDateTimeProvider dateTimeProvider;
        private ICommand command;

        public LogConsoleCommandDecorator(IDateTimeProvider dateTimeProvider, ICommand command)
        {
            Guard.WhenArgument(dateTimeProvider, "dateTimeProvider").IsNull().Throw();
            Guard.WhenArgument(command, "command").IsNull().Throw();

            this.dateTimeProvider = dateTimeProvider;
            this.command = command;

        }

        public string Execute(IList<string> parameters)
        {
            Console.WriteLine($"{this.command.GetType().Name} is called at {this.dateTimeProvider.DateTimeNow()}!");
            return this.command.Execute(parameters);
        }
    }
}
