using System;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.WebPages;
using ProbabilityCalculator.Controllers.ViewItems;
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
            ViewBag.FormMessage = FormMessages.GET_REQUEST_FORM_MESSAGE;
            
            return View(new CalculatorViewModel());
        }

        //GET: Calculator/Calculate
        public ActionResult Calculate()
        {
            return RedirectToAction("Index");
        }

        // POST: Calculator/Calculate
        [HttpPost]
        public ActionResult Calculate(CalculatorViewModel viewModel)
        {

            // Validate parameters
            if (!viewModel.IsValid())
            {
                ViewBag.FormMessage = FormMessages.POST_REQUEST_INVALID_PARAMS;

                return View("Index");
            }

            // Get the relevant factory for the controller (casting is safe at this point)
            ICalculationFactory calculationFactory = new BinaryCalculationFactory((double) viewModel.Operator1, (double) viewModel.Operator2);

            // Convert the requested operation type
            CalculationType calculationType = EnumUtils.ConvertToEnum<CalculationType>(viewModel.SelectedCalculation);  

            try
            {
                // Get the corresponding calculation type
                ICalculation calculation = calculationFactory.Calculation(calculationType);

                double result = calculation.Calculate();

                // Get the logger: ideally this logic shouldn't leak all the way up to the controller, 
                // but unfortunately getting hold of the file path is not possible outside the controller
                string filePath = System.Web.Hosting.HostingEnvironment.MapPath($"~/App_Data/{viewModel.File}");

                ILogger logger = viewModel.File.IsEmpty() 
                    ? LoggerFactory.DefaultLogger 
                    : LoggerFactory.Logger(filePath);  

                // Log details
                logger.Log(string.Format("Date: {0}, Calculation: {1}, Op1: {2}, Op2: {3}, Result: {4}",
                    DateTime.Now,
                    calculationType,
                    viewModel.Operator1,
                    viewModel.Operator2,
                    result));

                // Set the result to the view model and pass it back to the view
                viewModel.Result = result;

                // Add confirmation messages
                ViewBag.FormMessage = FormMessages.POST_REQUEST_SUCCESS;
                ViewBag.ConfirmationMessage = viewModel.File.IsEmpty()
                    ? string.Empty
                    : FormMessages.POST_REQUEST_LOG_NOTIFICATION + filePath;

                return View("Index",  viewModel);
            }
            catch
            {
                return new HttpStatusCodeResult(500, "Server Error");
            }         
        }
    }
}
