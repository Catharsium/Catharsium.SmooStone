﻿namespace Catharsium.Modules.Logging
{
    public interface ILog
    {
        void Info(object data, object source = null);
        void Info(string data, object source = null);
    }
}