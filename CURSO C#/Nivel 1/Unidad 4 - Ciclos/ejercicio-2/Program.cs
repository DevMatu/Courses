using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, mayor = 0;
            Console.WriteLine("INGRESE 10 NUMEROS:");
            for(int i=0; i<3; i++)
            {
                numero = int.Parse(Console.ReadLine());
                if(numero > mayor)
                {
                    mayor = numero;
                }
            }
            Console.WriteLine("EL MAYOR DE LOS NUMEROS INGRESADOS ES: " + mayor);
        }
    }
}
