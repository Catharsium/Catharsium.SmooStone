using System;
using System.IO;

namespace Catharsium.Logging
{
    public class TextWriterLog : ILog
    {
        public TextWriter TextWriter {get;set;}

        public TextWriterLog(TextWriter textWriter)
        {
            TextWriter = textWriter;
        }


        public void Info(string data, object sender)
        {
            TextWriter.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd (HH:mm:ss)")} > {sender.GetType().FullName}: {data}");
        }
    }
}