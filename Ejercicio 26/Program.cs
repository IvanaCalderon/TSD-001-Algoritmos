using System;

namespace Ejercicio_26
{
    /// <summary>
    /// 26. Leer 10 números enteros, almacenarlos en un vector y calcularle el factorial a cada uno de los
    ///números leídos almacenándolos en otro vector.
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            int[] factoriales = new int[13];
            factoriales[0] = 1;
            factoriales[1] = 1;

            for (int i = 2; i < 13; ++i)
            {
                factoriales[i] = i * factoriales[i - 1];
            }

            for (int i = 0; i < 13; ++i)
            {
                Console.WriteLine(factoriales[i]);
            }
        }
    }
}
