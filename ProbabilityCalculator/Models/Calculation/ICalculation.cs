
using System;

namespace ProbabilityCalculator.Models.Calculation
{
    public interface ICalculation
    {
        /// <summary>
        /// Executes the calculation and returns its result
        /// </summary>
        double Calculate();
    }
}