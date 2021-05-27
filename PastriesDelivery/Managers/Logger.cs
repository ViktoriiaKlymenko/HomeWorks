using System;
using System.IO;

namespace PastriesDelivery
{
    public class Logger : ILogger
    {
        public string FileName { get; set; }

        public void LogChanges(Type className, string changedProperties, string message)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + FileName;

            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"Changes occurred in the storage [{storageType}] in [{className}]: {changedProperties} {message} [{DateTime.Now:HH:mm}]");
            }
        }

        public void CreateFile(string infoToWrite)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + FileName;

            using (var writer = new StreamWriter(path, true));
        }
    }
}
