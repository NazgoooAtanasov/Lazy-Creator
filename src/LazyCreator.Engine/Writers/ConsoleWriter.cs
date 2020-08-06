using System;

namespace LazyCreator.Engine.Writers
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string arg)
        {
            Console.WriteLine(arg);
        }
    }
}