using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProbabilityCalculator.Models.Utils;

namespace ProbabilityCalculator.Controllers.ViewItems
{
    /// <summary>
    /// Provides a controller with a collection of selection items
    /// </summary>
    internal class SelectionItemsProvider : ISelectionItemsProvider
    {
        private static readonly SelectionItemsProvider Provider = new SelectionItemsProvider();
        public static SelectionItemsProvider Instance => Provider ?? new SelectionItemsProvider();

        private SelectionItemsProvider() { }
         

        public IEnumerable<SelectListItem> Items<T>() where T : struct
        {
            // Get all values for the specific enum type
            IEnumerable<T> calculationTypes = EnumUtils.Values<T>();

            // Create a SelectListItem for each one of them
            IEnumerable<SelectListItem> availableItems =
                calculationTypes.Select(calculation => new SelectListItem()
                {
                    Text = calculation.ToString(),
                    Value = calculation.ToString(),
                    Selected = false // nothing selected by default //TODO pass predicate so the caller can specify a criteria for what items should be selected
                });

            return availableItems;
        }
    }
}