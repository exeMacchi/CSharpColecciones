using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_03
{
    class Program
    {
        static void Main()
        {
            Queue<string> frases = new Queue<string>(5);
            string frase;
            byte cont = 0;

            while (cont < 5)
            {
                Console.Write($"{cont + 1}. Escriba una palabra: ");
                frase = Console.ReadLine();

                if (frase != "")
                {
                    frases.Enqueue(frase);
                    cont++;
                }
            }

            // Cantidad actual
            Console.WriteLine(Environment.NewLine + "Cantidad actual: " + frases.Count);

            // Forma de recorrer los elementos de la cola: Enumeradores
            Console.WriteLine("=======================");
            IEnumerator<string> enumerator = frases.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + " ");
            }
            Console.WriteLine("\n=======================");

            // Forma de recorrer los elementos de la cola: Foreach
            foreach (string s in frases)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("\n=======================");

            // Primer dato extraido
            Console.WriteLine("Primer dato de la cola: " + frases.Peek());
            Console.WriteLine("=======================");

            // Cantidad actual
            Console.WriteLine("Cantidad actual: " + frases.Count);
            Console.WriteLine("=======================");
        }
    }
}
