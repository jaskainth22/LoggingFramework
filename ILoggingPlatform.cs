using System;

namespace LoggingFramework {
    public interface ILoggingPlatform {
        public void Print(LogMessage logMessage);
    }
}