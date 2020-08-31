namespace Vital_Checks
{
    // This class is responsible to check the expected result
    //(true/false) from the given combination of vitals
    class ExpectedResultTrue
    {
        private  static bool expactedValue;
        private  static bool resultantValue;
        public static void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                expactedValue = true;
                resultantValue = false;
                Message.printMessage(expactedValue, resultantValue);
            }
        }
    }
}
