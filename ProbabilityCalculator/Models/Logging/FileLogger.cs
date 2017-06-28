using System.IO;


namespace ProbabilityCalculator.Models.Logging
{
    /// <summary>
    /// Logger that writes to a file
    /// </summary>
    public class FileLogger : ILogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// <see cref="ILogger.Log"/>
        /// </summary>
        public void Log(string message)
        {
            File.AppendAllLines(path, new[] { message });
        }
    }
}