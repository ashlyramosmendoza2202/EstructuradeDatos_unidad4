using System;
using System.Collections.Generic;

namespace Actividad8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Lista de Compras y Precios ---");
        Console.WriteLine();

        Dictionary<string, int> misCompras = new Dictionary<string, int>();

        misCompras.Add("Leche", 75);
        misCompras.Add("Pan", 40);
        misCompras.Add("Arroz", 35);
        misCompras.Add("Cafe", 150);

        Console.WriteLine("Articulos registrados:");

  
        foreach (var item in misCompras)
        {
            Console.WriteLine("Articulo: " + item.Key + " | Precio: $" + item.Value);
        }

        Console.ReadKey();
    }
}

