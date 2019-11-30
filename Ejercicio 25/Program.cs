using System;

namespace Ejercicio_25
{/// <summary>
 /// 25. Leer 10 números enteros, almacenarlos en un vector y determinar cuántos de los números
 ///   leídos son números primos terminados en 3.

/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 143, 2, 365, 10, 13, 76, 5, 3, 2, 4 };
            int valorvar = miarreglo[0];
            int posicion = 0;

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] % 2 == 1)
                {
                    if (miarreglo[i] % 10 == 3 || miarreglo[i] % 100 == 3 || miarreglo[i] %1000 == 3)
                    {
                        posicion = posicion + 1;

                    }

                   
                

                  
                }
            }
            Console.WriteLine($"Existen {posicion} numeros primos terminados en 3");
        }
    }
}
