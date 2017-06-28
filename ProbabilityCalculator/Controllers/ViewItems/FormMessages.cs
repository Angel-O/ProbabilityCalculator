using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProbabilityCalculator.Controllers.ViewItems
{
    /// <summary>
    /// Helper class that gathers error and notification messages
    /// </summary>
    public static class FormMessages
    {
        public static string GET_REQUEST_FORM_MESSAGE = "Select the operation and parameters (file name is optional)";

        public static string POST_REQUEST_INVALID_PARAMS = "Error: Invalid Parameters";

        public static string POST_REQUEST_LOG_NOTIFICATION = "Log file available at: ";

        public static string POST_REQUEST_SUCCESS = "Calculation completed succesfully";
    }
}