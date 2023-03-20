using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_03
{
    class Program
    {
        static void Main()
        {
            List<Pelicula> peliculas = new List<Pelicula>
            {
                new Pelicula("Sleepy Hollow", "Tim Burton", 1999),
                new Pelicula("The Lighthouse", "Robert Eggers", 2019),
                new Pelicula("Whiplash", "Damien Chazelle", 2014),
                new Pelicula("Brokeback Mountain", "Ang Lee", 2005)
            };

            // Listado sin criterio de ordenanza
            Console.WriteLine("Listado de películas sin ordenar:");
            foreach (Pelicula pelic in peliculas)
            {
                Console.WriteLine(pelic + "\n");
            }
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");

            // Ordenación con comparador CompareTo() desarrollado en la clase
            peliculas.Sort();

            // Listado con criterio de ordenanza IComparable
            Console.WriteLine("Listado de películas ordenados según el criterio " +
                              "desarrollado en la clase (por fecha):");
            foreach (Pelicula pelic in peliculas)
            {
                Console.WriteLine(pelic + "\n");
            }
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");


            // Ordenación con comparador lambda
            peliculas.Sort( (p1, p2) => (p1.Titulo.CompareTo(p2.Titulo)) );
            
            // Listado con criterio de ordenanza lambda
            Console.WriteLine("Listado de películas ordenados con el comparador desarrollado " +
                              "en una expresión lambda (alfabéticamente):");
            foreach (Pelicula pelic in peliculas)
            {
                Console.WriteLine(pelic + "\n");
            }
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");
        }
    }
}
