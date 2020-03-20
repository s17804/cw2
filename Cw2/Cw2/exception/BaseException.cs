#nullable enable
using System;

namespace Cw2.exception
{
    public class BaseException : Exception
    {
        private readonly string? _message;

        public string Line { get; }

        public BaseException()
        {
        }

        public BaseException(string? message, string? line) : base(message)
        {
            Line = line;
        }

        public BaseException(string? message, Exception? innerException, string? line) : base(message, innerException)
        {
            _message = message;
            Line = line;
        }
    }
}