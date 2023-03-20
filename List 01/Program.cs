using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_01
{
    class Program
    {
        static void Main()
        {
            // Ingresar la cantidad de elementos de la lista
            Console.Write("Ingrese la cantidad de elementos: ");
            int cant = Convert.ToInt32(Console.ReadLine());

            // Declaración
            List<int> numeros = new List<int>(cant);

            // Rellenar la lista
            for (int i = 0; i < cant; i++)
            {
                Console.Write($"{i + 1}. ");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));
            }
            
            // Cantidad de elementos
            Console.WriteLine($"\nCantidad de elementos introducidos: {numeros.Count}");

            // Mostrar y eliminar el último elemento
            Console.WriteLine($"El último elemento ({numeros[numeros.Count - 1]}) " +
                              $"será eliminado.");
            numeros.RemoveAt(numeros.Count - 1);

            Console.WriteLine($"Cantidad actual de elementos: {numeros.Count}");

            // Mostrar elementos bucle for
            Console.WriteLine("\nMostrar los elementos de la lista:");
            Console.WriteLine("==================================");
            Console.Write("Bucle for: ");
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine();

            // Mostrar elementos bucle foreach
            Console.WriteLine("==================================");
            Console.Write("Bucle foreach: ");
            foreach(int numero in numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            // Mostar elementos enumerador
            Console.WriteLine("==================================");
            Console.Write("Enumerador: ");
            IEnumerator<int> enumerator = numeros.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + " ");
            }
            Console.WriteLine();
        }
    }
}
