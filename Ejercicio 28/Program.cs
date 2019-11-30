using System;

namespace Ejercicio_28
{/// <summary>
 /// 28. Leer 10 números enteros, almacenarlos en un vector y mostrar en pantalla todos los enteros
 ///   comprendidos entre 1 y cada uno de los números almacenados en el vector.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 12, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < 10; ++i)
            {
                for (int j = 1; j <= numeros[i]; ++j)
                {
                    Console.Write(j + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
