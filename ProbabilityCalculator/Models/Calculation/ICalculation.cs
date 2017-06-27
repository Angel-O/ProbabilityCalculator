namespace ProbabilityCalculator.Models.Calculation
{
    public interface ICalculation
    {
        /// <summary>
        /// Executes the caclulations and returns its result
        /// </summary>
        /// <param name="op1">First operator</param>
        /// <param name="op2">Second operator</param>
        double Calculate(double op1, double op2);
    }
}