using System;

namespace Vital_Checks
{
    class Program
    {
        //This program detects when any of the body vitals go out of limits. 
        //The purpose is to treat without delay.
        static int Main(string[] args)
        {
            ExpectedResult.ExpectTrue(checker.vitalsAreOk(100, 95, 60));
            ExpectedResult.ExpectFalse(checker.vitalsAreOk(40, 91, 92));
            ExpectedResult.ExpectFalse(checker.vitalsAreOk(50, 95, 75));
            ExpectedResult.ExpectFalse(checker.vitalsAreOk(175, 95, 75));
            ExpectedResult.ExpectTrue(checker.vitalsAreOk(90, 95, 75));
            ExpectedResult.ExpectTrue(checker.vitalsAreOk(97, 100, 75));
            ExpectedResult.ExpectFalse(checker.vitalsAreOk(101, 93, 20));
            ExpectedResult.ExpectFalse(checker.vitalsAreOk(101, 100, 105));
            Console.WriteLine("All ok");
            return 0;
        }
    }
}
