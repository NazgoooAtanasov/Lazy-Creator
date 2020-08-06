namespace LazyCreator.Interpreters.ConsoleInterpreter
{
    public interface IConsoleInterpreter : IInterpreter
    {
        string GetCommandOutOfRawStringArray(string[] rawInput);
    }
}