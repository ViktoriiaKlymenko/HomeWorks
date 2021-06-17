using System;
using System.IO;

namespace PastriesDelivery
{
    public class Logger : ILogger
    {
        private string fileName = "logger_" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";

<<<<<<< HEAD:PastriesDelivery/Services/Logger.cs
        public void LogChanges(string message)
=======
        public void Log(string message)
>>>>>>> main:PastriesDelivery/Managers/Logger.cs
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + fileName;

            using (var writer = new StreamWriter(path, true))
            {
<<<<<<< HEAD:PastriesDelivery/Services/Logger.cs
                writer.WriteLine($"{message} [{DateTime.Now:HH:mm}]");
            }
        }

        public void CreateFile()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + FileName;

            using (var writer = new StreamWriter(path, true)) ;
        }
=======
                writer.WriteLine($"[{DateTime.Now:HH:mm}] {message}");
            }
        }
>>>>>>> main:PastriesDelivery/Managers/Logger.cs
    }
}