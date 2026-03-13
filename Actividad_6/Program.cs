using System;
using System.Collections.Generic;

namespace Actividad6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Lista de Colores (Solo Valores) ---");
        Console.WriteLine();

        Dictionary<string, string> misFrutas = new Dictionary<string, string>();

        misFrutas.Add("Manzana", "Roja");
        misFrutas.Add("Banana", "Amarilla");
        misFrutas.Add("Uva", "Morada");
        misFrutas.Add("Pera", "Verde");
        misFrutas.Add("Naranja", "Anaranjada");

        Console.WriteLine("Los colores disponibles son:");


        foreach (string color in misFrutas.Values)
        {
            Console.WriteLine("-> Color: " + color);
        }

        Console.ReadKey();
    }
}
