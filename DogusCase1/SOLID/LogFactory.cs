using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogusCase1.SOLID
{
    public class LogFactory
    {
        public ILog yeniNesneOlustur(string className)
        {
            var newObject = System.Reflection.Assembly.GetAssembly(typeof(ILog)).CreateInstance("DogusCase1.SOLID." + className);

            return (ILog)newObject;
        }
    }
}
