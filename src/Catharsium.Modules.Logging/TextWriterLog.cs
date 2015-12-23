using System;
using System.IO;

namespace Catharsium.Modules.Logging
{
    public class TextWriterLog : ILog
    {
        public TextWriter TextWriter {get;set;}

        public TextWriterLog(TextWriter textWriter)
        {
            TextWriter = textWriter;
        }


        public void Info(string data, object source = null)
        {
            var sourceText = source != null
                       ? string.Format($" [{source.GetType().FullName}]")
                       : string.Empty;
            TextWriter.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd (HH:mm:ss)")}{sourceText}: {data}");
        }


        public void Info(object data, object source = null)
        {
            Info(data.ToString(), source);
        }
    }
}