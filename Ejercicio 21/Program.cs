using System;

namespace Ejercicio_21
{
    /// <summary>
    /// 21. Leer 10 números enteros, almacenarlos en un vector y determinar en qué posición está el
   /// número cuya suma de dígitos sea la mayor.
   /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 34, 54, 8, 0, 56, 76, 8, 9, 2, 3 };
            int valorMax = 0;
            int posicion = 0;

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] + miarreglo[i] > valorMax)
                {
                    valorMax = miarreglo[i] +miarreglo[i];
                    posicion = i;
                }
            }
            Console.WriteLine($"El numero valor esta en la posicion {posicion}");
        }
    }
}
