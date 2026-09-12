using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, total;
            Console.Write("Ingresa la cantidad de números: ");
            num = int.Parse(Console.ReadLine());
            total = suma_numeros(num);
            Console.WriteLine($"La suma de los {num} primeros números es: {total}");
        }

        private static int suma_numeros(int num)
        {
            int suma = 0;
            for (int i = 0; i <= num; i++)
            {
                suma = num + i;
            }
            return suma;
        }
    }
}
