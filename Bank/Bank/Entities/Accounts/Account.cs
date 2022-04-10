using Bank.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Entities.Accounts
{
    public abstract class Account
    {
        public Person Owner { get; set; }
        public double Balance { get; set; }
        public long Number { get; set; }
        public List<Transaction> TransactionList;

        abstract public void Statement();
        abstract public void Transfer(double value, Account acc);
        abstract public void Deposit(double value);
        abstract public void Withdraw(double value);
        abstract public void ReceiveTransfer(double value);
    }
}
