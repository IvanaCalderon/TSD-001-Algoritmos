using System;

namespace Ejercicio_16
{
    /// <summary>
    /// 16. Leer 10 números enteros, almacenarlos en un vector y determinar cuáles son los datos
    ///almacenados múltiplos de 3.

    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 34, 54, 8, 8, 56, 76, 8, 9, 2, 3 };

            

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] % 3 == 0)
                {
                    Console.WriteLine($"El numero {miarreglo[i]} es multiplo de 3");
                }
            }
           
        }
    }
}
