using System.Web.Mvc;
using ProbabilityCalculator.Controllers.ViewItems;
using ProbabilityCalculator.Models;

namespace ProbabilityCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {    
            // Create a view model adding select list items
            CalculatorViewModel viewModel = new CalculatorViewModel()
            {
                AvailableCalculations = SelectionItemsProvider.Instance.Items<CalculationType>()
            };

            // Pass the view model to the view and return it
            return View(viewModel);
        }

        // POST: Calculator/Calculate
        [HttpPost]
        public ActionResult Calculate()
        {
            return View();
        }
    }
}
