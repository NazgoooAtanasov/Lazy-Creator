namespace LazyCreator.Commands
{
    public interface ICommand
    {
        string Execute(string[] args);
    }
}