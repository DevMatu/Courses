using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, numero4;
            Console.WriteLine("INGRESE 4 NUMEROS:");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            numero3 = int.Parse(Console.ReadLine());
            numero4 = int.Parse(Console.ReadLine());

            if(numero1 > numero2 && numero1 > numero3 && numero1 > numero4)
                Console.WriteLine("EL PRIMER NUMERO: " + numero1 + " ES EL MAS GRANDE.");
            else if(numero2 > numero1 && numero2 > numero3 && numero2 > numero4)
                Console.WriteLine("EL SEGUNDO NUMERO: " + numero2 + " ES EL MAS GRANDE.");
            else if(numero3 > numero1 && numero3 > numero2 && numero3 > numero4)
                Console.WriteLine("EL TERCER NUMERO: " + numero3 + " ES EL MAS GRANDE.");
            else
                Console.WriteLine("EL CUARTO NUMERO:" + numero4 + " ES EL MAS GRANDE.");
            
        }
    }
}
