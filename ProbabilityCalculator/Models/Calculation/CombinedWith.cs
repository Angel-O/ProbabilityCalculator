namespace ProbabilityCalculator.Models.Calculation
{
    /// <summary>
    /// Calculates <see cref="CombinedWith"/> probabilities
    /// </summary>
    public class CombinedWith : ICalculation {

        /// <summary>
        /// <see cref="ICalculation.Calculate"/>
        /// </summary>
        public double Calculate(double op1, double op2)
        {
            return op1 * op2;
        }
    }
}