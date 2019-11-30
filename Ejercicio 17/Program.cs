using System;

namespace Ejercicio_17
{
    /// <summary>
    /// 17. Leer 10 números enteros, almacenarlos en un vector y determinar cuántos números negativos
   /// hay.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { -34, -54, 8, 0, 56, -76, 8, 9, 2, 3 };
           
            int times = 0;

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] < 0)
                {
                    
                    times = times + 1;
                }
            }
            Console.WriteLine($"En el vector hay {times} numeros negativos");

        }
    }
}
