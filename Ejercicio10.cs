using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anio;
            Console.Write("Ingrese el año: ");
            anio = int.Parse(Console.ReadLine());
            bool rpta = calcular_bisiesto(anio);
            Console.WriteLine(rpta);
            Console.ReadKey();
        }

        private static bool calcular_bisiesto(int anio)
        {
            if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
