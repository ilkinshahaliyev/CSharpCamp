using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart3
{
    public class SMSLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logs send with SMS.");
        }
    }
}
