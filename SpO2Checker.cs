namespace Vital_Checks
{
    //This class is responsible to check oxygen saturation is okay or not.
    class SpO2Checker
    {
        public static bool isSpO2Okay(float spo2)
        {
            if (spo2 < 90)
            {
                return false;
            }
            return true;
        }
    }
}
