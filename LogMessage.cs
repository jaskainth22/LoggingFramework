using System;

namespace LoggingFramework {
    public class LogMessage {
        private string message;
        private LogLevel level;
        private DateTime dateTime;
        public LogMessage(string message, LogLevel level) {
            this.message = message;
            this.level = level;
            this.dateTime = DateTime.Now;
        }

        public string GetLog() {
            return $"DateTime: [{this.dateTime}], LogLevel: [{this.level}], log: [{this.message}]";
        }
    }
}