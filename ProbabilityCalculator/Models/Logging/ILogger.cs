using System;

namespace ProbabilityCalculator.Models.Logging
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        private string fileName;

        public void Log(string message)
        {
            throw new System.NotImplementedException();
        }
    }

    public class ConsoleLogger : ILogger {

        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now} - {message}");
        }
    }
}