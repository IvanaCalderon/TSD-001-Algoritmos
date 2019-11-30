using System;

namespace Ejercicio_14
{/// <summary>
 /// 14. Leer 10 números enteros, almacenarlos en un vector y determinar cuántas veces se repite el
  ///  promedio entero de los datos dentro del vector.

/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 34, 25, 8, 25, 56, 76, 8, 9, 2, 7 };
            int sumaTotal = 0;
            int times = 0;

            for (int i = 0; i < 10; i++)
            {
                sumaTotal = sumaTotal + miarreglo[i];
            }

            int promedio = sumaTotal / 10;

            for (int i = 0; i < 10; i++)
            {
                if(promedio == miarreglo[i])
                {
                    times = times + 1;

                }
            }

                Console.WriteLine($"El promedio se repite {times} veces");
        }
    }
}
