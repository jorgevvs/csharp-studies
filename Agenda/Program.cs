using System;
using System.Collections.Generic;
using Contacts.Entities;
using Contacts.Repositories;


namespace Agenda
{
    public class Program
    {
        static void Main(string[] args)
        {

            ContactsList contacts = new ContactsList();

            Console.WriteLine("============ Contact's List ============\n");

            bool loop = true;

            while (loop)
            {
                loop = Options(contacts);
            }

        }

        static bool Options(ContactsList list)
        {
            Console.WriteLine("----------- Select an Option -----------");
            Console.WriteLine("1- Add Contact          2- Erase Contact");
            Console.WriteLine("3- Print All Contacts   4- Exit");
            Console.WriteLine("----------------------------------------");
            Console.Write("Option: ");
            int option = int.Parse(Console.ReadLine());
            
            
            switch (option)
            {
                case 1: list.StorePerson(); break;
                case 2: list.ErasePerson(); break;
                case 3: list.PrintAllContacts(); break;
                case 4: return false;
                default: Console.Clear(); Console.WriteLine("Invalid Command!\n"); break;
            }
            return true;
        }
    }
}
