using System;
using System.Collections.Generic;
using System.Text;

namespace Vital_Checks
{
    // This class is responsible to check the expected result
    //(true/false) from the given combination of vitals
    class ExpectedResult
    {
        private  static bool expactedValue;
        private  static bool resultantValue;
        public static void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                expactedValue = true;
                resultantValue = false;
                printMessage();
            }
        }
        public static void ExpectFalse(bool expression)
        {
            if (expression)
            {
                expactedValue = false;
                resultantValue = true;
                printMessage();
            }
        }

        public static void printMessage() {
            Console.WriteLine("Expected {0}, but got {1}", expactedValue, resultantValue);
            Environment.Exit(1);
        }

   
    }
}
