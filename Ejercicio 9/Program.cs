using System;

namespace Ejercicio_9
{
    /// <summary>
    /// 9. Leer 10 números enteros, almacenarlos en un vector y determinar cuántas veces está repetido el mayor.
   /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 34, 54, 8, 0, 56, 76, 8, 9, 2, 3 };
            int valorMax = miarreglo[0];
            int posicion = 0;

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] > valorMax)
                {

                    valorMax = miarreglo[i];
                    posicion = i;
                }
            }
            Console.WriteLine($"El valor mayor esta en la posicion {posicion}");
        }
    }
    }
}
