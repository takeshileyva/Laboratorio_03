using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            string mayor;
            Console.Write("Ingrese el primer número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el cuarto número: ");
            d = int.Parse(Console.ReadLine());
            mayor = calcular_mayor(a, b, c, d);
            Console.WriteLine(mayor);

        }

        private static string calcular_mayor(int a, int b, int c, int d)
        {
            if (a > b && a > c && a > d)
                return "El mayor es: " + a;
            else if (b > a && b > c && b > d)
                return "El mayor es: " + b;
            else if (c > a && c > b && c > d)
                return "El mayor es: " + c;
            else if (d > a && d > b && d > c)
                return "El mayor es: " + d;
            else
                return "Todos los números son iguales";
        }
    }
}
