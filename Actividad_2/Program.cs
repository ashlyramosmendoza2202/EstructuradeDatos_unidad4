using System;
using System.Collections.Generic;

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Precios de Productos ---");
            Console.WriteLine();

            Dictionary<string, double> misProductos = new Dictionary<string, double>();

            misProductos.Add("Pizza", 500.00);
            misProductos.Add("Refresco", 65.50);
            misProductos.Add("Hamburguesa", 250.00);

           
            Console.WriteLine("El precio del producto Refresco es: $" + misProductos["Refresco"]);

         
            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}