using System;
using System.IO;

namespace PastriesDelivery
{
    public class Logger : ILogger
    {
        private string fileName = "logger_" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";

        public void Log(string message)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + FileName;

            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{message} [{DateTime.Now:HH:mm}]");
            }
        }
    }
}