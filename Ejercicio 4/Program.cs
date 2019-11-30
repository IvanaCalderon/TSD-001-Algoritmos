using System;

namespace Ejercicio_4
{
    /// <summary>
    /// Cargar un vector de 10 posiciones con los 10 primeros elementos de la serie de Fibonacci y mostrarlo en pantalla
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10];
            miarreglo[0] = 1;
            miarreglo[1] = 1;
            for (int i = 2; i < 10; ++i)
            {
                miarreglo[i] = miarreglo[i - 1] + miarreglo[i - 2];
            }

            Console.WriteLine("Los primeros 10 numeros de la sequencia fibonacci: ");
            for(int i =0;i<10;++i)
            {
                Console.WriteLine(miarreglo[i]);
            }
        }
    }
}
