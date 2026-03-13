using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> paises = new Dictionary<string, string>();
            paises.Add("República Dominicana", "Santo Domingo");
            paises.Add("Colombia", "Bogota");
            paises.Add("Haiti", "Puerto Principe");

            Console.WriteLine("--- Aqui lista de Países y Capitales ---");
            foreach (var elemento in paises)
            {
                Console.WriteLine("País: " + elemento.Key + " | Capital: " + elemento.Value);
            }
            Console.ReadKey();
        }
    }
}