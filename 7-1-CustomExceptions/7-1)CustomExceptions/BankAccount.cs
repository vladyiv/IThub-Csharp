using System;
using System.Collections.Generic;
using System.Text;

namespace _7_1_CustomExceptions
{
    internal class BankAccount
    {
        public decimal InitialBalance;
        public string AccountId;
        public BankAccount(string accountId, decimal initialBalance)
        {
            if (accountId.Length != 6) throw new InvalidAccountException(accountId);
            this.AccountId = accountId;
            this.InitialBalance = initialBalance;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > this.InitialBalance) throw new InsufficientFundsException(InitialBalance, amount);
            else Console.WriteLine($"Вы вывели {amount} у.е. со счёта с балансом {InitialBalance} у.е. Текущий баланс: {InitialBalance - amount} у.е.");
        }
    }
}