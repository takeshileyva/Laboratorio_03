using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("¿El número es impar y negativo?");
            Console.WriteLine(verificar(num));
        }

        private static bool verificar(int num)
        {
            if (num % 2 != 0 && num < 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
