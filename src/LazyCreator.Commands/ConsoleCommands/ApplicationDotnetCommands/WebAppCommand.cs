namespace LazyCreator.Commands.ConsoleCommands.ApplicationDotnetCommands
{
    public class WebAppCommand : IDotnetCommand
    {
        public string Execute(string[] args)
        {
            TerminalExecutor.Run(
                ApplicationDefaults.WindowsDefaultCommandLineProgram, 
                ApplicationDefaults.DotnetWebApplication(args));
            return null;
        }
    }
}