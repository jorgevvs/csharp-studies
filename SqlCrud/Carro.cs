using System;
using System.Collections.Generic;
using System.Text;

namespace SqlCrud
{
    public class Carro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public Proprietario Proprietario { get; set; }
    }
}
