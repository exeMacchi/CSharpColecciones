using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_02
{
    class Program
    {
        static void Main()
        {
            Queue<string> colaCadenas = new Queue<string>();
            bool salir = false;

            // Se agregan elementos hasta que se escriba una cadena vacía.
            while (!salir)
            {
                Console.Write("Escriba algo: ");
                string cadena = Console.ReadLine();

                if (cadena != "")
                {
                    colaCadenas.Enqueue(cadena);
                }
                else
                {
                    salir = true;
                }
            }

            // Se muestran todas los elementos de la cola.
            Console.WriteLine("===================================");
            while (colaCadenas.Count > 0)
            {
                Console.WriteLine(colaCadenas.Dequeue());
            }
            Console.WriteLine("===================================");

            Console.ReadKey();
        }
    }
}
