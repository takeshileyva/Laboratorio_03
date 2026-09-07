using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b, h, a;
            Console.Write("Ingrese la base del triángulo: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del triángulo: ");
            h = double.Parse(Console.ReadLine());
            a = calcular_area(b, h);
            Console.WriteLine($"El área del triángulo es: {a:F2}");
        }

        static double calcular_area(double b, double h)
        {
            double res = (b * h) / 2;
            return res;
        }
    }
}
