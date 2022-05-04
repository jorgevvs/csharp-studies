using System;
using System.Collections.Generic;
using System.Text;

namespace Colecoes
{
    public class Objeto<T>
    {
        public Objeto<T> Next { get; set; }
        public Objeto<T> Previous { get; set; }

        public int Value { get; set; }
        public T conteudo { get; set; }

        public Objeto(int x, Objeto<T> next, Objeto<T> previous)
        {
            Value = x;
            Previous = previous;
            Next = next;
        }
    }
}
