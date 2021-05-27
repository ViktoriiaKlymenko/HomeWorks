using System;
using System.Reflection;

namespace PastriesDelivery
{
    public interface ILogger
    {
        public void LogChanges(Type className, string changedProperties, string message);
        void CreateFile(string infoToWrite);
    }
}