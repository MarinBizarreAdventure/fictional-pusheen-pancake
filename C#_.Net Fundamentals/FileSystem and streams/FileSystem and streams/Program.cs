using System;
using System.Threading.Tasks;

namespace FileSystem
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Logger logger = new Logger();
            await logger.Log(LogLevel.Info, "This is an informational message");
            try
            {
                DoSomething();
            }
            catch (Exception ex)
            {
                await logger.Log(LogLevel.Error, $"{ex.Message}");
            }

            Console.WriteLine("Logs have been written.");

            string logContents = await logger.ReadLogFileAsync();
            Console.WriteLine("Log file contents:");
            Console.WriteLine(logContents);
        }

        static void DoSomething()
        {
            throw new InvalidOperationException("An error occurred in DoSomething");
        }
    }
}
