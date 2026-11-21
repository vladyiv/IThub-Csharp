using System;
using System.Collections.Generic;
using System.Text;

namespace _7_1_CustomExceptions
{
    internal class InvalidAccountException : BankingException
    {
        public string AccountId { get; }
        public InvalidAccountException(string accountId) : base($"Неверный формат номера счёта {accountId}. Правильный формат: 6 цифр, текущая длина номера: {accountId.Length}.")
        {
            this.AccountId = accountId;
        }
    }
}