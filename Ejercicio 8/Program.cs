using System;

namespace Ejercicio_8
{
    class Program
    {/// <summary>
 /// 8. Leer 10 números enteros, almacenarlos en un vector y determinar en qué posiciones se
 ///  encuentran los números terminados en 4.
 /// </summary>
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 14, 2, 1004, 10, 13, 76, 5, 3, 2, 4 };
            int posicion = 0;
            

            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] % 10 == 4 || miarreglo[i] % 100 == 4 || miarreglo[i] % 1000 == 4)
                {
                    posicion = i;
                    Console.WriteLine($"Un numero terminado en 4 se encuentra en la posicion {posicion}");
                      
                        
                    }





                
            }
            
        }
    }
}
