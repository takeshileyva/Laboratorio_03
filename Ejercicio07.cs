using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, resultado;
            Console.Write("Ingrese un número entero: ");
            num = int.Parse(Console.ReadLine());
            resultado = calcular_digitos(num);
            Console.WriteLine($"La cantidad de digitos es: {resultado}");
        }

        private static int calcular_digitos(int num)
        {
            if (num == 0) return 1;

            int contador = 0;
            num = Math.Abs(num);

            while (num > 0)
            {
                num = num / 10; 
                contador++;     
            }
            return contador; 
        }
    }
}
