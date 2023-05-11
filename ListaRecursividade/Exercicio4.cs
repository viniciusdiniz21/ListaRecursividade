using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRecursividade
{
    public class Exercicio4
    {
       public string Conversor(int nmr)
        {
            if (nmr == 0)
            {
                return "0";
            }
            else if (nmr == 1)
            {
                return "1";
            }
            else
            {
                int resto = nmr % 2;
                int quociente = nmr / 2;
                return Conversor(quociente) + resto;
            }
        }
    }
}

