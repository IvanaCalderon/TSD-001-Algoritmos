using System;

namespace Ejercicio_12
{/// <summary>
 /// 12. Leer 10 números enteros, almacenarlos en un vector y determinar a cuánto es igual el promedio entero de los datos del vector.

/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 34, 54, 8, 0, 56, 76, 8, 9, 2, 3 };
            int sumaTotal = 0;

            for (int i = 0; i < 10; i++)
            {
                sumaTotal = sumaTotal + miarreglo[i];
            }

            int promedio = sumaTotal / 10;

            Console.WriteLine($"El promedio de los elementos es {promedio}");
        }
    }
    }

