using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool resultado;
            Console.Write("Ingrese un número entero: ");
            num = int.Parse(Console.ReadLine());
            resultado = calcular_rango(num);
            Console.WriteLine($"El número está en el rango del 1 al 100: {resultado}");
        }

        private static bool calcular_rango(int num)
        {
            if (num <= 100 && num >= 0)
                return true;
            else
                return false;
        }
    }
}
