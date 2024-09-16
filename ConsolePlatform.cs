using System;

namespace LoggingFramework {
    public class ConsolePlatform : ILoggingPlatform {
        public void Print(LogMessage logMessage) {
            Console.WriteLine($"Print in Console. [{logMessage.GetLog()}]");
        }
    }
}