using System;

namespace LoggingFramework {
    public class FilePlatform : ILoggingPlatform {
        // Give the actual logic to add log in file
        public void Print(LogMessage logMessage) {
            Console.WriteLine($"Print in File. [{logMessage.GetLog()}]");
        }
    }
}