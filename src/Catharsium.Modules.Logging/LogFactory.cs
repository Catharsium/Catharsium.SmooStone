namespace Catharsium.Modules.Logging
{
    public class LogFactory : ILogFactory
    {
        public ILog ConsoleLog { get; } = new TextWriterLog(System.Console.Out);
    }
}