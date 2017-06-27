namespace ProbabilityCalculator.Models.Calculation
{
    /// <summary>
    /// Calculates <see cref="Either"/> probabilities
    /// </summary>
    public class Either : ICalculation {

        /// <summary>
        /// <see cref="ICalculation.Calculate"/>
        /// </summary>
        public double Calculate(double op1, double op2)
        {
            return op1 + op2 - op1 * op2;
        }
    }
}