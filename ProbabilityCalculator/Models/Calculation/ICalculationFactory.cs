namespace ProbabilityCalculator.Models.Calculation
{
    public interface ICalculationFactory
    {
        /// <summary>
        /// Spawns <seealso cref="ICalculation"/> implementations
        /// </summary>
        ICalculation Calculation(CalculationType calculationType);
    }
}