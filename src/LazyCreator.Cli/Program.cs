using LazyCreator.Engines.Engines;

namespace LazyCreator.Cli
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var container = StartUp.ConfigureServices();

            var engine = container.GetInstance<ConsoleEngine>();

            engine.Run();
        }
    }
}