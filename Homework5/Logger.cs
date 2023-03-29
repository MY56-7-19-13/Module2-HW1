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
             LoggerRecord loggerRecord = new LoggerRecord() { Type = LoggerType.Error };
             _logs.Add($"{loggerRecord.Date}; {loggerRecord.Type}: {text}");
             Console.WriteLine($"{loggerRecord.Date}; {loggerRecord.Type}: {text}");
        }

        public void LoggerInfo(string text)
        {
            LoggerRecord loggerRecord = new LoggerRecord() { Type = LoggerType.Info };
            _logs.Add($"{loggerRecord.Date}; {loggerRecord.Type}: {text}");
            Console.WriteLine($"{loggerRecord.Date}; {loggerRecord.Type}: {text}");
        }

        public void LoggerWarning(string text)
        {
            LoggerRecord loggerRecord = new LoggerRecord() { Type = LoggerType.Warning };
            _logs.Add($"{loggerRecord.Date}; {loggerRecord.Type}: {text}");
            Console.WriteLine($"{loggerRecord.Date}; {loggerRecord.Type}: {text}");
        }

        public string GetLogs()
        {
            return string.Join(Environment.NewLine, _logs);
        }
    }
}
