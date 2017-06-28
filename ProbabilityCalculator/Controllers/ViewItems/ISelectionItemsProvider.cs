using System.Collections.Generic;
using System.Web.Mvc;

namespace ProbabilityCalculator.Controllers.ViewItems
{
    /// <summary>
    /// Calsses implementing this interfaces specialize in providing selection items 
    /// that are part of an enum set
    /// </summary>
    interface ISelectionItemsProvider
    {
        IEnumerable<SelectListItem> Items<T>() where T : struct;
    }
}
