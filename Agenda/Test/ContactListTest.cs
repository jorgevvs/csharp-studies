using Contacts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Contacts.Test
{
    public class ContactListTest
    {
        [Theory]
        [InlineData("Paulo Silva", 18, 8412312418)]
        [InlineData("Matias Shaw", 43, 5211254122)]
        [InlineData("Rexxar",      53, 8412312418)]
        public void ListaCriada_AdicionarContatos_Sucesso(string name, int age, long num)
        {
            // Arrange
            ContactsList lista = new ContactsList();

            //Act 
            lista.StorePerson(name, age, num);



        }
    }
}
