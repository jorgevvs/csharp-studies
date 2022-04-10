using Bank.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Entities.Accounts
{
    public class CommonAcc : Account
    {
        public CommonAcc(Person person, double balance, long number)
        {
            Owner = person;
            Balance = balance;
            Number = number;
            TransactionList = new List<Transaction>();
        }

        override public void Statement()
        {
            Console.WriteLine("\n\n============ Common Account ============");
            Console.WriteLine($"Owner's Name: {Owner}");
            Console.WriteLine($"Account Number: {Number}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine($"============ Transactions ============");


            for (int i = 0; i < TransactionList.Count; i++)
            {
                if (i == 30)
                {
                    break;
                }
                Console.WriteLine($"Transaction date: {TransactionList[i].Date}");
                Console.WriteLine($"Transaction value: {TransactionList[i].Ammount}");
                Console.WriteLine($"Transaction Description: {TransactionList[i].Description}");
                Console.WriteLine($"===================================");
            }
        }

        public override void Transfer(double value, Account acc)
        {
            TransactionList.Add(new Transaction(DateTime.Now, value, "Transferring to other account"));
            Balance -= value;
            acc.ReceiveTransfer(value);
        }

        public override void Deposit(double value)
        {
            TransactionList.Add(new Transaction(DateTime.Now, value, "Deposit"));
            Balance += value;
        }

        public override void Withdraw(double value)
        {
            TransactionList.Add(new Transaction(DateTime.Now, value, "Withdraw"));
            Balance -= value;
        }

        public override void ReceiveTransfer(double value)
        {
            TransactionList.Add(new Transaction(DateTime.Now, value, "Receiving transfer"));
            Balance += value;
        }

    }
}
