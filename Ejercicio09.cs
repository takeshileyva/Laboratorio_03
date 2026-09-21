using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Ingrese un número entero: ");
            n = int.Parse(Console.ReadLine());
            bool rpta = calcular_par_positivo(n);
            Console.WriteLine(rpta);
            Console.ReadKey();
        }

        private static bool calcular_par_positivo(int n)
        {
            if (n % 2 == 0 && n > 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
