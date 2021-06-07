using System;
using System.IO;

namespace PastriesDelivery
{
    public class Logger : ILogger
    {
        private string FileName { get; set; }

        public void Log(string message)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + FileName;

            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{message} [{DateTime.Now:HH:mm}]");
            }
        }

        public void CreateFile()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + FileName;

            using (var writer = new StreamWriter(path, true)) ;
        }
    }
}