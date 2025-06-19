using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador = 0;
            const int CANTIDAD_NUMEROS = 2;
            for(int i=0; i<CANTIDAD_NUMEROS; i++)   
            {

                Console.WriteLine("INGRESE UN NUMERO:");
                numero = int.Parse(Console.ReadLine());
                if(par(ref numero) == 1)
                {
                    contador++;
                }

            }
            
            Console.WriteLine("NUMEROS PARES:" + contador);

        }

        static int par(ref int numero)
        {
            const int DIVISOR = 2;
            int resultado = numero % DIVISOR;
            if(resultado == 0)
                return 1;
            else
                return 0;

        }
    }
}
