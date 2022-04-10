using System;
using Bank.Entities;
using Bank.Entities.Accounts;

namespace Bank { 
    public class Program
    {
        static void Main(string[] args)
        {
            BankSystem cit = new BankSystem("CIT Bank", 41237189210001, "CI&T");

            Console.WriteLine("==================== CIT BANK ====================\n");
            Console.Write("Login as manager ( 1 )  or User ( 2 ): ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("\n==================================================");

            if(input == 1)
            {
                ManageBank(cit);
            }
            else if(input == 2)
            {
                while (true)
                {
                    Console.Write("Insert your account number: ");
                    long num = long.Parse(Console.ReadLine());

                    Account acc = cit.accounts.Find(x => x.Number == num);

                    if (acc != null)
                    {
                        ManageAccount(cit, cit.accounts.Find(x => x.Number == num));
                    }
                    else
                    {
                        Console.WriteLine("\nInsert a valid account number!\n");
                    }
                }
                

            }
        }

        static void ManageAccount(BankSystem bank, Account account)
        {
            Console.Clear();
            Console.WriteLine("============ CIT Account ============");
            Console.WriteLine("\nDeposit ( 1 )           Withdraw( 2 )\n");
            Console.WriteLine("Transfer( 3 )    Consult Balance( 4 )\n");
            Console.WriteLine("           Statement( 5 )");
            Console.WriteLine("============= Exit ( 0 ) ============");
            Console.Write("Insert an operation: ");
            int opt = int.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1: 
                    Console.WriteLine("\n === Deposit === "); 
                    Console.Write("Insert the quantity to make a deposit: ");  
                    account.Deposit(double.Parse(Console.ReadLine()));
                    break;

                case 2:
                    Console.WriteLine("\n === Withdraw ===");
                    Console.Write("Inser the quantity to withdraw: ");
                    account.Withdraw(double.Parse(Console.ReadLine()));
                    break;

                case 3:
                    Console.WriteLine("\n === Transfer ===");
                    Console.Write("Insert the destiny account: ");
                    int destAccnum = int.Parse(Console.ReadLine());
                    Console.Write("Insert the quantity: ");
                    double val = double.Parse(Console.ReadLine());

                    account.Transfer(val, bank.accounts.Find(x => x.Number == destAccnum));

                    break;

                case 4:
                    Console.WriteLine("=== Balance ===");
                    Console.WriteLine($"You have: ${account.Balance}");

                    

                    break;
            }


        }

        static void ManageBank(BankSystem bank)
        {

        }
    }
}
