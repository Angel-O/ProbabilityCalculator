using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace ProbabilityCalculator.Models.Logging
{
    /// <summary>
    /// Creates <see cref="ILogger"/> concrete classes
    /// </summary>
    public class LoggerFactory
    {
        private static readonly NullLogger nullLogger = new NullLogger();

        /// <summary>
        /// Default logger, currently does nothing
        /// </summary>
        public static ILogger DefaultLogger => nullLogger;
  
        /// <summary>
        /// returns a file logger if the user specified a file location or a safe null logger otherwise
        /// </summary>
        public static ILogger Logger(string filePath)
        {
            return new FileLogger(filePath);
        }

        #region Nested Types

        private class NullLogger : ILogger
        {
            /// <summary>
            /// <see cref="ILogger.Log"/>
            /// </summary>
            public void Log(string message) { }
        }

        #endregion
    }
}