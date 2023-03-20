using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilhaDinamica_ED
{
    internal class Pilha
    {

        NoPilha topo;       // Atributo

        public Pilha()
        {
            topo = null;
        }

        public bool estaVazia()
        {
            if(topo == null)
                return true;
            return false;
        }

        public void push(int valor)
        {
            NoPilha novoNo = new NoPilha(valor);
            if (estaVazia())
                topo = novoNo;
            else
            {
                novoNo.prox = topo; // Encadeamento
                topo = novoNo;
            }
        }

        public void imprime()
        {
            if (estaVazia())
                Console.WriteLine("A pilha está vazia");
            else
            {
                NoPilha temporaria = topo;
                while(temporaria != null)
                {
                    Console.Write(temporaria.getInfo() + " ");
                    temporaria = temporaria.prox;
                }
                Console.Write("\n");
            }
        }
        public int pop() 
        {
            if (estaVazia())
                return 666;
            else
            {
                NoPilha temporaria = topo;
                while (temporaria != null)
                {
                    int auxiliar = temporaria.getInfo();
                    temporaria = temporaria.prox;
                    topo = temporaria;
                    return auxiliar;
                }
            }
            return 0;
        
        }
    }
}
