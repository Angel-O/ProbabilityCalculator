using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ProbabilityCalculator.Models.Calculation;
using ProbabilityCalculator.Models.Utils;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ProbabilityCalculator.Tests.Models.Utils
{
    [TestClass]
    public class UtilsTest
    {
        [TestMethod]
        [TestCase("CombinedWith", CalculationType.CombinedWith)]
        [TestCase("Either", CalculationType.Either)]
        public void Valid_String_Should_Be_Converted_To_Enum(string enumName, CalculationType calculationType)
        {
            //Arrange
            CalculationType expected = calculationType;

            //Act
            CalculationType actual = EnumUtils.ConvertToEnum<CalculationType>(enumName);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCase("Invalid", CalculationType.CombinedWith)]
        [TestCase("StillInvalid", CalculationType.CombinedWith)]
        public void Invalid_String_Should_Be_Converted_To_Default_Enum(string enumName, CalculationType calculationType)
        {
            //Arrange
            CalculationType expected = calculationType;

            //Act
            CalculationType actual = EnumUtils.ConvertToEnum<CalculationType>(enumName);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCase(CalculationType.CombinedWith, "CombinedWith")]
        [TestCase(CalculationType.Either, "Either")]
        public void Enum_Should_Be_Converted_To_Corresponding_String(CalculationType calculationType, string enumName)
        {
            //Arrange
            string expected = enumName;

            //Act
            string actual = EnumUtils.ConvertToString(calculationType);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void All_Enums_Should_Be_Returned()
        {
            //Act
            var values = EnumUtils.Values<CalculationType>().ToList();

            //Assert
            Assert.IsTrue(values.Contains(CalculationType.CombinedWith));
            Assert.IsTrue(values.Contains(CalculationType.Either));
        }
    }
}
