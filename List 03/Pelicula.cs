using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_03
{
    class Pelicula : IComparable<Pelicula> // Interfaz genérica que permite desarollar un
                                           // criterio de ordenación sobreescribiendo
                                           // la función CompareTo()
    {
        public Pelicula(string titulo, string director, int anioEstreno)
        {
            this.titulo = titulo;
            this.director = director;
            this.anioEstreno = anioEstreno;
        }

        private string titulo;
        private string director;
        private int anioEstreno;

        public string Titulo { get { return titulo; } }
        public string Director { get { return director; } }
        public int AnioEstreno { get { return anioEstreno; } }


        public override string ToString()
        {
            return ($"Título: {Titulo}\n" +
                    $"Director: {Director}\n" +
                    $"Año de estreno: {AnioEstreno}");
        }

        public int CompareTo(Pelicula peli)
        {
            return (this.AnioEstreno.CompareTo(peli.AnioEstreno));
        }
    }
}
