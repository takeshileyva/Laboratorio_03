using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string mayor;
            Console.Write("Ingrese el primer número entero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número entero: ");
            b = int.Parse(Console.ReadLine());
            mayor = calcular_mayor(a, b);
            Console.WriteLine(mayor);
        }

        private static string calcular_mayor(int a, int b)
        {
            if (a > b)
                return "El mayor es: " + a;
            else if (b > a)
                return "El mayor es: " + b;
            else
                return "Son iguales";
        }
    }
}
