using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Ingrese el primer número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            b = int.Parse(Console.ReadLine());
            calcular_cociente_residuo(a, b, out int q, out int r);
            Console.WriteLine($"El cociente es: {q}");
            Console.WriteLine($"El residuo es: {r}");
        }

        private static void calcular_cociente_residuo(int a, int b, out int q, out int r)
        {
            q = a / b;
            r = a % b;
        }
    }
}
