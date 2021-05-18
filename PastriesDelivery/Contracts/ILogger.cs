using System;
using System.Reflection;

namespace PastriesDelivery
{
    public interface ILogger
    {
        public void LogChanges(StorageType storageType, Type className, string changedProperties, string message);
        void CreateFile(string infoToWrite);
    }
}