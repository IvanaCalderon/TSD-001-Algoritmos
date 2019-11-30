using System;

namespace Ejercicio_18
{
    class Program
    {/// <summary>
     /// 18. Leer 10 números enteros, almacenarlos en un vector y determinar en qué posiciones están los
      ///  números positivos.
    /// </summary>
    
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { -34, -54, 8, 0, 56, -76, 8, 9, 2, 3 };

            

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] > 0)
                {

                    Console.WriteLine($"Se encuentra un numero positivo en la posicion {i}");
                        
                }
            }
            
        }
    }
}
