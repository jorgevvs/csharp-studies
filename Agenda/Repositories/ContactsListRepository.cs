using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contacts.Entities;
using Dapper;

namespace Contacts.Repositories
{
    public class ContactsListRepository
    {
        protected DbContext _dbContext;

        public ContactsListRepository()
        {
            _dbContext = new DbContext();
        }

        public void Add(Person person)
        {
            _dbContext.SqlConnection.Query($"INSERT INTO Person VALUES ('{person.Name}', {person.Age}, {person.Number})");
        }

        public void Remove(string name)
        {
            _dbContext.SqlConnection.Query($"Delete FROM Person where NAME = '{name}'");
        }

        public List<Person> GetAllContacts()
        {
            return _dbContext.SqlConnection.Query<Person>("Select * from Person").ToList();
        }

        public Person GetContactByName(string name)
        {
            return _dbContext.SqlConnection.Query<Person>($"Select * from Person where Name= '{name}'").ToList()[0];
        }
    }
}
