using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemSOLID.SOLID
{
    public class Kredi :ILog
    {
        public string log(string message)
        {
            //geri dönüş string
            return "Kredi ile ödeme yapıldı. " + message + "TL";
        }
    }
}
