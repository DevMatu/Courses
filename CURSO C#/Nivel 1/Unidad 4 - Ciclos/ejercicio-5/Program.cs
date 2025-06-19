using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado, maximoPar = 0, minimoImpar = 0;
            const int dos = 2;
            Console.WriteLine("INGRESE 20 NUMEROS");

            for(int i=0; i<20; i++)
            {
                numero = int.Parse(Console.ReadLine());
                resultado = numero%dos;
                if(resultado == 0)
                {
                    if(maximoPar == 0)
                    {
                        maximoPar = numero;
                    }
                    else if(numero > maximoPar)
                    {
                        maximoPar = numero;
                    }
                }
                else
                {
                    if(minimoImpar == 0)
                    {
                        minimoImpar = numero;
                    }
                    else if(numero < minimoImpar)
                    {
                        minimoImpar = numero;
                    }
                }
            }

            Console.WriteLine("EL MAXIMO DE LOS PARES ES: " + maximoPar);
            Console.WriteLine("EL MINIMO DE LOS IMPARES ES: " + minimoImpar);
        }
    }
}
