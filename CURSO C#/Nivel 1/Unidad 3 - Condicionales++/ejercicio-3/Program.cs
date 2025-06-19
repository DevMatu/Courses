using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, suma, producto;
            Console.WriteLine("INGRESE 3 NUEMROS:");

            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            numero3 = int.Parse(Console.ReadLine());

            suma = numero1 + numero2;
            producto = numero2 * numero3;

            if(suma > producto)
                Console.WriteLine("LA SUMA ES MAYOR");
            
            else
                Console.WriteLine("LA SUMA NO ES MAYOR");
            
        }
    }
}
