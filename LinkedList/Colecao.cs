using System;
using System.Collections.Generic;
using System.Text;

namespace Colecoes
{
    public class Colecao
    {
        public Objeto<String> First { get; set; }
        public void printList()
        {
            Objeto<String> obj = First;
            if (!IsEmpty())
            {
                while (obj != null)
                {
                    Console.WriteLine(obj.Value);
                    obj = obj.Next;
                }
            }
        }

        public bool IsEmpty()
        {
            return (First == null);
        }

        public int Count()
        {
            Objeto<String> obj = First;
            int count = 0;
            while (obj != null)
            {
                count++;
                obj = obj.Next;
            }

            return count;
        }

        public bool Contains(int i)
        {
            Objeto<String> obj = First;

            while (obj != null)
            {
                if (obj.Value == i) return true;
                obj = obj.Next;
            }

            return false;
        }
    }
}
