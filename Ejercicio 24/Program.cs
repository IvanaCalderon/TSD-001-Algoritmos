using System;

namespace Ejercicio_24
{
    class Program
    {/// <summary>
     /// 24. Leer 10 números enteros, almacenarlos en un vector y determinar en qué posición está el
     ///   número con mas dígitos
    /// </summary>
    /// <param name="args"></param>
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
            Console.WriteLine($"El valor con mas digitos se encuentra en la posicion {posicion}");
        }
    }
}
