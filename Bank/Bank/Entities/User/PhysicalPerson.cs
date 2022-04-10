using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Entities.User
{
    public class PhysicalPerson : Person
    {
        public PhysicalPerson(string name, long cpf)
        {
            Name = name;
            Id = cpf;
        }
    }
}
