using LazyCreator.Interpreters;
using LazyCreator.Interpreters.ConsoleInterpreter;
using System;
using System.Collections.Generic;
using System.Text;

namespace LazyCreator.Engines.Engines
{
    public class DesktopEngine : IEngine
    {
        private readonly IInterpreter _interpreter;

        public DesktopEngine(IInterpreter interpreter)
        {
            this._interpreter = interpreter;
        }

        public void Run(params string[] arguments)
        {
            var result = this._interpreter.ExecuteCommand(arguments);
        }
    }
}
