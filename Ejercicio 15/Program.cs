﻿using System;

namespace Ejercicio_15
{
    /// <summary>
    /// 15. Leer 10 números enteros, almacenarlos en un vector y determinar cuántos datos almacenados
   /// son múltiplos de 3.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 34, 2, 8, 8, 56, 76, 8, 9, 2, 3 };
           
            int times = 0;

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] %3 == 0 )
                {
                    times = times + 1;
                }
            }
            Console.WriteLine($"En el vector hay {times} multiplos de 3");
        }
    }
}
