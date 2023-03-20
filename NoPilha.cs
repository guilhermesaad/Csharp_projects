using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilhaDinamica_ED
{
    internal class NoPilha
    {
        int info;
        public NoPilha prox;

        public NoPilha()                           // Construtor default
        {
            prox = null;
        }

        public NoPilha(int info)
        {
            this.info = info;
            prox = null;
        }
        public NoPilha(int info, NoPilha prox)     // Construtor 
        {
            this.info = info;
            this.prox = prox;
        }

        public int getInfo()                       // Getter                     
        {
            return info;
        }

        public void setInfo(int info)              // Setter
        {
            this.info = info;
        }

    }
}
