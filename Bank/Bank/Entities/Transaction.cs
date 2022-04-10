using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Entities
{
    public class Transaction
    {
        public DateTime Date { get; private set; }
        public double Ammount { get; private set; }
        public string Description { get; private set; }

        public Transaction(DateTime date, double ammount, string desc)
        {
            Date = date;
            Ammount = ammount;
            Description = desc;
        }
    }
}
