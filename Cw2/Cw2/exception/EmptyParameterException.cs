#nullable enable
using System;

namespace Cw2.exception
{
    public class EmptyParameterException : BaseException
    {
        public EmptyParameterException()
        {
        }

        public EmptyParameterException(string? message, string? line) : base(message, line)
        {
        }

        public EmptyParameterException(string? message, Exception? innerException, string? line)
            : base(message, innerException, line)
        {
        }
    }
}