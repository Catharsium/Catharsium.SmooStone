using System;

namespace Catharsium.Modules.Logging
{
    public interface ILog
    {
        void Info(object data, object source);

        void Info(string data, object source);

        void Info(object data, Type source);

        void Info(string data, Type source);
    }
}