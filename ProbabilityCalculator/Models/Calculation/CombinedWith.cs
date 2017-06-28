
using System;
using ProbabilityCalculator.Models.Logging;

namespace ProbabilityCalculator.Models.Calculation
{
    /// <summary>
    /// Calculates <see cref="CombinedWith"/> probabilities
    /// </summary>
    public class CombinedWith : BinaryCalculationBase {

        public CombinedWith(double op1, double op2): base (op1, op2) { }

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