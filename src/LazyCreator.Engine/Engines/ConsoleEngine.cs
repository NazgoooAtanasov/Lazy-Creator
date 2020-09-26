using System;
using System.Linq;
using LazyCreator.Interpreters;
using LazyCreator.Interpreters.ConsoleInterpreter;

namespace LazyCreator.Engines.Engines
{
    public class ConsoleEngine : IEngine
    {
        private readonly IInterpreter _interpreter;
        private readonly IReader _reader;
        private readonly IWriter _writer;

        public ConsoleEngine(IWriter writer, IReader reader, IInterpreter interpreter)
        {
            _writer = writer;
            _reader = reader;
            _interpreter = interpreter;
        }

        public void Run(params string[] args) 
        {
            while (true)
            {
                _writer.Write("Command: ");
                // Separate method!
                var command = _reader.Read().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var result = _interpreter.ExecuteCommand(command);
                _writer.Write(result);
            }
        }
    }
}