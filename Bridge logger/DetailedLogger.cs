namespace Bridge_logger
{
    public class DetailedLogger : ILogging
    {
        public IWriter WriteLog { get; set; }

        public void LogError(string message)
        {
            WriteLog.Write("Detailed error: " + message);
        }

        public void LogInfo(string message) { }

        public void LogWarning(string message) { }
    }
}
