using System;
using System.Linq;
using LazyCreator.Interpreters.ConsoleInterpreter;

namespace LazyCreator.Engine.Engines
{
    public class Engine : IEngine
    {
        private readonly IConsoleInterpreter _interpreter;
        private readonly IReader _reader;
        private readonly IWriter _writer;

        public Engine(IWriter writer, IReader reader, IConsoleInterpreter interpreter)
        {
            _writer = writer;
            _reader = reader;
            _interpreter = interpreter;
        }

        public void Run()
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

        public void Stop()
        {
            Environment.Exit(0);
        }
    }
}