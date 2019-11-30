using System;

namespace Ejercicio_29
{/// <summary>
 /// 29. Leer 10 números enteros, almacenarlos en un vector y mostrar en pantalla todos los enteros
/// comprendidos entre 1 y cada uno de los dígitos de cada uno de los números almacenados en
///el vector.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 123, 456, 899, 4546, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(numeros[i] + ": ");
                do
                {
                    int limite = numeros[i] % 10;

                    Console.Write(limite + ": ");
                    for (int j = 1; j <= limite; ++j)
                    {
                        Console.Write(j + ", ");
                    }
                    Console.WriteLine();

                    numeros[i] = numeros[i] / 10;
                }
                while (numeros[i] > 0);

                Console.WriteLine();
            }
        }
    }
}
