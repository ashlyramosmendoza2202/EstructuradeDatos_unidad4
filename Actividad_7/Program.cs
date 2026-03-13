using System;
using System.Collections.Generic;

namespace Actividad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Buscador de Objetos de la Casa ---");
            Console.WriteLine();

 
            Dictionary<string, string> miCasa = new Dictionary<string, string>();

            miCasa.Add("Estufa", "Cocina");
            miCasa.Add("Cama", "Habitacion");
            miCasa.Add("Sofa", "Sala");
            miCasa.Add("Espejo", "Baño");

         
            string objetoABuscar = "Estufa";

            Console.WriteLine("Buscando en la casa: " + objetoABuscar);

    
            if (miCasa.ContainsKey(objetoABuscar))
            {
                Console.WriteLine("Resultado: Claro! La " + objetoABuscar + " esta registrada en el sistema.");
            }
            else
            {
                Console.WriteLine("Resultado: No se encontro ese objeto en la lista.");
            }

        
            Console.ReadKey();
        }
    }
}
