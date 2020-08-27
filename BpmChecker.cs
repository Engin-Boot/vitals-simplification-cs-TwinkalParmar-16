namespace Vital_Checks
{
    //This class is responsible to check bpm vital is okay or not.
    class BpmChecker
    {
         public static bool isBpmOkay(float bpm) {

            if (bpm < 70 || bpm > 150)
            {
                return false;
            }
            return true;
        }
    }
}
