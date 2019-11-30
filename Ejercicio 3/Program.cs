using System;

namespace Ejercicio_3
{
    /// <summary>
    /// Leer 10 enteros, almacenarlos en un vector y determinar en qué posición del vector está el mayor número primo leído.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 34, 54, 8, 0, 56, 76, 8, 9, 2, 3 };
            int valorMax = miarreglo[0];
            int posicion = -1;

            for (int i = 0; i < 10; i++)
            {
                if (isPrime(miarreglo[i]))
                {
                    if (miarreglo[i] > valorMax || !isPrime(valorMax))
                    {
                        valorMax = miarreglo[i];
                        posicion = i;
                    }
                }
            }
            if (posicion == -1)
            {
                Console.WriteLine("No existen numeros primos en el listado");
            }
            else
            {
                Console.WriteLine($"El numero primo mayor se encuentra en la posicion {posicion}");
            }
        }

        static int[] numerosPrimos = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        static bool isPrime(int numero)
        {
            for(int i = 0; i < numerosPrimos.Length; i++)
            {
                if (numero == numerosPrimos[i])
                    return true;
            }
            return false;

        }
    }
}
