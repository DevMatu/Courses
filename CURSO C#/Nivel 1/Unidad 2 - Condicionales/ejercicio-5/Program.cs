using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, numero4;
            const int cien = 100;
            Console.WriteLine("INGRESE 4 NUMEROS:");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            numero3 = int.Parse(Console.ReadLine());
            numero4 = int.Parse(Console.ReadLine());

            if(numero1 > cien)
                Console.WriteLine("EL PRIMER NUMERO: " + numero1 + " ES MAYOR A CIEN.");
            if(numero2 > cien)
                Console.WriteLine("EL SEGUNDO NUMERO: " + numero2 + " ES MAYOR A CIEN.");
            if(numero3 > cien)
                Console.WriteLine("EL TERCER NUMERO: " + numero3 + " ES MAYOR A CIEN.");
            if(numero4 > cien)
                Console.WriteLine("EL CUARTO NUMERO: " + numero4 + " ES MAYOR A CIEN.");
            
        }
    }
}
