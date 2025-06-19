using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            const int cero = 0;
            Console.WriteLine("INGRESE UN NUMERO:");
            numero = int.Parse(Console.ReadLine());

            if(numero > cero)
                Console.WriteLine("EL NUMERO ES POSITIVO");
            else if(numero < cero)
                Console.WriteLine("EL NUMERO ES NEGATIVO");
            else
                Console.WriteLine("EL NUMERO ES CERO");
        }
    }
}
