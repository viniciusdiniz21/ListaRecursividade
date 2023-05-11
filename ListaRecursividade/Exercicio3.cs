using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRecursividade
{
    public class Exercicio3
    {
        public void Inverter(int[] array, int inicio, int fim)
        {
            if (inicio >= fim)
            {
                return;
            }

            int aux = array[inicio];
            array[inicio] = array[fim];
            array[fim] = aux;

            Inverter(array, inicio + 1, fim - 1);
        }
    }
}
