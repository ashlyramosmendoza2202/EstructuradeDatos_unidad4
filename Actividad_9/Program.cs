using System;
using System.Collections.Generic;

namespace Actividad9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Calculo Total de Gastos ---");
        Console.WriteLine();

        Dictionary<string, int> misGastos = new Dictionary<string, int>();

        misGastos.Add("Internet", 1200);
        misGastos.Add("Luz", 1500);
        misGastos.Add("Agua", 300);
        misGastos.Add("Basura", 150);

   
        int sumaTotal = 0;

      
        foreach (int monto in misGastos.Values)
        {
            sumaTotal = sumaTotal + monto;
        }

        Console.WriteLine("El total de los gastos de la casa es: $" + sumaTotal);

        Console.ReadKey();
    }
}