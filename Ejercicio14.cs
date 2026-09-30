using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            Console.Write("Ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el cuarto número: ");
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine(calcular_mayor(num1, num2, num3, num4));
            Console.ReadKey();
        }

        private static string calcular_mayor(int num1, int num2, int num3, int num4)
        {
            if (num1 > num2 && num1 > num3 && num1 > num4)
            {
                return "El mayor número es: " + num1;
            }
            else if (num2 > num1 && num2 > num3 && num2 > num4)
            {
                return "El mayor número es: " + num2;
            }
            else if (num3 > num1 && num3 > num2 && num3 > num4)
            {
                return "El mayor número es: " + num3;
            }
            else if (num4 > num1 && num4 > num2 && num4 > num3)
            {
                return "El mayor número es: " + num4;
            }
            else
                return "Todos son iguales";
        }
    }
}
