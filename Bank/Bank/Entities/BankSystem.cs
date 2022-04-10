using Bank.Entities.Accounts;
using Bank.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Entities
{
    public class BankSystem : JuridicalPerson
    {
        public List<Person> holders;
        public List<Account> accounts;

        public BankSystem(string name, long cnpj, string razao) : base(name, cnpj, razao)
        {
            holders = new List<Person>();
            accounts = new List<Account>();
        }
       

        public void RegisterAccount(Account acc)
        {
            accounts.Add(acc);
        }

        public void RemoveAccount(long num)
        {
            accounts.Remove(accounts.Find(x => x.Number == num));
        }

        public void CheckAccount(long num)
        {
            Account acc = accounts.Find(x => x.Number == num);

            Console.WriteLine("======= Account Check =======");
            Console.WriteLine($"Owner: {acc.Owner}");
            Console.WriteLine($"Number: {acc.Number}");
            Console.WriteLine($"Balance: {acc.Balance}");
        }

        public void UpdateAccount(Account acc, int type)
        {
            if(type == 1)
            {
                CommonAcc newAcc = acc as CommonAcc;

                RemoveAccount(acc.Number);
                RegisterAccount(newAcc);

            }else if(type == 2)
            {
                LimitAcc newLimitAcc = acc as LimitAcc;

                Console.WriteLine("Inser the limit of this account: ");
                newLimitAcc.Limit = double.Parse(Console.ReadLine());

                RemoveAccount(newLimitAcc.Number);
                RegisterAccount(newLimitAcc);

            }else if (type == 3)
            {
                Console.Write("Choose the account's aniversary date: ");
                PoupancaAcc newAcc = acc as PoupancaAcc;

                newAcc.Aniversary = int.Parse(Console.ReadLine());

                RemoveAccount(acc.Number);
                RegisterAccount(newAcc);

            }
        }

        public void PrintAccounts()
        {
            foreach(Account acc in accounts)
            {
                acc.Statement();
            }
        }

        public void PrintOwnerAcc(Person owner)
        {
            List<Account> accs = accounts.FindAll(x => x.Owner == owner);
            foreach(Account acc in accs)
            {
                acc.Statement();
            }
        }

        public void RegisterHolder(string name)
        {
            Console.Write("Register as Physical ( 1 ) or Juridical ( 2 ) person: ");
            int type = int.Parse(Console.ReadLine());

            if(type == 1)
            {
                Console.Write("Type your CPF: ");
                long cpf = long.Parse(Console.ReadLine());

                PhysicalPerson newHolder = new PhysicalPerson(name, cpf);
                holders.Add(newHolder);

            }
            else if(type == 2)
            {
                Console.Write("Type your CNPJ: ");
                long cnpj = long.Parse(Console.ReadLine());
                Console.Write("Type your Razao: ");
                string razao = Console.ReadLine();

                JuridicalPerson newHolder = new JuridicalPerson(name, cnpj, razao);
                holders.Add(newHolder);
            }
        }

        public Person FindOwner(long id)
        {
            return holders.Find(x => x.Id == id);
        }

        public Account FindAccount(long num)
        {
            return accounts.Find(x => x.Number == num);
        }

    }
}
