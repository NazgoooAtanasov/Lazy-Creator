using System.Linq;

namespace LazyCreator.Commands.ConsoleCommands
{
    public static class ApplicationDefaults
    {
        public const string WindowsDefaultCommandLineProgram = "powershell.exe";

        private static string GetFileName(string[] path)
        {
            var argsSplit = path[0].Split('/').ToArray();
            return argsSplit[argsSplit.Length - 1];
        }

        public static string DotnetConsoleApplication(string[] args)
        {
            var file = GetFileName(args);
            return $"/C mkdir {args[0]};cd {args[0]};dotnet new console;dotnet new sln;dotnet sln add {args[0]}/{file}.csproj";
        }

        public static string DotnetWebApplication(string[] args)
        {
            var file = GetFileName(args);
            return $"/C mkdir {args[0]};cd {args[0]};dotnet new webapp;dotnet new sln; dotnet sln add {args[0]}/{file}.csproj";
        }

        public static string DotnetWebApi(string[] args)
        {
            var file = GetFileName(args);
            return $"/C mkdir {args[0]};cd {args[0]};dotnet new webapi;dotnet new sln;dotnet sln add {args[0]}/{file}.csproj";
        }

        public static string NodeExpApplication(string[] args) =>
            $"/C mkdir {args[0]};cd {args[0]};npm init;npm install express;echo $null >> index.js ";

        public static string SymfonyApplication(string[] args) =>
            $"/C symfony new --dir {args[0]}";
    }
}