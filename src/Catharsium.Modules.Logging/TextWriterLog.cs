using System;
using System.IO;

namespace Catharsium.Modules.Logging
{
    public class TextWriterLog : ILog
    {
        #region Properties

        public TextWriter TextWriter { get; set; }

        #endregion

        #region Construction

        public TextWriterLog(TextWriter textWriter)
        {
            TextWriter = textWriter;
        }

        #endregion


        #region ILog

        public void Info(object data, object source)
        {
            if (source != null) Info(data.ToString(), source.GetType());
        }


        public void Info(string data, object source)
        {
            Info(data, source.GetType());
        }


        public void Info(object data, Type source = null)
        {
            Info(data.ToString(), source);
        }


        public void Info(string data, Type source = null)
        {
            var sourceText = source != null
                       ? string.Format($" [{source.FullName}]")
                       : string.Empty;
            TextWriter.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd (HH:mm:ss)")}{sourceText}: {data}");
        }

        #endregion
    }
}