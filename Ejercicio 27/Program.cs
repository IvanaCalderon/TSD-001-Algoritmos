using System;

namespace Ejercicio_27
{/// <summary>
 /// 27. Leer 10 números enteros, almacenarlos en un vector y determinar a cuánto es igual el
 ///   promedio entero de los factoriales de cada uno de los números leídos.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 12, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] factoriales = new int[13];
            factoriales[0] = 1;
            factoriales[1] = 1;
            for (int i = 2; i < 13; ++i)
            {
                factoriales[i] = i * factoriales[i - 1];
            }

            int promedio = 0;
            for (int i = 0; i < 10; ++i)
            {
                promedio = promedio + factoriales[numeros[i]];
            }
            promedio = promedio / 10;

            Console.WriteLine("El promedio de los factoriales es: ");
            Console.WriteLine(promedio);
        }
    }
}
