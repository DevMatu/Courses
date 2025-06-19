using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantLitros;

            Console.WriteLine("INGRESE LA CANTIDAD DE LITROS VENDIDOS:");
            cantLitros = int.Parse(Console.ReadLine());

            switch(cantLitros){
                case 101:
                case 300:
                    Console.WriteLine("10% DE DESCUENTO.");
                break;

                case 301:
                case 500:
                    Console.WriteLine("15% DE DESCUENTO.");
                break;

                default:
                    if(cantLitros <= 100){
                        Console.WriteLine("LOS LITROS NO SUPERAN LOS 100, NO HAY DESCUENTO.");
                    }
                    else{
                        Console.WriteLine("25% DE DESCUENTO.");
                    }
                break;
            }
        }
    }
}
