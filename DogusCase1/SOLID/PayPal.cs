using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogusCase1.SOLID
{
    public class PayPal :ILog
    {
        public string log(string message)
        {
            return "PayPal ile ödeme yapıldı. " + message + "TL";
        }
    }
}
