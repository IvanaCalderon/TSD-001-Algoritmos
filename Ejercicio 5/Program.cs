using System;

namespace Ejercicio_5
{/// <summary>
/// 5. Almacenar en un vector de 10 posiciones los 10 números primos comprendidos entre 100 y
///300. Luego mostrarlos en pantalla.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isPrime = new bool[301];

            for (int i = 0; i < 300; ++i)
                isPrime[i] = true;

            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 2; i <= 300; ++i)
            {
                if (isPrime[i])
                {
                    for (int j = 2; i * j < 301; ++j)
                    {
                        isPrime[i * j] = false;
                    }
                }
            }

            Console.WriteLine("Los numeros primos entre 100 y 300 son:");
            for (int i = 100; i < 301; ++i)
            {
                if (isPrime[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
