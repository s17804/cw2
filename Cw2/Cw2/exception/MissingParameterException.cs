#nullable enable
using System;

namespace Cw2.exception
{
    public class MissingParameterException : BaseException
    {
        public MissingParameterException()
        {
        }

        public MissingParameterException(string? message, string? line) : base(message, line)
        {
        }

        public MissingParameterException(string? message, Exception? innerException, string? line)
            : base(message, innerException, line)
        {
        }
    }
}