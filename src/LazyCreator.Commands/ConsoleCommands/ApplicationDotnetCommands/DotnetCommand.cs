using System.Diagnostics;

namespace LazyCreator.Commands.ConsoleCommands.ApplicationDotnetCommands
{
    public class DotnetCommand : IDotnetCommand
    {
        private const string LINUX_DEFAULT_SHELL = "/bin/bash";

        public string Execute(string[] args)
        {
            var projectCreationInfo =
                new ProcessStartInfo(
                    LINUX_DEFAULT_SHELL,
                    $"-c \"mkdir {args[0]};" +
                    $"cd {args[0]};" +
                    "dotnet new console;" +
                    "dotnet new sln;" +
                    "dotnet sln add *.csproj\"");
            var projectCreationProcess = Process.Start(projectCreationInfo);
            projectCreationProcess.WaitForExit();

            return null;
        }
    }
}