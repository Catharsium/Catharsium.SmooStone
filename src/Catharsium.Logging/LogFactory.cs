namespace Catharsium.Logging
{
    public class LogFactory : ILogFactory
    {
        public ILog GetConsoleLog()
        {
            return new TextWriterLog(System.Console.Out);
        }
    }
}