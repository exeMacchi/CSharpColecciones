using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_02
{
    class Program
    {
        static void Main()
        {
            Stack<string> pilaCadenas = new Stack<string>();
            bool salir = false;

            // Se agregan cadenas a la pila hasta que se ingrese una vacía.
            while (!salir)
            {
                Console.Write("Ingrese una palabra: ");
                string cadena = Console.ReadLine();

                if (cadena != "")
                {
                    pilaCadenas.Push(cadena);
                }
                else
                {
                    salir = true;
                }
            }

            // Se muestran todos los elementos de la pila (del último en entrar al primero)
            Console.WriteLine("=========================");
            while (pilaCadenas.Count > 0)
            {
                Console.WriteLine(pilaCadenas.Pop());
            }
            Console.WriteLine("=========================");
        }
    }
}
