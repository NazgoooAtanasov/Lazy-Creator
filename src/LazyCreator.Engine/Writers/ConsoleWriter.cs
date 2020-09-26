using System;

namespace LazyCreator.Engines.Writers
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string arg)
        {
            Console.WriteLine(arg);
        }
    }
}