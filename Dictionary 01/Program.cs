using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_01
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Componente> componentes = new Dictionary<string, Componente>
            {
                { "111AA", new Componente("111AA", "DISCO DURO", "Kingston", "SSD 240GB", 
                                          7732f) },
                { "222BB", new Componente("222BB", "MEMORIA RAM", "Fury Beast", "RGB 8GB", 
                                          15512f) },
                { "333CC", new Componente("333CC", "TARJETA GRAFICA", "GeForce", "RTX 3060Ti", 
                                          332806f) },
                { "444DD", new Componente("444DD", "MONITOR", "Samsung", "2234S", 23432f) },
                { "555EE", new Componente("555EE", "MONITOR", "LG", "43A5F", 18999f) }
            };

            bool salida = false, hayResultado;
            byte opcionUsuario;
            string textoABuscar;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Buscar por código");
                Console.WriteLine("2. Buscar por categoría");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese una opción: ");
                opcionUsuario = Convert.ToByte(Console.ReadLine());

                if (opcionUsuario >= 0 && opcionUsuario <= 2)
                {
                    switch (opcionUsuario)
                    {
                        case 1: BusquedaPorCodigo(componentes); break;

                        case 2: BusquedaPorCategoria(componentes); break;

                        case 0: salida = true; break;
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Error: opción no disponible");
                    Console.ResetColor();
                }
            } while (!salida);
        }

        static void BusquedaPorCodigo(Dictionary<string, Componente> componentes)
        {
            Console.Write("\nEscribe el código del componente: ");
            string textoABuscar = Console.ReadLine().ToUpper();

            if (componentes.ContainsKey(textoABuscar))
            {
                Console.WriteLine(componentes[textoABuscar]);

                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\nPresione \"Enter\" para volver al menú principal.");
                Console.ResetColor();
                Console.ReadKey();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Componente no encontrado. Presione \"Enter\" para " +
                                  "volver al menú principal.");
                Console.ResetColor();
                Console.ReadKey();
            }
        }

        static void BusquedaPorCategoria(Dictionary<string, Componente> componentes)
        {
            Console.Write("\nEscribe el nombre de la categoría: ");
            string textoABuscar = Console.ReadLine().ToUpper();
            bool hayResultado = false;

            foreach (KeyValuePair<string, Componente> componente in componentes)
            {
                if (componente.Value.Categoria == textoABuscar)
                {
                    Console.WriteLine(componente.Value);
                    hayResultado = true;
                }
            }

            if (!hayResultado)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("No se han encontrado resultados concordantes. " +
                                  "Presione \"Enter\" para volver al menú principal");
                Console.ResetColor();
                Console.ReadKey();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\nPresione \"Enter\" para volver al menú principal.");
                Console.ResetColor();
                Console.ReadKey();
            }

        }
    }
}
