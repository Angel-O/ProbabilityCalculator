using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProbabilityCalculator.Models
{
    public class Caclulator
    {
        public ICalculation Calculation { get; set; }
        public ILogger Logger { get; set; }
    }
}