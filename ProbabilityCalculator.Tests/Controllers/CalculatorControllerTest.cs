using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProbabilityCalculator;
using ProbabilityCalculator.Controllers;
using ProbabilityCalculator.Controllers.ViewItems;
using ProbabilityCalculator.Models.Calculation;


namespace ProbabilityCalculator.Tests.Controllers
{
    [TestClass]
    public class CalculatorControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Stub
        }

        [TestMethod]
        public void Get_Request_To_Calculate_Action_Should_Redirect_To_Index_Page()
        {
            //Arrange
            var controller = new CalculatorController();

            //Act
            var result = controller.Calculate() as RedirectToRouteResult;

            //Assert
            Assert.AreEqual("Index", result?.RouteValues["action"]);
        }

        [TestMethod]
        public void Post_Request_With_Invalid_ViewModel_Parameters_Should_Return_To_Index_Page()
        {
            //Arrange
            var viewModel = new CalculatorViewModel();
            viewModel.Operator1 = -1;
            var controller = new CalculatorController();

            //Act
            var result = controller.Calculate(viewModel) as ViewResult;

            //Assert
            Assert.AreEqual("Index", result?.ViewName);
        }

        [TestMethod]
        public void Post_Request_With_Invalid_ViewModel_Parameters_Should_Be_Notified_To_Form_Page()
        {
            //Arrange
            var viewModel = new CalculatorViewModel();
            viewModel.Operator2 = -1;
            var controller = new CalculatorController();

            //Act
            var result = controller.Calculate(viewModel) as ViewResult;

            //Assert
            Assert.AreEqual(FormMessages.POST_REQUEST_INVALID_PARAMS, result?.ViewBag.FormMessage);
        }
    }
}