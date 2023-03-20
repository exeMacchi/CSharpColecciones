using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_01
{
    class Program
    {
        static void Main()
        {
            // Declaración
            SortedList<string, string> listaOrdenada = new SortedList<string, string>();

            // Agregar elementos con claves y valores
            listaOrdenada["Adios"] = "Good bye";
            listaOrdenada.Add("Hola", "Hello");

            // Mostrar valores de los elementos a partir de sus claves
            Console.WriteLine(listaOrdenada["Hola"]);
            if (listaOrdenada.ContainsKey("Adios"))
            {
                Console.WriteLine(listaOrdenada["Adios"]);
            }
        }
    }
}
