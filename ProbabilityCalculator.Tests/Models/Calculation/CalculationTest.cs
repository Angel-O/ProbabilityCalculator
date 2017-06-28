using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ProbabilityCalculator.Models.Calculation;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ProbabilityCalculator.Tests.Models.Calculation
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        [TestCase(0.1, 0.2, 0.001)]
        public void CombinedWithCalculation_Should_Return_Approximate_Result(double op1, double op2, double epsylon)
        {
            //Arrange
            ICalculation combined = new CombinedWithCalculation(op1, op2);
           
            //Act
            double actual = combined.Calculate();

            //Assert
            Assert.IsTrue(actual - 0.02 < epsylon);
        }

        [TestMethod]
        [TestCase(0.1, 0.2, 0.28)]
        [TestCase(0.4, 0.2, 0.52)]
        [TestCase(0.3, 0.8, 0.86, Ignore = "true", IgnoreReason = "Needs further investigation")]
        [TestCase(1, 0.6, 1)]
        public void EitherCalculation_Should_Return_CorrectResult(double op1, double op2, double expected)
        {
            //Arrange
            ICalculation either = new EitherCalculation(op1, op2);

            //Act
            double actual = either.Calculate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
