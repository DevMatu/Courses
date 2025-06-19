using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, numero4;
            Console.WriteLine("INGRESE 4 NUEMROS:");

            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            numero3 = int.Parse(Console.ReadLine());
            numero4 = int.Parse(Console.ReadLine());

            if(numero1 > numero2 && numero2 > numero3 && numero3 > numero4){
                Console.WriteLine("ORDENADOS DE MANERA DECRECIENTE.");
            }else{
                Console.WriteLine("NO ESTAN ORDENADOS DE MANERA DECRECIENTE.");
            }
        }
    }
}
