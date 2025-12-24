using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemSOLID.SOLID
{
    public class LogFactory
    {
        public ILog yeniNesneOlustur(string className)
        {
            var newObject = System.Reflection.Assembly.GetAssembly(typeof(ILog)).CreateInstance("PaymentSystemSOLID.SOLID." + className);

            return (ILog)newObject;
        }
    }
}
