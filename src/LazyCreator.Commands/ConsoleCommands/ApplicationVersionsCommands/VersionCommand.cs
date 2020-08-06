namespace LazyCreator.Commands.ConsoleCommands.ApplicationVersionsCommands
{
    public class VersionCommand : IVersionCommand
    {
        public string Execute(string[] args)
        {
            return "lazy-creator v1";
        }
    }
}