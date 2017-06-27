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
        private readonly double op1;
        private readonly double op2;

        public BinaryCalculationFactory(double op1, double op2)
        {
            this.op1 = op1;
            this.op2 = op2;
        }

        public ICalculation Calculation(CalculationType calculationType)
        {
            switch (calculationType)
            {
                case CalculationType.CombinedWith:
                    return new CombinedWith(op1, op2);

                case CalculationType.Either:
                    return new Either(op1, op2);

                default:
                    throw new ArgumentException("Unrecognized operation");
            }
        }
    }
}