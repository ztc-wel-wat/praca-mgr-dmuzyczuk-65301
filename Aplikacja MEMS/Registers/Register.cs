using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_MEMS.Registers
{
    public class Register
    {
        public string name;
        public List<RegisterType> registerType = new List<RegisterType>();

        public Register(string registerName)
        {
            name = registerName;
            registerType = new List<RegisterType>();
        }

        public void AddType(RegisterType rType)
        {
            registerType.Add(rType);
        }

        public List<RegisterType> GetList()
        {
            return registerType;
        }
    }
}
