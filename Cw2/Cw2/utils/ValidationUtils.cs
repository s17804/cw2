using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Cw2.constants;
using Cw2.exception;
using Cw2.logger;

namespace Cw2.utils
{
    public static class ValidationUtils
    {
        public static bool ValidateString(string input, string pattern)
        {
            var regex = new Regex(pattern);
            var matcher = regex.Match(input);
            return matcher.Success;
        }

        private static bool CheckIfAllFieldsArePresent(IReadOnlyCollection<string> lineArray)
        {
            return lineArray.Count == ProjectConstants.NumberOfFStudentAttributes;
        }

        private static int CheckIfAllFieldsHaveValue(IReadOnlyList<string> lineArray)
        {
            for (var i = 0; i < lineArray.Count; i++)
            {
                if (string.Empty.Equals(lineArray[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public static bool ValidateStudentDto(string line)
        {
            var lineArray = line.Split(ProjectConstants.DataSeparator);

            try
            {
                if (!CheckIfAllFieldsArePresent(lineArray))
                {
                    throw new MissingParameterException("Missing parameters", line);
                }
            }
            catch (MissingParameterException e)
            {
                ExceptionLogger.LogException(e);
                return false;
            }

            try
            {
                var parameter = CheckIfAllFieldsHaveValue(lineArray);
                if (parameter != -1)
                {
                    throw new EmptyParameterException("Missing parameters: "
                                                      + ProjectConstants.StudentAttributesArray[parameter], line);
                }
            }
            catch (EmptyParameterException e)
            {
                ExceptionLogger.LogException(e);
                return false;
            }
            
            return true;
        }

        public static bool ValidatePath(string path)
        {
            try
            {
                if (!ValidateString(path, ProjectConstants.PathPattern))
                {
                    throw new ArgumentException("Invalid path");
                }
            }
            catch (ArgumentException e)
            {
                ExceptionLogger.LogException(e);
                return false;
            }

            try
            {
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException("File " + GetFileName(path) + " does not exist");
                }
            }
            catch (FileNotFoundException e)
            {
                ExceptionLogger.LogException(e);
                return false;
            }

            return true;
        }

        private static string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }
    }
}