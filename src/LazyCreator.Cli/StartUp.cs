using LazyCreator.Engines;
using LazyCreator.Engines.Engines;
using LazyCreator.Engines.Readers;
using LazyCreator.Engines.Writers;
using LazyCreator.Interpreters;
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
            _container.Register<IInterpreter, Interpreter>();
            _container.Register<ConsoleEngine>();
            _container.Verify();

            return _container;
        }
    }
}