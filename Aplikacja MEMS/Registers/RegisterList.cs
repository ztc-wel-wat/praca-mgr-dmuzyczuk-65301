using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_MEMS.Registers
{
    class RegisterList
    {
        public static Register r_LSM6DSL;

        public static List<Register> List = new List<Register>();
        public static void LSM6DSL()
        {
            if (r_LSM6DSL == null)
            {
                r_LSM6DSL = new Register("LSM6DSL");

                RegisterType basic = new RegisterType("Basic Register");

                basic.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                basic.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                basic.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                basic.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                basic.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                basic.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                basic.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                basic.AddParameter(0x50, "A_WRIST_TILT_LAT", true);
                basic.AddParameter(0x54, "A_WRIST_TILT_THS", true);
                basic.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                basic.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                basic.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                basic.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                basic.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                basic.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                basic.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                basic.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                basic.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                basic.AddParameter(0x59, "FUNC_CFG_ACCESS", true);

                r_LSM6DSL.AddType(basic);
                RegisterType banka = new RegisterType("Bank A");

                banka.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                banka.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                banka.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                banka.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                banka.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                banka.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                banka.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                banka.AddParameter(0x50, "A_WRIST_TILT_LAT", true);
                banka.AddParameter(0x54, "A_WRIST_TILT_THS", true);
                banka.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                banka.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                banka.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                banka.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                banka.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                banka.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                banka.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                banka.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                banka.AddParameter(0x59, "FUNC_CFG_ACCESS", true);
                banka.AddParameter(0x59, "FUNC_CFG_ACCESS", true);

                r_LSM6DSL.AddType(banka);

                RegisterType bankB = new RegisterType("Bank B");

                bankB.AddParameter(0x01, "FUNC_CFG_ACCESS", false);
                bankB.AddParameter(0x50, "A_WRIST_TILT_LAT", true);
                bankB.AddParameter(0x54, "A_WRIST_TILT_THS", true);
                bankB.AddParameter(0x59, "FUNC_CFG_ACCESS", true);

                r_LSM6DSL.AddType(bankB);
            }
        }
    }
}
