using System.Diagnostics;
using System.Reflection;

namespace FileSystem
{
    public class Logger
    {
        private static readonly string LogDirectory = "Logs";
        private static readonly string LogFileName = $"Logs_{DateTime.Now:yyyy-MM-dd}.txt";
        private static readonly string LogFilePath = Path.Combine( LogDirectory, LogFileName );

        public async Task Log(LogLevel logLevel, string message)
        {
            string methodName = GetCallingMethodName();
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Method: {methodName}, Level: {logLevel}, Message: {message}";
            await WriteLogAsync(logMessage);
        }

        private string GetCallingMethodName()
        {
            StackFrame frame = new StackFrame(2, false); 
            MethodBase method = frame.GetMethod();
            return $"{method.DeclaringType?.Name}.{method.Name}";
        }

        private async Task WriteLogAsync(string message)
        {
            try
            {
                if (!Directory.Exists(LogDirectory))
                {
                    Directory.CreateDirectory(LogDirectory);
                }

                using (StreamWriter writer = File.AppendText(LogFilePath))
                {
                    await writer.WriteLineAsync(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }
        
        public async Task<string> ReadLogFileAsync()
        {
            try
            {
                if (File.Exists(LogFilePath))
                {
                    using (StreamReader reader = File.OpenText(LogFilePath))
                    {
                        return await reader.ReadToEndAsync();
                    }
                }
                else
                {
                    return "Log file not found";
                }
            }
            catch (Exception ex)
            {
                return $"Error reading log file: {ex.Message}";
            }
        }
    }
}
