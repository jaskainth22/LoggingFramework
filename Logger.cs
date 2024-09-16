using System;

namespace LoggingFramework {
    // Singleton design pattern
    public sealed class Logger {
        private static Logger logger = null;
        private static readonly object lockObject = new object(); 
        private LogLevel level = LogLevel.DEBUG;
        private ILoggingPlatform loggingPlatform;
        private Logger() {

        }

        // Thread safe
        public static Logger GetLogger() {
            if (logger == null) {
                lock(lockObject) {
                    if (logger == null) {
                        logger = new Logger();
                    }
                }
            }
            return logger;
        }

        public void config(LogLevel level, ILoggingPlatform loggingPlatform) {
            this.level = level;
            this.loggingPlatform = loggingPlatform;
        }

        public void Log(LogLevel level, string message) {
            if (level < this.level) {
                return;
            }
            LogMessage msg = new LogMessage(message, level);
            loggingPlatform.Print(msg);
        }
        public void Debug(string message) {
            Log(LogLevel.DEBUG, message);
        }
        public void Info(string message) {
            Log(LogLevel.INFO, message);
        }
        public void Warning(string message) {
            Log(LogLevel.WARNING, message);
        }
        public void Error(string message) {
            Log(LogLevel.ERROR, message);
        }
        public void Fatal(string message) {
            Log(LogLevel.FATAL, message);
        }
    }
}