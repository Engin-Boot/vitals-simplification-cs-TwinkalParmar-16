﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vital_Checks
{
    // This class is responsible to detect when any of the body vitals go out of limits
    class VitalChecker
    {
        public static bool vitalsAreOk(float bpm, float spo2, float respRate)
        {
            //True only when all the vitals is okay else false
            if (RespRateChecker.isRespRateOkay(respRate) && SpO2Checker.isSpO2Okay(spo2) && BpmChecker.isBpmOkay(bpm))
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}