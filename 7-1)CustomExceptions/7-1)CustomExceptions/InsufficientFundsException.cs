using System;
using System.Collections.Generic;
using System.Text;

namespace _7_1_CustomExceptions
{
    internal class InsufficientFundsException : BankingException
    {
        public decimal RequestedAmount, AvailableBalance;
        public InsufficientFundsException(decimal requestedAmount, decimal availableBalance) : base($"Сумма вывода больше баланса! RequestedAmount = {requestedAmount}, AvailableBalance = {availableBalance}.")
        {
            this.RequestedAmount = requestedAmount;
            this.AvailableBalance = availableBalance;
        }
    }
}