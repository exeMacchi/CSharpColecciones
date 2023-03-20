using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_01
{
    class Program
    {
        static void Main()
        {
            Stack<int> pila = new Stack<int>();

            // Agregar elementos a la pila
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(5);

            // Cantidad actual de elementos en la pila
            Console.WriteLine("Cantidad de elementos actuales en la pila: " + pila.Count);

            // Mostrar el elemento de la cima de la pila (el último en entrar)
            Console.WriteLine("El primer elemento de la pila: " + pila.Peek());
            Console.WriteLine("=================================");

            // Recorrer los elementos de la pila con un enumerador
            Console.WriteLine("Elementos de la pila: ");
            IEnumerator<int> e = pila.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }
            Console.WriteLine("=================================");

            // Mostrar y eliminar elementos de la pila
            Console.WriteLine("Elementos de la pila eliminándolos: ");
            while (pila.Count > 0)
            {
                Console.WriteLine(pila.Pop());
            }

            /*
                Mostrar elementos con bucle for

                for (int i = pila.Count; i > 0; i--)
                {
                    Console.WriteLine(pila.Pop());
                }
            */

            // Cantidad actual de elementos en la pila
            Console.WriteLine("Cantidad de elementos actuales en la pila: " + pila.Count);
        }
    }
}
