using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProbabilityCalculator.Models
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
        Either,


        ThisWillThrow
    }
}