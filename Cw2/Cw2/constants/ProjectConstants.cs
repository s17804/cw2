using System;

namespace Cw2.constants
{
    public static class ProjectConstants
    {
        public const string Author = "Maciej Kazimierski";
        public const string DataSeparator = ",";
        public const string LoggerDateTimeFormat = "dd.MM.yyyy:hh.mm.ss";
        public const string PathPattern = "@^([a-z]|[A-Z]){1}:(\\|/){1}((/w+)(\\|/))*/w+/d/.csv";
        public const string ExceptionLoggerFilePath = "log.txt";
        public const string InputFileDefaultPath = "data.csv";
        public const string OutputXmlFileDefaultPath = "result.xml";
        public const string OutputJsonFileDefaultPath = "result.json";
        public const int NumberOfFStudentAttributes = 9;

        public static readonly string[] StudentAttributesArray =
        {
            "FirstName", "LastName", "StudiesName", "StudiesMode", "IndexNumber", "DateOfBirth",
            "Email", "MothersName", "FathersName",
        };

        public static int ReturnElementIndex(string parameterName)
        {
            return Array.FindIndex(StudentAttributesArray, row => row.Contains(parameterName));
        }
    }
}