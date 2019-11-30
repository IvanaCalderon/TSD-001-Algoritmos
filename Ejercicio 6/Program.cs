using System;

namespace Ejercicio_6
{
    class Program
    {/// <summary>
     /// 6. Leer dos números enteros y almacenar en un vector los 10 primeros números primos
     ///   comprendidos entre el menor y el mayor.Luego mostrarlos en pantalla.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = 100, b = 300;
            int max, min;

            if (a > b)
            {
                max = a;
                min = b;
            }
            else
            {
                max = b;
                min = a;
            }

            bool[] isPrime = new bool[max + 1];

            for (int i = 0; i <= max; ++i)
                isPrime[i] = true;

            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 2; i <= max; ++i)
            {
                if (isPrime[i])
                {
                    for (int j = 2; i * j <= max; ++j)
                    {
                        isPrime[i * j] = false;
                    }
                }
            }

            int[] resultado = new int[10];
            for (int i = min, j = 0; i <= max && j < 10; ++i)
            {
                if (isPrime[i])
                {
                    resultado[j] = i;
                    ++j;
                }
            }

            Console.WriteLine($"Los 10 primeros numeros primos entre {min} y {max} son:");
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(resultado[i]);
            }
        }
    }
}
