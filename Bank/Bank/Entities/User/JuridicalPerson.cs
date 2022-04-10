using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Entities.User
{
    public class JuridicalPerson : Person
    {
        public string Razao { get; set; }
        public JuridicalPerson(string name, long cnpj, string razao)
        {
            Name = name;
            Id = cnpj;
            Razao = razao;
        }
    }
}
