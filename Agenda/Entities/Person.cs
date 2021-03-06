using System;

namespace Contacts.Entities
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public long Number { get; private set; }

        public void PrintPerson()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age} years old");
            Console.WriteLine($"Number: {Number}");
        }
        
        public Person(string name, int age, long contactNum)
        {
            Name = name;
            Age = age;
            Number = contactNum;
        }
    }
}
