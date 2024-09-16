using System;

namespace LoggingFramework {
    public class DatabasePlatform : ILoggingPlatform {
        // Give the actual logic to add log in DB
        public void Print(LogMessage logMessage) {
            Console.WriteLine($"Print in Database. [{logMessage.GetLog()}]");
        }
    }
}