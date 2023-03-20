using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_01
{
    class Program
    {
        static void Main()
        {
            // Declaración
            LinkedList<int> numeros = new LinkedList<int>();

            // Agregar nodos en la primera posición (los números salen en orden decreciente)
            foreach (int n in new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10})
            {
                numeros.AddFirst(n);
            }

            Console.Write("Nodos agregados desde la primera posición: ");
            foreach (int n in numeros)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.ReadKey();

            // Borrar todos los nodos
            Console.WriteLine("Nodos eliminados...");
            numeros.Clear();
            Console.ReadKey();
            
            // Agregar nodos en la última posición (los números salen en orden creciente)
            foreach (int n in new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })
            {
                numeros.AddLast(n);
            }

            Console.Write("Nodos agregados desde la última posición: ");
            foreach (int n in numeros)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
