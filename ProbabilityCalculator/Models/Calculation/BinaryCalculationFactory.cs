using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProbabilityCalculator.Models.Calculation
{
    /// <summary>
    /// Factory for binary calcualtions
    /// </summary>
    public class BinaryCalculationFactory : ICalculationFactory
    {
        /// <summary> First operator </summary>
        private readonly double op1;

        /// <summary> Second operator </summary>
        private readonly double op2;

        public BinaryCalculationFactory(double op1, double op2)
        {
            this.op1 = op1;
            this.op2 = op2;
        }

        /// <summary>
        /// Returns the <see cref="ICalculation"/> implemetation associted with the parameter specified
        /// </summary>
        public ICalculation Calculation(CalculationType calculationType)
        {
            switch (calculationType)
            {
                case CalculationType.CombinedWith:
                    return new CombinedWithCalculation(op1, op2);

                case CalculationType.Either:
                    return new EitherCalculation(op1, op2);

                default:
                    throw new ArgumentException("Unrecognized operation");
            }
        }
    }
}