using System;

namespace Bridge_logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "I don't know error";
            ILogging log = new SimpleLogger();
            log.WriteLog = new ConsoleWriter();
            log.LogError(message);
            Console.WriteLine();

            ILogging log2 = new DetailedLogger();
            log2.WriteLog = new ConsoleWriter();
            log2.LogError(message);
            log2.WriteLog = new FileWriter();
            log2.LogError(message);
        }
    }
}
