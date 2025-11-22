using System;

namespace Arreglo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alan Daniel Garcia Mendez / 2025-1403
            int[] valores = { 10000, 15000, 12000, 18000, 17887 };


            int suma = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                suma += valores[i];
            }

            Console.WriteLine("La suma de los valores es igual a " + suma);

            Console.ReadLine();
        }
    }
}
