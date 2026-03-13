using System;
using System.Collections.Generic;

namespace Actividad4;
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("=== INVENTARIO DE MAQUILLAJE - BORRAR PRODUCTOS ===");
            Console.WriteLine();

            Dictionary<string, string> misMaquillajes = new Dictionary<string, string>();

            misMaquillajes.Add("Base", "Fenty Beauty");
            misMaquillajes.Add("Rimel", "Maybelline");
            misMaquillajes.Add("Labial", "MAC");

            Console.WriteLine("Tengo " + misMaquillajes.Count + " productos en mi lista.");

            Console.WriteLine("Eliminando el 'Labial' del inventario...");
            misMaquillajes.Remove("Labial");

   
            Console.WriteLine("Ahora solo me quedan " + misMaquillajes.Count + " productos.");
            Console.WriteLine();

            Console.WriteLine("--- Productos que quedan ---");
            foreach (var item in misMaquillajes)
            {
                Console.WriteLine("Producto: " + item.Key + " | Marca: " + item.Value);
            }

            Console.ReadKey();
        }
    }
