using Agenda.Entities;
using System;
using System.Collections.Generic;

namespace Contacts.Entities
{
    internal class ContactsList
    {
        public List<Person> contacts;
        
        public ContactsList()
        {
            contacts = new List<Person>();
        }

        public void StorePerson(string name, int age, long number)
        {
            contacts.Add(new Person(name, age, number));
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

            contacts.Add(p);
        }

        public void ErasePerson()
        {
            Console.Clear();

            Console.WriteLine("============ Add Contact ============");
            Console.Write("Contact's Name: ");
            string name = Console.ReadLine();
            bool removed = contacts.Remove(contacts.Find(x => x.Name == name));

            if (removed) Console.WriteLine("Erased Sucessfully!!");
            else Console.WriteLine("Contact not found!!\n");

        }

        public void PrintAllContacts()
        {
            Console.WriteLine("\n\n-====== All Contacts =====-");
            Console.WriteLine("----------------");
            foreach (Person p in contacts)
            {
                p.PrintPerson();
                Console.WriteLine("----------------");
            }
            Console.WriteLine("\n");
        }
    }
}
