namespace Bridge_logger
{
    public interface ILogging
    {
        public IWriter WriteLog { get; set; }
        public void LogInfo(string message);
        public void LogWarning(string message);
        public void LogError(string message);
    }
}
