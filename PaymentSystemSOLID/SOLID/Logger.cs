using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemSOLID.SOLID
{
    public class Logger
    {
        public ILog iLog;

        public Logger(ILog iLog)      //Constructor Injection
        {
            this.iLog = iLog;
        }
        public string LogKaydet(string message)
        {
            return iLog.log(message);
        }
    }
}
