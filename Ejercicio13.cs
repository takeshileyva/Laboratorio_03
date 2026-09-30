using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(calcular_mayor(num1, num2));
            Console.ReadKey();
        }

        private static string calcular_mayor(int num1, int num2)
        {
            if (num1 > num2)
            {
                return "El mayor número es: " + num1;
            }
            else if (num2 > num1)
            {
                return "El mayor número es: " + num2;
            }
            else
                return "Son el mismo número";
        }
    }
}
