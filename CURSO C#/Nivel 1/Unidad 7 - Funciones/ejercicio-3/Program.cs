using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("INGRESE UN NUMERO:");
            numero = int.Parse(Console.ReadLine());
            if(primo(ref numero) == 1)
            {
                Console.WriteLine("EL NUMERO INGRESADO ES PRIMO.");
            }
            else
            {
                Console.WriteLine("EL NUMERO INGRESADO NO ES PRIMO.");
            }
        }

        static int primo(ref int numero)
        {
            int contador=0;

            for(int i=1; i<=numero; i++)
            {
                if(numero % i == 0)
                {
                    contador++;
                }
                    
            }

            if(contador == 2)
            {
                return 1;
            }
                
            return 0;
        }
    }
}
