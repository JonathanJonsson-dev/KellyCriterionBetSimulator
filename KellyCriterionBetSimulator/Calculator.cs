using System;
using System.Collections.Generic;
using System.Text;

namespace KellyCriterionBetSimulator
{
    public class Calculator
    {
        public double ProbabilityWin { get; set; }
        public int MyProperty { get; set; }

        public Calculator(double probabilityWin)
        {
            ProbabilityWin = probabilityWin; 
        }
    }
}
