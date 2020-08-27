using System;
using System.Collections.Generic;
using System.Text;

namespace Vital_Checks
{
    class ExpressionEvaluation
    {
        public static bool evaluate(bool x, bool y)
        {
            if (x && y)
                return true;
            return false;
        }
    }
}
