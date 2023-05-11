using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRecursividade
{
    public class Exercicio1
    {

        // x ^ 0 = 1
        // x ^ n = x * x ^ n-1 

        public int CalcularPotencia(int x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return x * CalcularPotencia(x, n - 1);
            }
        }
    }
}
