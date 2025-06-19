using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int parcial1, parcial2, parcial3, totalNotas;
            float notaFinal;
            Console.WriteLine("INGRESE LA NOTA DEL PARCIAL 1:");
            parcial1 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE LA NOTA DEL PARCIAL 2:");
            parcial2 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE LA NOTA DEL PARCIAL 3:");
            parcial3 = int.Parse(Console.ReadLine());

            totalNotas = parcial1+parcial2+parcial3;
            notaFinal = totalNotas/3;

            Console.WriteLine("NOTA FINAL: " + notaFinal);
        }
    }
}
