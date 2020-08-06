namespace LazyCreator.Commands.ConsoleCommands.ApplicationNPMCommands
{
    public class NodeExpCommand : INodeExpCommand
    {
        public string Execute(string[] args)
        {
            TerminalExecutor.Run(
                ApplicationDefaults.LinuxDefaultShell,
                ApplicationDefaults.NodeExpApplication(args));

            return null;
        }
    }
}