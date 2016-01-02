namespace Catharsium.Modules.Logging
{
    public interface ILogFactory
    {
        ILog ConsoleLog { get; }
    }
}