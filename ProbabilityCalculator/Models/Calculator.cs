using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProbabilityCalculator.Models.Calculation;
using ProbabilityCalculator.Models.Logging;
using ProbabilityCalculator.Models.Validation;

namespace ProbabilityCalculator.Models
{
    public class Calculator
    {
        private ICalculation calculation;

        private readonly IParamValidator validator; // needs to be instantiated at a higher level

        private readonly ICalculationFactory factory; 

        public ILogger Logger { get; set; }

        public Calculator(ICalculationFactory factory, IParamValidator validator)
        {
            this.factory = factory; // needs to be instantiated with the right params
            this.validator = validator;
        }

        public double ExecuteCalculation(CalculationType calculationType)
        {
            calculation = factory.Calculation(calculationType);
            double result = calculation.Calculate();

            //do logging (async ideally...)

            return result;
        }
    }
}