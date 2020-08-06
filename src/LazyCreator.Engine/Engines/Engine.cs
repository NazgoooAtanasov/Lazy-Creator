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
            this._writer = writer;
            this._reader = reader;
            this._interpreter = interpreter;
        }

        public void Run()
        {
            while (true)
            {
                this._writer.Write("Command: ");
                // Separate method!
                var command = this._reader.Read().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var result = this._interpreter.ExecuteCommand(command);
                this._writer.Write(result);
            }
        }
    }
}