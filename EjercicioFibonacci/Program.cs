using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador, num1, num2, num3, n;
            bool salida;
            contador = 0;
            num1 = 0;
            num2 = 1;
            num3 = 0;
            salida = true;
            Console.WriteLine("cuantos numeros de la secuencia de fibonacci se desea conocer");
            
            n= int.Parse(Console.ReadLine());

            do
            {
                contador++;
                num3 = num1 + num2;
                num2 = num1;
                num1 = num3;
                Console.WriteLine(num3);

                if (n == contador) { salida = false; } 
            }

            while (salida);

        }
    }
}
