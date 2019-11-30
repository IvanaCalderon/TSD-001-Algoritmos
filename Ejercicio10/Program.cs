using System;

namespace Ejercicio10
{/// <summary>
 /// 10. Leer 10 números enteros, almacenarlos en un vector y determinar en qué posiciones se
 ///   encuentran los números con mas de 3 dígitos.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 34, 54, 8, 0, 1548, 76, 8, 9, 2, 3 };
            int posicion = 0;
            

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] >= 1000)
                {
                     posicion = i;
                 Console.WriteLine($"Existe un valor mayor de tres digitos en la posicion {posicion}");


                }
                
            }    
            
        }
    }
}
