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
        /// <summary>
        /// Default logger, currently does nothing: in a real scenario it would be best to default to a logger
        /// that actually does logging
        /// </summary>
        public static ILogger DefaultLogger { get; } = new NullLogger();

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