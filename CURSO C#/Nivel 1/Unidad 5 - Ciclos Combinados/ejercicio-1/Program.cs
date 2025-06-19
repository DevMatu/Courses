using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;
            int contador = 0;
            Console.WriteLine("INGRESE 10 NUMEROS:");

            for(int i=0; i<10; i++)
            {
                int contador2 = 0;
                numero = int.Parse(Console.ReadLine());

                for(int x=1; x<=numero; x++)
                {
                    resultado = numero % x;
                    if(resultado == 0)
                    {
                        contador2++;
                    }
                }

                if(contador2 == 2)
                {
                    contador++;
                }

            }
            
            Console.WriteLine("SE INGRESARON " + contador + " NUMEROS PRIMOS.");
        }
    }
}
