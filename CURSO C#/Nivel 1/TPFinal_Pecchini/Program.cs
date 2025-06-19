using System;

namespace TPFinal_Pecchini
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Ingrese Primer Numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Segundo Numero: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 = n2)
            {
             Console.WriteLine("Son iguales!");
            }
            else
            {
             Console.WriteLine("No son iguales!");
            }
        }
    }
}
