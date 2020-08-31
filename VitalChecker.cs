namespace Vital_Checks
{
    class VitalChecker
    {
        // This class is responsible to detect when any of the body vitals go out of limits
       
            public static bool vitalsAreOk(float bpm, float spo2, float respRate)
            {
            //True only when all the vitals is okay else false
            RangeChecker checkBPM = new RangeChecker(70,150);
            RangeChecker checkSpO2 = new RangeChecker(90,500);
            RangeChecker checkRespRate = new RangeChecker(30,95);
            bool isOkayRespAndSpO2 = ExpressionEvaluation.evaluate(checkRespRate.checkRange(respRate), checkSpO2.checkRange(spo2));

            if (isOkayRespAndSpO2 && checkBPM.checkRange(bpm))
                {
                    return true;
                }

                return false;
            }
        
    }
}
