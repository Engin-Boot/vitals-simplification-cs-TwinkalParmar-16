﻿namespace Vital_Checks
{
    class VitalChecker
    {
        // This class is responsible to detect when any of the body vitals go out of limits
       
            public static bool vitalsAreOk(float bpm, float spo2, float respRate)
            {
                //True only when all the vitals is okay else false
                bool isOkayRespAndSpO2 = ExpressionEvaluation.evaluate(RespRateChecker.isRespRateOkay(respRate), SpO2Checker.isSpO2Okay(spo2));
                if (isOkayRespAndSpO2 && BpmChecker.isBpmOkay(bpm))
                {
                    return true;
                }

                return false;
            }
        
    }
}