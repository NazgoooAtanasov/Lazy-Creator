namespace LazyCreator.Commands.ConsoleCommands.ApplicationVersionsCommands
{
    public class VersionCommand : IVersionCommand
    {
        public string Execute(string[] args) => "lazy-creator v1";
    }
}