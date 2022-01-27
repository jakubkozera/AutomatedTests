using System;

namespace MyProject.Service
{
    public class Logger
    {
        public void LogInformation(string message)
        {
            Console.WriteLine(message);
        }

        public void LogError(string message)
        {
            Console.WriteLine(message);
        }
    }
}