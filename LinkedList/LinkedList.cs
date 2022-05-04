using System;
using System.Collections.Generic;
using System.Text;

namespace Colecoes
{
    public class LinkedList : Colecao
    {
        public LinkedList()
        {
            First = null;
        }

        public void Add(int num)
        {
            if(First == null)
            {
                First = new Objeto<String>(num, null, null);
            }
            else
            {
                Objeto<String> iterate = First;

                while(iterate.Next != null)
                {
                    iterate = iterate.Next;
                }

                iterate.Next = new Objeto<String>(num, null, iterate);
            }
        }

        public void Remove(int num)
        {
            if (!IsEmpty())
            {
                Objeto<String> obj = First;
                while (obj.Next != null)
                {
                    if (obj.Value == num)
                    {
                        obj.Previous.Next = obj.Next;
                        obj.Next.Previous = obj.Previous;
                        break;
                    }
                    obj = obj.Next;
                }
            }
        }

        public void RemoveLast()
        {
            if (!IsEmpty())
            {
                Objeto<String> obj = First;
                while (obj.Next != null)
                {
                    obj = obj.Next;
                }
                obj.Previous.Next = null;
            }
        }

        public void RemoveFirst()
        {
            if (!IsEmpty())
            {
                if (First.Next != null)
                {
                    First.Next.Previous = null;
                    First = First.Next;
                }
                else { First = null; }

            }
        }
    }  
}
