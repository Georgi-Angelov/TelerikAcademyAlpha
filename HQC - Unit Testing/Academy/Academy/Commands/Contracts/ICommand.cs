using System;
using System.Collections.Generic;

namespace Academy.Commands.Contracts
{
    public interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
