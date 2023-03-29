using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Logger
    {
        private static Logger? _instance;
        private readonly List<string> _logs = new List<string>();

        private Logger()
        {
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }

            return _instance;
        }

        public void LoggerError(string text)
        {
            _logs.Add($"{DateTime.Now}; {LoggerType.Error}: {text}");
            Console.WriteLine($"{DateTime.Now}; {LoggerType.Error}: {text}");
        }

        public void LoggerInfo(string text)
        {
            _logs.Add($"{DateTime.Now}; {LoggerType.Info}: {text}");
            Console.WriteLine($"{DateTime.Now}; {LoggerType.Info}: {text}");
        }

        public void LoggerWarning(string text)
        {
            _logs.Add($"{DateTime.Now}; {LoggerType.Warning}: {text}");
            Console.WriteLine($"{DateTime.Now}; {LoggerType.Warning}: {text}");
        }

        public string GetLogs()
        {
            return string.Join(Environment.NewLine, _logs);
        }
    }
}
