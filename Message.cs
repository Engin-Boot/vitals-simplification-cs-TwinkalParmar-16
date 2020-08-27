using System;
using System.Collections.Generic;
using System.Text;

namespace Vital_Checks
{
    //This class is responsible to display message/warning
    class Message
    {
        public static void printMessage(bool expactedValue, bool resultantValue)
        {
            Console.WriteLine("Expected {0}, but got {1}", expactedValue, resultantValue);
            Environment.Exit(1);
        }
    }
}
