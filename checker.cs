using System;

namespace Vital_Checks
{
    //This program detects when any of the body vitals go out of limits. 
    //The purpose is to treat without delay.
    class checker
    {
        static int Main(string[] args)
        {
            ExpectedResultTrue.ExpectTrue(VitalChecker.vitalsAreOk(100, 95, 60));
            ExpectedResultFalse.ExpectFalse(VitalChecker.vitalsAreOk(40, 91, 92));
            ExpectedResultFalse.ExpectFalse(VitalChecker.vitalsAreOk(50, 95, 75));
            ExpectedResultFalse.ExpectFalse(VitalChecker.vitalsAreOk(175, 95, 75));
            ExpectedResultTrue.ExpectTrue(VitalChecker.vitalsAreOk(90, 95, 75));
            ExpectedResultTrue.ExpectTrue(VitalChecker.vitalsAreOk(97, 100, 75));
            ExpectedResultFalse.ExpectFalse(VitalChecker.vitalsAreOk(101, 93, 20));
            ExpectedResultFalse.ExpectFalse(VitalChecker.vitalsAreOk(101, 100, 105));
            Console.WriteLine("All ok");
            return 0;
        }
    }

}
