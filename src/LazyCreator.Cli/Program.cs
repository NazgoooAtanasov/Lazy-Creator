namespace LazyCreator.Cli
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var container = StartUp.ConfigureServices();

            var engine = container.GetInstance<Engine.Engines.Engine>();

            engine.Run();
        }
    }
}