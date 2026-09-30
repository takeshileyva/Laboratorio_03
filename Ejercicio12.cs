using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("El número está fuera del rango 0 - 100?");
            Console.WriteLine(calcular_rango(num));
        }

        private static bool calcular_rango(int num)
        {
            if (num > 100 || num < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
