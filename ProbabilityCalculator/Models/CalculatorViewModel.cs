using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProbabilityCalculator.Models
{
    public class CalculatorViewModel
    {

        [Required]
        [Display(Name = "Calculation type")]
        public IEnumerable<SelectListItem> AvailableCalculations { get; set; }

        public string SelectedCalculation { get; set; }

        [Display(Name = "File path")]
        public string File { get; set; }

        [Required]
        [Display(Name = "First operator")]
        public double Operator1 { get; set; }

        [Required]
        [Display(Name = "Second operator")]
        public double Operator2 { get; set; }

        public double Result { get; set; }

    }
}