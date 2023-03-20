using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet_01
{
    class Program
    {
        static void Main()
        {
            // HashSet es casi lo mismo, solo que consume más memoria a cambio de mayor
            // rapidez.
            SortedSet<string> frases = new SortedSet<string>(); 
                                                               
            bool salida = false;
            string frase;

            while (!salida)
            {
                Console.Write("Ingrese una palabra: ");
                frase = Console.ReadLine().ToLower();

                if (frase != "")
                {
                    if (frases.Contains(frase))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Esta palabra ya ha sido introducida anteriormente.");
                        Console.ResetColor();
                    }
                    else
                    {
                        frases.Add(frase);
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Palabra añadida exitosamente!");
                        Console.ResetColor();
                    }
                }
                else
                {
                    salida = true;
                }
            }

            Console.WriteLine($"Cantidad de palabras introducidas: {frases.Count}");
        }
    }
}
