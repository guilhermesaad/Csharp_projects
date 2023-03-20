using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace exercicioProva_ED2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua string na forma 'x C y'");
            string entrada = Console.ReadLine();

            int i = 0;
            int j = -1;
            int tamX = 0;
            int tamY = 0;

            for (; entrada[i] != 'C'; i++)
            { }
            tamX = i;
            for (; i < entrada.Length; i++)
            { j++; }
            tamY = j;

            //Console.WriteLine(tamX);
            //Console.WriteLine(tamY);

            if (tamX != tamY)
                Console.WriteLine("Errado ");
            else
            {
                char[] vecX = new char[tamX];
                char[] vecY = new char[tamY];
                Pilha pilhaA = new Pilha();
                Pilha pilhaB = new Pilha();

                
                for (i = 0; entrada[i] != 'C'; i++)
                {
                    vecX[i] = entrada[i];
                }
                    
                tamX = i;
                for (j = 0; i+1 < entrada.Length; i++, j++)
                {
                    vecY[j] = entrada[i+1];
                }
                    

                
                for (i = 0; i < tamX; i++)
                {

                    if (vecX[i] == 'A')  // Mexe com o X
                    {
                        if (pilhaA.top() == 'A')
                            pilhaA.remove();
                        else
                        pilhaA.insere('A');
                       
                    }

                    if (vecX[i] == 'B')
                    {
                        if (pilhaB.top() == 'B')
                            pilhaB.remove();
                        else
                        pilhaB.insere('B');

                    }

                    if (vecY[i] == 'A')  // Mexe com o Y
                    {
                        if (pilhaA.top() == 'A')
                            pilhaA.remove();
                        else
                            pilhaA.insere('A');

                    }

                    if (vecY[i] == 'B')
                    {
                        if (pilhaB.top() == 'B')
                            pilhaB.remove();
                        else
                            pilhaB.insere('B');
                        
                    }


                }
                if (pilhaA.estaVazia() && pilhaB.estaVazia())
                    Console.WriteLine("Correto ");
                else
                    Console.WriteLine("Errado");
                
            }
        }
    }
}
