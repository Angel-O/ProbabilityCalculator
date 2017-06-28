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
        #region Singleton

        private static readonly SelectionItemsProvider provider = new SelectionItemsProvider();

        public static SelectionItemsProvider Instance => provider ?? new SelectionItemsProvider();

        private SelectionItemsProvider() { }

        #endregion

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
                    Selected = false // nothing selected by default
                });

            return availableItems;
        }
    }
}