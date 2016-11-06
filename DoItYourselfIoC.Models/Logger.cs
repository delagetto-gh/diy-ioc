using DoItYourselfIoC.Models.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.IO;

namespace DoItYourselfIoC.Models
{
    public class DebugLogger : ILogger
    {
        public void Log(string message)
        {
            Debug.WriteLine(message);
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using (var file = new FileStream(@"C:\ConsoleLoggerLog.txt", FileMode.Create))
            {
                var msgAsBytes = message.Select(o => Convert.ToByte(o));
                file.Write(msgAsBytes.ToArray(), 0, message.Length);
            }
        }
    }
}
