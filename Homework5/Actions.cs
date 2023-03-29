using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Actions
    {
        public Result StartMethod()
        {
            Logger.GetInstance().LoggerInfo("Start method");
            return new Result { Status = true };
        }

        public Result SkippedLogicInMethod()
        {
            Logger.GetInstance().LoggerWarning("Skipped logic in method");
            return new Result { Status = true };
        }

        public Result BrokeMethod()
        {
            Result result = new Result() { Status = false, ErrorMessage = "I broke a logic" };
            Logger.GetInstance().LoggerError($"Action failed by a reason: {result.ErrorMessage}");
            return result;
        }
    }
}
