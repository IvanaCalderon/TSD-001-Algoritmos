using System;

namespace Ejercicio_20
{/// <summary>
 /// 20. Leer 10 números enteros, almacenarlos en un vector y determinar en qué posición está el
   /// menor número primo.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 12, 2, 12, 67, 13, 76, 3, 2, 2, 4 };
            int valorMax = miarreglo[0];
            int posicion = 0;

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] % 2 == 1)
                {
                    if (miarreglo[i] < valorMax)
                        valorMax = miarreglo[i];
                        posicion = i;
                }
            }
            Console.WriteLine($"El menor numero primo se encuentra en la  posicion {posicion} ");
        }
    }
}
