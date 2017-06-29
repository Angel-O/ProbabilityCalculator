using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProbabilityCalculator;
using ProbabilityCalculator.Controllers;

namespace ProbabilityCalculator.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Get_Request_To_Index_Page_Should_Actually_Return_ViewResult()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Get_Request_To_About_Page_Should_Return_Correct_View()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("P.C.A. the ultimate pro-calc application.", result?.ViewBag.Message);
        }
    }
}
