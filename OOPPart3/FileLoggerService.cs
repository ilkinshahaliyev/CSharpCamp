﻿namespace OOPPart3
{
    public class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to file.");
        }
    }
}
