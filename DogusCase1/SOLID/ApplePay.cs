using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogusCase1.SOLID
{
    public class ApplePay :ILog
    {
        public string log(string message)
        {
            //return message + " ApplePay ile ödendi.";
            return "Apple Pay ile ödeme yapıldı. " + message + "TL";
        }
    }
}
