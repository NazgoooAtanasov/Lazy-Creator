namespace LazyCreator.Commands.ConsoleCommands.ApplicationPHPCommands
{
    public class SymfonyCommand : ISymfonyCommand
    {
        public string Execute(string[] args)
        {
            TerminalExecutor.Run(
                ApplicationDefaults.WindowsDefaultCommandLineProgram,
                ApplicationDefaults.SymfonyApplication(args)
            );

            return null;
        }
    }
}