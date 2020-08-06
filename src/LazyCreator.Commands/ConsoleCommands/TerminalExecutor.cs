using System.Diagnostics;

namespace LazyCreator.Commands.ConsoleCommands
{
    public static class TerminalExecutor
    {
        public static void Run(string program, string command)
        {
            var projectCreationInfo =
                new ProcessStartInfo(
                    program,
                    command
                );
            var projectCreationProcess = Process.Start(projectCreationInfo);
            projectCreationProcess.WaitForExit();
        }
    }
}