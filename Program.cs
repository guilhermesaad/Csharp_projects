using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilhaDinamica_ED
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();      // criando a pilha vazia

            for (int i = 1000; i !=-1; i--)
                pilha.push(i);
            

            pilha.imprime();

            for (int i = 0; i < 900; i++)
                Console.WriteLine("Popando elemento: " + pilha.pop());
            

            pilha.imprime();

            Console.WriteLine();

        }
    }
}
