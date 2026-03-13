using System;
using System.Collections.Generic;

namespace Actividad3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== PROGRAMA DE CALIFICACIONES ESTUDIANTES ===");
        Console.WriteLine();

      
        Dictionary<string, int> misEstudiantes = new Dictionary<string, int>();


        misEstudiantes.Add("Ashly", 98);
        misEstudiantes.Add("Pedro", 75);
        misEstudiantes.Add("Maria", 88);

        
        Console.WriteLine("Paso 1: La nota vieja de Pedro era: " + misEstudiantes["Pedro"]);

     
        misEstudiantes["Pedro"] = 85;

   
        Console.WriteLine("La nota de pedro ahora es 85.");

      
        Console.ReadKey(); 
    }
}




