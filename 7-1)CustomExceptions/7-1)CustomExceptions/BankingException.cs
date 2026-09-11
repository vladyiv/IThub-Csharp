using System;
using System.Collections.Generic;
using System.Text;

namespace _7_1_CustomExceptions
{
    internal class BankingException : Exception
    {
        public BankingException() { }
        public BankingException(string message) : base(message) { }
        public BankingException(string message, Exception innerException) : base(message, innerException) { }
    }
}

//public CraftingException() { }
//public CraftingException(string message) : base(message) { }
//public CraftingException(string message, Exception innerException) : base(message, innerException) { }
//    }