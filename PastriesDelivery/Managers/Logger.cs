using System;
using System.IO;

namespace PastriesDelivery
{
    public class Logger : ILogger
    {
        private string fileName = "logger_" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";

        public void Log(string message)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + fileName;

            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"[{DateTime.Now:HH:mm}] {message}");
            }
        }
    }
}