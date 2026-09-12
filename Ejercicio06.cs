using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string total;
            Console.Write("Ingrese un número entero: ");
            num = int.Parse(Console.ReadLine());
            total = calcular_primo(num);
            Console.WriteLine(total);
        }

        private static string calcular_primo (int num)
        {
            if (num <= 1) return "No es primo";
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return "No es primo";
            }
            return "Es primo";
        }
    }
}
