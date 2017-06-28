
using System;
using ProbabilityCalculator.Models.Logging;

namespace ProbabilityCalculator.Models.Calculation
{
    /// <summary>
    /// Calculates <see cref="CombinedWithCalculation"/> probabilities
    /// </summary>
    public class CombinedWithCalculation : BinaryCalculationBase {

        public CombinedWithCalculation(double op1, double op2): base (op1, op2) { }

        /// <summary>
        /// <see cref="ICalculation.Calculate"/>
        /// </summary>
        public override double Calculate()
        {
            double result = Op1 * Op2;

            return result;
        }
    }
}