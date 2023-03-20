using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_02
{
    class Program
    {
        static void Main()
        {
            // Declarar e inicializar una lista manualmente.
            List<int> listaNumerosPares = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            // Remover los números impares de la lista.
            for (int i = listaNumerosPares.Count - 1; i >= 0; i--)
            {
                if (listaNumerosPares[i] % 2 != 0)
                {
                    listaNumerosPares.RemoveAt(i);
                }
            }

            // Mostrar los números pares a partir de un bucle foreach
            Console.Write("Los números pares de la lista: ");
            foreach (int par in listaNumerosPares)
            {
                Console.Write(par + " ");
            }
            Console.WriteLine();
        }
    }
}
