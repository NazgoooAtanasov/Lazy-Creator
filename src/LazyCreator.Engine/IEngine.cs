namespace LazyCreator.Engines
{
    public interface IEngine
    {
        public void Run(params string[]? arguments);
    }
}