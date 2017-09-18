using Academy.Core.Contracts;
using Academy.Models.Contracts;
using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandProcessor commandProcessor;
        private readonly IDatabase database;
        
        private const string TerminationCommand = "Exit";
        private const string NullProvidersExceptionMessage = "cannot be null.";

        public Engine(IReader reader, IWriter writer, ICommandProcessor commandProcessor, IDatabase database)
        {
            Guard.WhenArgument(reader, "reader" ).IsNull().Throw();
            Guard.WhenArgument(writer, "writer").IsNull().Throw();
            Guard.WhenArgument(commandProcessor, "commandProcessor").IsNull().Throw();
            Guard.WhenArgument(database, "database").IsNull().Throw();

            this.reader = reader;
            this.writer = writer;
            this.commandProcessor = commandProcessor;
            this.database = database;
        }
        
        public void Start()
        {
            
            while (true)
            {
                try
                {
                    var commandAsString = this.reader.ReadLine();

                    if (commandAsString == TerminationCommand)
                    {
                        this.writer.Write(string.Join("\n", this.database.LogResult));
                        break;
                    }

                    string executeCommand = this.commandProcessor.ProcessCommand(commandAsString);
                    this.database.LogResult.Add(executeCommand);

                }
                catch (ArgumentOutOfRangeException)
                {
                    this.database.LogResult.Add("Invalid command parameters supplied or the entity with that ID for does not exist.");
                }
                catch (Exception ex)
                {
                    this.database.LogResult.Add(ex.Message);
                }
            }
        }

       
    }
}
