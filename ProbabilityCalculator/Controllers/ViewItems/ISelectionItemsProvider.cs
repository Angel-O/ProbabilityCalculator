using System.Collections.Generic;
using System.Web.Mvc;

namespace ProbabilityCalculator.Controllers.ViewItems
{
    interface ISelectionItemsProvider
    {
        IEnumerable<SelectListItem> Items<T>() where T : struct;
    }
}
