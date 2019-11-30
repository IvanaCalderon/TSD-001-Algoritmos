using System;

namespace Ejercicio_30
{
    /// <summary>
    /// 30. Leer 10 números enteros, almacenarlos en un vector. Luego leer un entero y determinar si este
   /// último entero se encuentra entre los 10 valores almacenados en el vector.

    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 2, 54, 81, 0, 56, 76, 8, 9, 2, 3 };
            int mivalor = 0;


            int posicion = -1;

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] == mivalor)
                {
                    posicion = i;
                    break;
                }
            }

            if(posicion == -1)
            {
                Console.WriteLine("No se encuentra el valor");
            }
            else
            {
                Console.WriteLine($"El valor esta en la posicion {posicion}");
            }
        }
    }
}
