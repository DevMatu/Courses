using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DELARAMOS VARIABLES//
            int numero_1, numero_2, resultado;
            
            //PEDIMOS LOS DATOS//
            Console.WriteLine("INGRESE UN NUMERO:");
            numero_1 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE OTRO:");
            numero_2 = int.Parse(Console.ReadLine());

            //REALIZAMOS OPERACION//
            resultado = numero_1 + numero_2;

            //MOSTRAMOS RESULTADO//
            Console.WriteLine("El RESULTADO ES:" + resultado);
        }
    }
}
