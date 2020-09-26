using System;

namespace LazyCreator.Engines.Readers
{
    public class ConsoleReader : IReader
    {
        public string Read() => Console.ReadLine();
    }
}