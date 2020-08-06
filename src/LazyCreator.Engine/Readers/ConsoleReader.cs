using System;

namespace LazyCreator.Engine.Readers
{
    public class ConsoleReader : IReader
    {
        public string Read() => Console.ReadLine();
    }
}