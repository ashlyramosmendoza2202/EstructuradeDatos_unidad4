using System;
using System.Collections.Generic;

namespace MiTareaEjercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Lista de Frutas (Solo Nombres) ---");
            Console.WriteLine();

            Dictionary<string, string> misFrutas = new Dictionary<string, string>();

            misFrutas.Add("Manzana", "Roja");
            misFrutas.Add("Banana", "Amarilla");
            misFrutas.Add("Uva", "Morada");
            misFrutas.Add("Pera", "Verde");
            misFrutas.Add("Naranja", "Anaranjada");

            Console.WriteLine("Las frutas en mi diccionario son:");

            
            foreach (string fruta in misFrutas.Keys)
            {
                Console.WriteLine("- " + fruta);
            }

       
            Console.ReadKey();
        }
    }
}