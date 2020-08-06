namespace LazyCreator.Commands.ConsoleCommands.ApplicationPHPCommands
{
    public class SymfonyCommand : ISymfonyCommand
    {
        public string Execute(string[] args)
        {
            TerminalExecutor.Run(
                ApplicationDefaults.LinuxDefaultShell,
                ApplicationDefaults.SymfonyApplication(args)
            );

            return null;
        }
    }
}