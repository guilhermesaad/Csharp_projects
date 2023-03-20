using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioProva_ED2
{
    class Pilha
    {
        // elementos - atributos

        private char[] pilhaChar = new char[20];
        private int topo;

        // operadores - métodos

        // construtor
        public Pilha()
        {
            topo = -1;
        }

        public bool estaVazia()
        {
            if (topo == -1)
                return true;
            else
                return false;
        }

        public void insere(char c) // push
        {
            topo++;
            pilhaChar[topo] = c;
        }

        public char remove() // pop
        {
            char temp = pilhaChar[topo];
            topo--;
            return temp;

        }

        public void imprime()
        {
            int temp = topo;
            if (estaVazia())
                Console.WriteLine("A Pilha esta vazia");
            else
            {
                while (temp != -1)
                {
                    Console.Write(pilhaChar[temp]);
                    //Console.WriteLine();
                    temp--;
                }
            }
        }

        public char top()
        {
            if(topo == -1)
                return '!';
            return pilhaChar[topo];
        }


    } // fim da classe Pilha
}

