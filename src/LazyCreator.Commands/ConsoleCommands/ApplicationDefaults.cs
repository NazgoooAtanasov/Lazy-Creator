namespace LazyCreator.Commands.ConsoleCommands
{
    public static class ApplicationDefaults
    {
        public const string LinuxDefaultShell = "/bin/bash";

        public static string DotnetConsoleApplication(string[] args) =>
            $"-c \"mkdir {args[0]};cd {args[0]};dotnet new console;dotnet new sln;dotnet sln add *.csproj\"";
        
        public static string DotnetWebApplication(string[] args) =>
            $"-c \"mkdir {args[0]};cd {args[0]};dotnet new webapp;dotnet new sln;dotnet sln add *.csproj\"";
        
        public static string DotnetWebApi(string[] args) =>
            $"-c \"mkdir {args[0]};cd {args[0]};dotnet new webapi;dotnet new sln;dotnet sln add *.csproj\"";

        public static string NodeExpApplication(string[] args) =>
            $"-c \"mkdir {args[0]};cd {args[0]};npm init;npm install express;touch index.js \"";

        public static string SymfonyApplication(string[] args) =>
            $"-c \"symfony new --dir {args[0]}\"";
    }
}