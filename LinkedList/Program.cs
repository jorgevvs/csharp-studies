using System;

namespace Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Nova Lista ------");
            LinkedList list = new LinkedList();
            Console.Write("Lista Está vazia: ");
            Console.WriteLine(list.IsEmpty());

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            Console.WriteLine("Adicionando 10 números: ");
            list.printList();

            list.Remove(2);
            list.Remove(7);
            list.RemoveLast();
            list.RemoveFirst();

            Console.WriteLine("Removendo 2, 7 e primeiro e ultimo!");
            list.printList();

            Console.Write("Lista ainda está vazia: ");
            Console.WriteLine(list.IsEmpty());


            Console.WriteLine("\n\n------ Criando nova Pilha ------");
            
        }
    }
}
