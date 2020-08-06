using LazyCreator.Engine;
using LazyCreator.Engine.Readers;
using LazyCreator.Engine.Writers;
using LazyCreator.Interpreters.ConsoleInterpreter;
using SimpleInjector;

namespace LazyCreator.Cli
{
    public static class StartUp
    {
        private static Container _container;

        public static Container ConfigureServices()
        {
            _container = new Container();

            _container.Register<IWriter, ConsoleWriter>();
            _container.Register<IReader, ConsoleReader>();
            _container.Register<IConsoleInterpreter, ConsoleInterpreter>();
            _container.Register<Engine.Engines.Engine>();
            _container.Verify();

            return _container;
        }
    }
}