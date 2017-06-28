using System.ComponentModel.DataAnnotations;

namespace ProbabilityCalculator.Models.Calculation
{
    /// <summary>
    /// Available calculation types
    /// </summary>
    public enum CalculationType
    {
        /// <summary>
        /// Combined calulation
        /// </summary>
        [Display(Name = "COMBINED")]
        CombinedWith,


        /// <summary>
        /// Either calculation
        /// </summary>
        [Display(Name = "EITHER")]
        Either
    }
}