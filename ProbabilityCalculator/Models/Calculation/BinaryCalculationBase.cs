using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProbabilityCalculator.Models.Calculation
{
    /// <summary>
    /// Base class for operations that have two parameters
    /// </summary>
    public abstract class BinaryCalculationBase : ICalculation
    {
        /// <summary>
        /// First operantor
        /// </summary>
        public double Op1 { get; }

        /// <summary>
        /// Second operantor
        /// </summary>
        public double Op2 { get; }

        protected BinaryCalculationBase(double op1, double op2)
        {
            Op1 = op1;
            Op2 = op2;
        }

        /// <summary>
        /// <see cref="ICalculation.Calculate"/>
        /// </summary>
        public abstract double Calculate();
    }
}