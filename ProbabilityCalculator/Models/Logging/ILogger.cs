namespace ProbabilityCalculator.Models.Logging
{
    public interface ILogger
    {
        /// <summary>
        /// Log the message passed as parameter
        /// </summary>
        void Log(string message);
    }
}