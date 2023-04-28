using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class IntegralNumericTypes
    {
        public void MyCode()
        {
            byte byte1 = 130; // 0 to 255 (1 byte of memory)
            sbyte sbyte1 = -100; // -128 to 127 (1 byte of memory)

            short short1 = 25_000; // -32,768 to 32,767 (2 bytes of memory)
            ushort ushort1 = 60_000; // 0 to 65,535 (2 bytes of memory)

            int int1 = 5_000_000; // -2,147,483,648 to 2,147,483,647 (4 bytes of memory)
            uint uint1 = 3_147_483_647; // 	0 to 4,294,967,295 (4 bytes of memory)

            long long1 = 300_147_483_647; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 (8 bytes of memory)
            ulong ulong1 = 17_223_372_036_854_775_807; // 0 to 18,446,744,073,709,551,615 (8 bytes of memory)

        }
    }
}
