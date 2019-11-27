using System;

namespace Ejercicios_de_arregos
{
    //Leer 10 enteros, almacenarlos en un vector y determinar en qué posición del vector está el mayor número leído.
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 34, 54, 8, 0, 56, 76, 8, 9, 2, 3 };
            int valorMax = miarreglo[0];
            int posicion = 0;

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] > valorMax)
                {
                    valorMax = miarreglo[i];
                    posicion = i;

                }
            }
            Console.WriteLine($"El valor mayor se encuentra en la posicion {posicion}");
        }
    }
}
