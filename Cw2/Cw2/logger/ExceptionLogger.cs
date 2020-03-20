using System;
using System.IO;
using Cw2.constants;
using Cw2.exception;

namespace Cw2.logger
{
    public static class ExceptionLogger
    {
        public static void LogException(BaseException baseException)
        {
            using var streamWriter = new StreamWriter(ProjectConstants.ExceptionLoggerFilePath, true);
            streamWriter.WriteLine("-----------------------------------------------------------------------------");
            streamWriter.WriteLine("Date : " + DateTime.Now.ToString(ProjectConstants.LoggerDateTimeFormat));
            streamWriter.WriteLine(baseException.GetType().FullName);
            streamWriter.WriteLine("Message : " + baseException.Message);
            streamWriter.WriteLine("Wrong line : " + baseException.Line);
            streamWriter.WriteLine();
        }

        public static void LogException(Exception exception)
        {
            using var streamWriter = new StreamWriter(ProjectConstants.ExceptionLoggerFilePath, true);
            streamWriter.WriteLine("-----------------------------------------------------------------------------");
            streamWriter.WriteLine("Date : " + DateTime.Now.ToString(ProjectConstants.LoggerDateTimeFormat));
            streamWriter.WriteLine(exception.GetType().FullName);
            streamWriter.WriteLine("Message : " + exception.Message);
            streamWriter.WriteLine();
        }
    }
}