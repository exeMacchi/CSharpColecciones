using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_01
{
    class Program
    {
        static void Main()
        {
            // Declaración
            Queue<int> cola = new Queue<int>();

            // Agregar elementos
            cola.Enqueue(20);
            cola.Enqueue(10);
            cola.Enqueue(5);

            // Devolver y quitar elementos
            while (cola.Count > 0)
            {
                int numCola = cola.Dequeue();
                Console.Write(numCola + " ");
            }
            Console.WriteLine();
        }
    }
}
