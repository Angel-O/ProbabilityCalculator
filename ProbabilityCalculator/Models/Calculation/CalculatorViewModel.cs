using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ProbabilityCalculator.Controllers.ViewItems;

namespace ProbabilityCalculator.Models.Calculation
{
    /// <summary>
    /// View Model for the Calculator View
    /// </summary>
    public class CalculatorViewModel
    {
        #region .ctor

        public CalculatorViewModel() : this(SelectionItemsProvider.Instance.Items<CalculationType>()) { }

        private CalculatorViewModel(IEnumerable<SelectListItem> availableCalculationTypes)
        {
            AvailableCalculations = availableCalculationTypes;
        }

        #endregion

        /// <summary>
        /// The set of available calculations in the drop down menu
        /// </summary>
        [Required]
        [Display(Name = "Calculation type")]
        public IEnumerable<SelectListItem> AvailableCalculations { get; set; }


        /// <summary>
        /// The selected calculation
        /// </summary>
        [Required]
        public string SelectedCalculation { get; set; }

        /// <summary>
        /// File name to save logs
        /// </summary>
        [Display(Name = "File name")]
        public string File { get; set; }

        /// <summary>
        /// First operator
        /// </summary>
        [Required]
        [Range(0, 1, ErrorMessage = "Please enter a decimal number between 0 and 1")]
        [Display(Name = "First operator")]
        public double? Operator1 { get; set; }

        /// <summary>
        /// Second operator
        /// </summary>
        [Required]
        [Range(0, 1, ErrorMessage = "Please enter a decimal number between 0 and 1")]
        [Display(Name = "Second operator")]
        public double? Operator2 { get; set; }

        /// <summary>
        /// Readonly result
        /// </summary>
        [ReadOnly(true)]
        public double? Result { get; set; }

        /// <summary>
        /// Returns true if the data provided by the user is valid, false otherwise
        /// </summary>
        public bool IsValid()
        {
            return ValidateOperator(Operator1) && ValidateOperator(Operator2);
        }

        /// <summary>
        /// Validate operators
        /// </summary>
        private bool ValidateOperator(double? param)
        {
            return param >= 0 && param <= 1;
        }
    }
}