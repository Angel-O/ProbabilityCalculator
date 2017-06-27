using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProbabilityCalculator.Models.Calculation;
using ProbabilityCalculator.Models.Logging;

namespace ProbabilityCalculator.Models
{
    public class Calculator
    {
        public ICalculation Calculation { get; set; }
        public ILogger Logger { get; set; }
    }
}