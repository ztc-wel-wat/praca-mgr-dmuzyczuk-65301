using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplikacja_MEMS.Registers;

namespace Aplikacja_MEMS.Registers
{
    public class Parameter
    {
        public string name;
        public bool getSet;
        public byte address;

        public Parameter(byte parameterAddress, string parameterName, bool parameterGetSet)
        {
            address = parameterAddress;
            name = parameterName;
            getSet = parameterGetSet;
        }
    }
}
