using System;
using System.Collections.Generic;
using System.Text;

namespace Vital_Checks
{
    class ExpectedResultFalse
    {
        private static bool expactedValue;
        private static bool resultantValue;
        public static void ExpectFalse(bool expression)
        {
            if (expression)
            {
                expactedValue = false;
                resultantValue = true;
                Message.printMessage(expactedValue, resultantValue);
            }
        }
    }
}
