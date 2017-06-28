using System;
using System.Web.Mvc;
using System.Web.WebPages;
using ProbabilityCalculator.Models;
using ProbabilityCalculator.Models.Calculation;
using ProbabilityCalculator.Models.Logging;
using ProbabilityCalculator.Models.Utils;

namespace ProbabilityCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {      
           return View(new CalculatorViewModel());
        }

        // POST: Calculator/Calculate
        [HttpPost]
        public ActionResult Calculate(CalculatorViewModel viewModel)
        {

            // Validate parameters
            if (!viewModel.IsValid())
            {
                // TODO display error message
                return View("Index");
            }

            // Get the relevant factory for the controller
            ICalculationFactory calculationFactory = new BinaryCalculationFactory(viewModel.Operator1, viewModel.Operator2);

            // Convert the requested operation type
            CalculationType calculationType = EnumUtils.ConvertToEnum<CalculationType>(viewModel.SelectedCalculation);  

            try
            {
                // Get the corresponding calculation type
                ICalculation calculation = calculationFactory.Calculation(calculationType);

                double result = calculation.Calculate();

                // Get the logger: ideally this logic shouldn't leak all the way up to the controller, 
                // but unfortunately getting hold of the file path is not possible outside the controller
                ILogger logger = viewModel.File.IsEmpty() 
                    ? LoggerFactory.DefaultLogger 
                    : LoggerFactory.Logger(System.Web.Hosting.HostingEnvironment.MapPath($"~/App_Data/{viewModel.File}"));  

                // Log details
                logger.Log(string.Format("Date: {0}, Calculation: {1}, Op1: {2}, Op2: {3}, Result: {4}",
                    DateTime.Now,
                    calculationType,
                    viewModel.Operator1,
                    viewModel.Operator2,
                    result));

                // Set the result to the view model and pass it back to the view
                viewModel.Result = result;

                return View("Index",  viewModel);
            }
            catch
            {
                return new HttpStatusCodeResult(500, "Server Error");
            }         
        }
    }
}
