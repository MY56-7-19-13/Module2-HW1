using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Starter
    {
        private readonly Actions _actions = new Actions();
        private readonly Random _rand = new Random();
        public void Run()
        {
            for (int i = 1; i < 100; i++)
            {
                int action = _rand.Next(1, 4);
                switch (action)
                {
                    case 1:
                        _actions.StartMethod();
                        break;
                    case 2:
                        _actions.SkippedLogicInMethod();
                        break;
                    case 3:
                        _actions.BrokeMethod();
                        break;
                }
            }

            string log = Logger.GetInstance().GetLogs();
            File.WriteAllText("log.txt", log);
        }
    }
}
