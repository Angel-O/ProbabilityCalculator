using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ProbabilityCalculator.Controllers.ViewItems;

namespace ProbabilityCalculator.Models
{
    /// <summary>
    /// View Model for the Calculator View
    /// </summary>
    public class CalculatorViewModel
    {
        public CalculatorViewModel() : this(SelectionItemsProvider.Instance.Items<CalculationType>()) { }

        private CalculatorViewModel(IEnumerable<SelectListItem> availableCalculationTypes)
        {
            AvailableCalculations = availableCalculationTypes;
        }

        [Required]
        [Display(Name = "Calculation type")]
        public IEnumerable<SelectListItem> AvailableCalculations { get; set; }

        [Required]
        public string SelectedCalculation { get; set; }

        [Display(Name = "File name")]
        public string File { get; set; }

        [Required]
        [Range(0, 1, ErrorMessage = "Please enter a decimal number between 0 and 1")]
        [Display(Name = "First operator")]
        public double Operator1 { get; set; }

        [Required]
        [Range(0, 1, ErrorMessage = "Please enter a decimal number between 0 and 1")]
        [Display(Name = "Second operator")]
        public double Operator2 { get; set; }

        [ReadOnly(true)]
        public double Result { get; set; }

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
        private bool ValidateOperator(double param)
        {
            return param >= 0 && param <= 1;
        }
    }
}