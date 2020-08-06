namespace LazyCreator.Interpreters
{
    public interface IInterpreter
    {
        string ExecuteCommand(string[] args);
    }
}