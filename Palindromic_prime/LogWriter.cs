using System;
using System.IO;
using System.Reflection;

namespace Palindromic_prime
{
    /// <summary>
    /// Class Library for Logging
    /// </summary>
    public static class LogWriter
    {
        private static string _exePath = string.Empty;

        /// <summary>
        /// Writes to Log
        /// </summary>
        /// <param name="logMessage"></param>
        /// <returns>string</returns>
        public static string LogWrite(string logMessage)
        {
            _exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (!File.Exists($"{_exePath}\\log.txt"))
            {
                File.Create($"{_exePath}\\log.txt");
            }

            try
            {
                using (StreamWriter w = File.AppendText($"{_exePath}\\log.txt"))
                {
                    var returnResult = AppendLog(logMessage, w);
                    w.AutoFlush = true;
                    return !string.IsNullOrWhiteSpace(returnResult) ? returnResult : string.Empty;
                }
            }
            catch (Exception ex)
            {
                return $"{ex.Message}";
            }
        }

        private static string AppendLog(string logMessage, TextWriter textWriter)
        {
            try
            {
                textWriter.Write("\r\nLog Entry : ");
                textWriter.WriteLine(
                    $"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()} : {logMessage}");
                textWriter.WriteLine(
                    "----------------------------------------------------------------------------------------------");
                return string.Empty;
            }
            catch (Exception ex)
            {
                return $"{ex.Message}";
            }
        }
    }
}
