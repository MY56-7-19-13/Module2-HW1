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
        private readonly LoggerRecord _loggerRecord = new LoggerRecord();

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
            _logs.Add($"{_loggerRecord.Date}; {LoggerType.Error}: {text}");
            Console.WriteLine($"{_loggerRecord.Date}; {LoggerType.Error}: {text}");
        }

        public void LoggerInfo(string text)
        {
            _logs.Add($"{_loggerRecord.Date}; {LoggerType.Info}: {text}");
            Console.WriteLine($"{_loggerRecord.Date}; {LoggerType.Info}: {text}");
        }

        public void LoggerWarning(string text)
        {
            _logs.Add($"{_loggerRecord.Date}; {LoggerType.Warning}: {text}");
            Console.WriteLine($"{_loggerRecord.Date}; {LoggerType.Warning}: {text}");
        }

        public string GetLogs()
        {
            return string.Join(Environment.NewLine, _logs);
        }
    }
}
