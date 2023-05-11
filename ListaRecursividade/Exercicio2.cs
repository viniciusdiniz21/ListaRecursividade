using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRecursividade
{
    public class Exercicio2
    {
        // i = array.Length - 1
        // Earray = array[i] + array[i + 1]
        // E-> Somatório
        public double CalcularArray(double[] array, int indice)
        {
            if (indice == array.Length - 1)
            {
                return array[indice];
            }
            else
            {
                return array[indice] + CalcularArray(array, indice + 1);
            }
        }
    }
}
