using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado, resultado2;
            const int uno = 1;
            Console.WriteLine("INGRESE UN NUMERO:");
            numero = int.Parse(Console.ReadLine());
            
            resultado = numero%numero;
            resultado2 = numero%uno;
            
            if(resultado == 0 && resultado2 == 0)
            {
                Console.WriteLine("EL NUMERO ES PRIMO");
            }
            else
            {
                Console.WriteLine("EL NUMERO NO ES PRIMO");
            }

        }
    }
}
