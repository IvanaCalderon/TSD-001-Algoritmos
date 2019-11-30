using System;

namespace Ejercicio_13
{/// <summary>
 /// 13. Leer 10 números enteros, almacenarlos en un vector y determinar si el promedio entero de
 /// estos datos está almacenado en el vector.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 34, 29, 8, 25, 56, 76, 8, 9, 2, 3 };
            int sumaTotal = 0;
           
            for (int i = 0; i < 10; i++)
            {
                sumaTotal = sumaTotal + miarreglo[i];
            }

            int promedio = sumaTotal / 10;

            for (int i = 0; i < 10; i++)
            {
                if (promedio == miarreglo[i])
                {
                    Console.WriteLine($"El promedio entero esta almacenado en la posicion {i}");
                }
                else Console.WriteLine("No se encuentra");
            }
            
                
            
                

                
        }
    }
}
