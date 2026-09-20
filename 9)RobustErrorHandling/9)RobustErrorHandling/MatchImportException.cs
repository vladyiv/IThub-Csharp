using System;
using System.Collections.Generic;
using System.Text;

namespace _9_RobustErrorHandling
{
    internal class MatchImportException : Exception
    {
        public MatchImportException() { }
        public MatchImportException(string message) : base(message) { }
        public MatchImportException(string message, Exception innerException) : base(message, innerException) { }

    }
}
