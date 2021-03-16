namespace Bridge_logger
{
    public class SimpleLogger : ILogging
    {
        public IWriter WriteLog { get; set; }

        public void LogError(string message)
        {
            WriteLog.Write("Error: " + message);
        }

        public void LogInfo(string message) { }

        public void LogWarning(string message) { }
    }
}
