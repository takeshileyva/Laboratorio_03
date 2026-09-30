using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("¿El número termina en 0 o 5?");
            Console.WriteLine(calcular_5_0(num));
        }

        private static bool calcular_5_0(int num)
        {
            if (num % 5 == 0)
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
