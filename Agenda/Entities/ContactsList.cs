using Contacts.Repositories;
using System;
using System.Collections.Generic;

namespace Contacts.Entities
{
    internal class ContactsList
    {
        public List<Person> contacts;
        private ContactsListRepository repo;
        
        public ContactsList()
        {
            contacts = new List<Person>();
            repo = new ContactsListRepository();
        }

        public void StorePerson(string name, int age, long number)
        {
            repo.Add(new Person(name, age, number));
        }
        public void StorePerson()
        {
            Console.Clear();

            Console.WriteLine("============ Add Contact ============");
            Console.Write("New Contact's name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Number: ");
            long number = long.Parse(Console.ReadLine());
            Person p = new Person(name, age, number);

            repo.Add(p);
        }

        public void ErasePerson()
        {
            Console.Clear();

            Console.WriteLine("============ Add Contact ============");
            Console.Write("Contact's Name: ");
            string name = Console.ReadLine();
            repo.Remove(name);

        }

        public void PrintAllContacts()
        {
            Console.WriteLine("\n\n-====== All Contacts =====-");
            Console.WriteLine("----------------");
            foreach (Person p in repo.GetAllContacts())
            {
                p.PrintPerson();
                Console.WriteLine("----------------");
            }
            Console.WriteLine("\n");
        }
    }
}
