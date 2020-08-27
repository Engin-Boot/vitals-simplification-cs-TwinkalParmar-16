namespace Vital_Checks
{
    //This class is responsible to check resp rate is okay or not.
    class RespRateChecker
    {
        public static bool isRespRateOkay(float respRate)
        {
            if (respRate < 30 || respRate > 95)
            {
                return false;
            }
            return true;
        }
    }
}
