using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LENGHT = 10;
            int[] numeros = new int[LENGHT];
            int acu = 0;
            float prom;

            Console.WriteLine("INGRESE 10 NUMEROS ENTEROS:");
            for(int i=0; i<LENGHT; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i<LENGHT; i++)
            {
                acu += numeros[i];
            }

            prom = acu/LENGHT;
            Console.WriteLine("EL PROMEDIO DE TODOS LOS NUMEROS INGRESADOS ES: " + prom);

            Console.WriteLine("NUMEROS INGRESADOS MAYORES AL PROMEDIO:");
            for(int i=0; i<LENGHT; i++)
            {
                if(numeros[i] > prom)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
        }
    }
}
