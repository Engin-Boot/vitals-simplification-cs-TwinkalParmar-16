using System;
using System.Collections.Generic;
using System.Text;

namespace Vital_Checks
{
    //This class is responsiable to check the range of vitals
    class RangeChecker
    {
        private float lowerLimit;
        private float upperLimit;

        public RangeChecker(float lowerLimit, float upperLimit) {
            this.lowerLimit = lowerLimit;
            this.upperLimit = upperLimit;

        }
        public bool checkRange(float value) {

            if (value < this.lowerLimit || value> this.upperLimit)
            {
                return false;
            }
            return true;

        }
    }
}
