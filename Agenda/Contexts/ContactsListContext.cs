using Contacts.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts.Contexts
{
    public class ContactsListContext : DbContext
    {
        public DbSet<Person> Person { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB; Initial Catalog=ContactsList;Integrated Security=SSPI;");
        }
    }
}
