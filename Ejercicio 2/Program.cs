using System;

namespace Ejercicio_2
{
    /// <summary>
    /// Leer 10 enteros, almacenarlos en un vector y determinar en qué posición del vector está el mayor número par leído.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 87, 54, 8, 0, 56, 76, 8, 9, 2, 3 };
            int valorMax = miarreglo[0];
            int posicion = 0;

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] % 2 == 0)
                {
                    if (miarreglo[i] > valorMax || valorMax%2 == 1)
                    {
                        valorMax = miarreglo[i];
                        posicion = i;
                    }
                }
            }
            Console.WriteLine($"El valor par mayor, se encuentra en la posicion {posicion}");
        }
    }
}
