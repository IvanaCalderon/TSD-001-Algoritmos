using System;

namespace Ejercicio_19
{
    /// <summary>
    /// 19. Leer 10 números enteros, almacenarlos en un vector y determinar cuál es el número menor.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 34, 54, 8, 78, 56, 76, 8, 9, 6, 3 };
            int valorMin = miarreglo[0];
            

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] < valorMin)
                {
                    valorMin = miarreglo[i];
                    
                }
            }
            Console.WriteLine($"El valor menor es {valorMin}");
        }
    }
    }

