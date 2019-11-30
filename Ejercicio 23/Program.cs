using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Ejercicio_23
{
    /// <summary>
    /// 23. Leer 10 números enteros, almacenarlos en un vector y determinar si existe al menos un
    /// número repetido.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarreglo = new int[10] { 0, 2, 2, 3, 3, 5, 6, 6, 8, 9 };
            


            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                    if (j != i)
                    {
                        if (miarreglo[i] == miarreglo[j])
                        {
                            if (miarreglo[i] != miarreglo[i - 1])
                            {
                                Console.WriteLine("Se repite el num: " + miarreglo[j]);
                            }
                        }
                    }
            }

            Console.ReadKey();
        }




    }


}