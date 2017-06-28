namespace ProbabilityCalculator.Models.Logging
{
    /// <summary>
    /// Basic logger Interface
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Log the message passed as parameter
        /// </summary>
        void Log(string message);
    }
}