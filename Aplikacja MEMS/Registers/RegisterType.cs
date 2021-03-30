using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_MEMS.Registers
{
    public class RegisterType
    {
        public string typeName;
        public List<Parameter> parameterList;

        public RegisterType(string tName)
        {
            typeName = tName;
            parameterList = new List<Parameter>();
        }

        public void AddParameter(byte address, string pName, bool pGetSet)
        {
            Parameter parameter = new Parameter(address, pName, pGetSet);
            parameterList.Add(parameter);
        }
    }
}
