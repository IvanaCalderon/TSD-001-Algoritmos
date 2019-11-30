using System;

namespace Ejercicio_22
{/// <summary>
 /// 22. Leer 10 números enteros, almacenarlos en un vector y determinar cuáles son los números
 /// múltiplos de 5 y en qué posiciones están.

/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 12, 2, 12, 10, 13, 76, 5, 2, 2, 4 };
            int valorvar = miarreglo[0];
            int posicion = 0;

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] % 5 == 0)
                {
                    
                    valorvar = miarreglo[i];
                    posicion = i;

                    Console.WriteLine($"el numero {valorvar} es multiplo de 5 y se encuentre en la posicion {posicion}");
                }
            }
            
        }
    }
}
